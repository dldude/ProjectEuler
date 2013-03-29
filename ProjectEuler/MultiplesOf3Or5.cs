using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class MultiplesOf3Or5
    {
        private List<int> _sum;

        public Int32 GetSumOfMultiplesBelow(int number)
        {
            if (number == 0)
                return 0;

            if (number < 3)
                return 0;

            _sum = new List<int>();

            SumWholeNumbersForThree(number);

            SumWholeNumbersForFive(number);

            return _sum.Sum();
        }

        private void SumWholeNumbersForThree(int belowNumber)
        {
            //var sum = new List<int>();
            for(int i = 1; i < belowNumber; i++)
            {
                _sum.Add((i % 3) == 0 ? i : 0);
            }

            //return sum;
        }

        private void SumWholeNumbersForFive(int belowNumber)
        {
            //var sum = new List<int>();
            for (int i = 1; i < belowNumber; i++)
            {
                if (!_sum.Contains((i % 5) == 0 ? i : 0))
                    _sum.Add((i % 5) == 0 ? i : 0);
            }

            //return sum;
        }
    }
}
