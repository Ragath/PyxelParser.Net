using System;

namespace PyxelParser
{
    /// <summary>
    /// Facilitates lazy loading of images
    /// </summary>
    /// <typeparam name="TImage"></typeparam>
    public class LazyImage<TImage> : Lazy<TImage>
    {
        /// <summary>
        /// Path to image in archive
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// <see cref="Lazy{T}.Lazy(Func{T})"/>
        /// </summary>
        /// <param name="path"></param>
        /// <param name="valueFactory"></param>
        public LazyImage(string path, Func<TImage> valueFactory) : base(valueFactory)
        {
            Path = path;
        }
    }
}
