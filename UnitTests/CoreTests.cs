using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Models;
using Core.Services;

namespace UnitTests
{
    [TestClass]
    public class CoreTests
    {
        [TestMethod]
        public void Test_AddBand()
        {
            var service = new BandService();
            var band = new Band { Name = "Sample Band" };
            service.AddBand(band);

            var bands = service.GetAllBands();
            Assert.AreEqual(1, bands.Count);
            Assert.AreEqual("Sample Band", bands[0].Name);
        }

        // ... More unit tests for other functionalities ...
    }
}
