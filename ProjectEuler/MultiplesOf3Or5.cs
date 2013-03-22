﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class MultiplesOf3Or5
    {
        public Int32 GetSumOfMultiplesBelow(int number)
        {
            if (number == 0)
                return 0;

            if (number < 3)
                return 0;

            var multipleThreeSum = SumWholeNumbersForThree(number);


            return multipleThreeSum;
        }

        private Int32 SumWholeNumbersForThree(int belowNumber)
        {
            
            var sum = 0;
            for(int i = 1; i < belowNumber; i++)
            {
                //var number = (i * 3);
                sum += (i % 3) == 0 ? i : 0;
            }

            return sum;
        }
    }
}
