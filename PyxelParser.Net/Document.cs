using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using Newtonsoft.Json;

namespace PyxelParser
{
    public sealed class Document : IDisposable
    {
        public struct ImageEntry
        {
            public Stream Stream { get; }
            public string Path { get; }

            public ImageEntry(Stream stream, string path)
            {
                Stream = stream;
                Path = path;
            }
        }

        public ZipArchive ZipArchive { get; }

        public Lazy<PyxelData> MetaData { get; }

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

        public void Dispose()
        {
            ((IDisposable)ZipArchive).Dispose();
        }
    }
}
