using System.IO;

namespace PyxelParser.Tests.Data
{
    static class Resources
    {
        public static Stream GetStream(string filename) 
            => typeof(Resources).Assembly.GetManifestResourceStream(typeof(Resources), filename);
    }
}
