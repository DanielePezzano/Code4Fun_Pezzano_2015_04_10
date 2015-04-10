using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Problem1.Tests
{
    [TestClass()]
    public class SeriesCalculationTests
    {
        [TestMethod()]
        public void CalculateSumTest()
        {
            SeriesCalculation s = new SeriesCalculation();
            Assert.IsTrue(s.CalculateSum(3, 10) == 18);
            Assert.IsTrue(s.CalculateSum(5, 15) == 15);
        }
    }
}
