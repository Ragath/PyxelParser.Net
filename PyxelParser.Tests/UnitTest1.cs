using System.Drawing;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PyxelParser.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestParsing()
        {
            const string file = @"Data\Data_0_4_3.pyxel";
            using (var document = new Document(File.OpenRead(file)))
            {
                //Metadata
                var metadata = document.MetaData.Value;
                Assert.IsNotNull(metadata);
                if (metadata.Version != "0.4.3")
                    Assert.Inconclusive();

                //Images
                if (!metadata.Canvas.Layers.Any())
                    Assert.Inconclusive();

                var images = document.GetImages(i => Image.FromStream(i.Stream));
                foreach (var img in images)
                    Assert.IsNotNull(img.Value);

                //Tiles
                var tiles = (from l in metadata.Canvas.Layers
                             from tr in l.Value.TileRefs
                             select tr.Value.Index).Distinct().ToArray();
                if (!tiles.Any())
                    Assert.Inconclusive();
                CollectionAssert.IsSubsetOf(tiles.Select(t => $"tile{t}.png").ToArray(), images.Select(i => i.Path).ToArray());
            }
        }
    }
}
