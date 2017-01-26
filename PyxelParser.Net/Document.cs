using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using Newtonsoft.Json;

namespace PyxelParser
{
    /// <summary>
    /// *.pyxel Archive
    /// </summary>
    public sealed class Document : IDisposable
    {
        /// <summary>
        /// Image entry in archive
        /// </summary>
        public struct ImageEntry
        {
            /// <summary>
            /// Image stream
            /// </summary>
            public Stream Stream { get; }

            /// <summary>
            /// Image path
            /// </summary>
            public string Path { get; }
            
            internal ImageEntry(Stream stream, string path)
            {
                Stream = stream;
                Path = path;
            }
        }

        /// <summary>
        /// Underlying ZipArchive
        /// </summary>
        public ZipArchive ZipArchive { get; }

        /// <summary>
        /// MetaData
        /// </summary>
        public Lazy<PyxelData> MetaData { get; }

        /// <summary>
        /// Initialize a wrapper for a *.pyxel archive
        /// </summary>
        /// <param name="stream"></param>
        public Document(Stream stream)
        {
            ZipArchive = new ZipArchive(stream, ZipArchiveMode.Read, true);

            MetaData = new Lazy<PyxelData>(() =>
            {
                using (var stream1 = ZipArchive.GetEntry("docData.json").Open())
                {
                    using (var reader = new StreamReader(stream1))
                    {
                        return (PyxelData)new JsonSerializer().Deserialize(reader, typeof(PyxelData));
                    }
                }
            });
        }

        /// <summary>
        /// Retrieve a collection of images
        /// </summary>
        /// <typeparam name="TImage"></typeparam>
        /// <param name="imageLoader"></param>
        /// <returns></returns>
        public IReadOnlyCollection<LazyImage<TImage>> GetImages<TImage>(Func<ImageEntry, TImage> imageLoader)
        {
            TImage ImageFactory(ZipArchiveEntry entry)
            {
                using (var stream = entry.Open())
                {
                    return imageLoader(new ImageEntry(stream, entry.FullName));
                }
            }

            var factories = from e in ZipArchive.Entries
                            where e.Name.EndsWith(".png")
                            select new LazyImage<TImage>(e.FullName, () => ImageFactory(e));

            return factories.ToArray();
        }

        /// <summary>
        /// <see cref="IDisposable.Dispose"/>
        /// </summary>
        public void Dispose()
        {
            ((IDisposable)ZipArchive).Dispose();
        }
    }
}
