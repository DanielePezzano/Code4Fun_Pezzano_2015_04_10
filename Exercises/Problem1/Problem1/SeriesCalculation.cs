using System;

namespace Problem1
{
    public sealed class SeriesCalculation
    {
        private Int64 _Sum;
        private Int64 _Current;

        /// <summary>
        /// This Method return the sum of all the multiple of a certain base, 
        /// below the limit passed as parameter.
        /// eg.
        /// 
        /// Find the sum of all the multples of 3, below X
        /// </summary>
        /// <param name="multipleBase">multiple we want to find</param>
        /// <param name="limit">limit of the multiple</param>
        /// <returns></returns>
        public Int64 CalculateSum(int multipleBase, Int64 limit)
        {
            this._Sum = 0;
            this._Current = 1;

            Int64 currentSum = multipleBase * _Current;

            while (currentSum < limit)
            {
                this._Sum += currentSum;
                this._Current++;
                currentSum = multipleBase * _Current;
            }

            return this._Sum;
        }
    }
}
