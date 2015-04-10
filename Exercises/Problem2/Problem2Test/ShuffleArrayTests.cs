using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Problem2.Tests
{
    [TestClass()]
    public class ShuffleArrayTests
    {
        [TestMethod()]
        public void ShuffleArrayTest()
        {
            ShuffleArray shuffleTest = new ShuffleArray(20);
            int[] shuffled = shuffleTest.DoShuffle();
            int[] shuffledWithDuplicates = new int[10] { 1, 3, 4, 6, 4, 3, 2, 34, 45, 12 };

            var groupForTest = shuffled.GroupBy(c => c).Select(x => new { Item = x.Key, ItemCount = x.Count() });
            var groupWithDuplicates = shuffledWithDuplicates.GroupBy(c => c).Select(x => new { Item = x.Key, ItemCount = x.Count() });

            Assert.IsFalse(groupForTest.Any(x => x.ItemCount > 1));
            Assert.IsTrue(groupWithDuplicates.Any(x => x.ItemCount > 1));
            Assert.IsTrue(shuffled.Length == 20);
        }
    }
}
