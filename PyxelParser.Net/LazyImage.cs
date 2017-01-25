using System;

namespace PyxelParser
{
    public class LazyImage<TImage> : Lazy<TImage>
    {
        public string Path { get; }

        public LazyImage(string path, Func<TImage> valueFactory) : base(valueFactory)
        {
            Path = path;
        }
    }
}
