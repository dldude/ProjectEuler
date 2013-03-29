using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class Problem2
    {
        public bool EvenValued { get; set; }
        public bool OddValued { get; set; }
        public bool ForTerms { get; set; }
        public bool ForCeiling { get; set; }

        private List<Int32> Sequence = new List<Int32>();

        public List<Int32> GenerateFibonacciSequence(Int32 number)
        {
            Sequence.Add(0);

            if (ForTerms && number > 0)
                GenerateSequenceForTerms(number);

            if (ForCeiling && number > 0)
                GenerateSequenceForCeiling(number);

            return Sequence;
        }

        private void GenerateSequenceForTerms(int numberOfTerms)
        {
            int previous = 1;
            int calc = 0;
            int sum = 0;
            for (int i = 0; i < numberOfTerms; i++)
            {
                if (calc == 0)
                {
                    Sequence.Add(previous);
                    calc = previous + previous;
                    Sequence.Add(calc);
                }
                else
                {
                    sum = previous + calc;
                    Sequence.Add(sum);
                    previous = calc;
                    calc = sum;
                }
            }
        }

        private void GenerateSequenceForCeiling(Int32 ceiling)
        {
            int previous = 1;
            int calc = 0;
            while (Sequence.Sum() < ceiling)
            {
                if (calc == 0)
                {
                    Sequence.Add(previous);
                    calc = previous + previous;
                    Sequence.Add(calc);
                }

            }
        }
    }
}
