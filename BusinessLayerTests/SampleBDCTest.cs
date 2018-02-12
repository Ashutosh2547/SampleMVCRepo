using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;

namespace BusinessLayerUnitTest
{
    [TestClass]
    public class SampleBDCTest
    {
        [TestMethod]
        public void GetApplicationHeading_ForEveryCall_ReturnsDummyValue()
        {
            #region Arrange

            SampleBDC sampleBDC = new SampleBDC();

            #endregion Arrange


            #region Act & Assert
            var heading = sampleBDC.GetApplicationHeading();

            Assert.AreEqual(heading, ".NET MVC WebApplication ts");

            #endregion Act & Assert
        }
    }
}
