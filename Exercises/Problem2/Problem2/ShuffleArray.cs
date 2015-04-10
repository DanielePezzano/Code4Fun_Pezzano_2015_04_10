using System;
using System.Collections.Generic;

namespace Problem2
{
    /// <summary>
    /// This class expose a public method that permit to shuffle a
    /// built in ordered int list of number from 1 to N (where N equals the limit)
    /// and return a shuffled array of size N with the same number contained in
    /// the ordered list but with no duplicates
    /// </summary>
    public sealed class ShuffleArray
    {
        private List<int> _OrderedList = new List<int>();
        private List<int> _ShuffledList = new List<int>();
        private Int64 _Limit = 1;

        private static Random _Random;

        public ShuffleArray(Int64 limit)
        {
            this._Limit = limit;
            _Random = new Random();
            SetOrderedList();
        }

        private void SetOrderedList()
        {
            for (int index = 0; index < _Limit; index++)
            {
                _OrderedList.Add(index);
            }
        }

        /// <summary>
        /// This method Shuffles the ordered list.
        /// In order to avoid any possible duplicates the solution is simple:
        /// 1)  Get a random position of the ordered list
        /// 2)  fill the value found with point 1 index in the shuffled list
        /// 3)  remove the selected position in the ordered list
        /// </summary>
        /// <returns></returns>
        public int[] DoShuffle()
        {
            int count = _OrderedList.Count;

            while (count>0)
            {
                int index = _Random.Next(0, count);
                _ShuffledList.Add(_OrderedList[index]);
                _OrderedList.RemoveAt(index);
                count = _OrderedList.Count;
            }

            return _ShuffledList.ToArray();
        }
    }
}
