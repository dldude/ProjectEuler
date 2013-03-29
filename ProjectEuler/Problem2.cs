﻿using System;
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
        private int _previous = 1;
        private int _calc = 0;
        private int _sum = 0;

        public List<Int32> GenerateFibonacciSequence(Int32 number)
        {
            if (!ForTerms && !ForCeiling)
                Sequence.Add(0);

            if (ForTerms && number > 0)
                GenerateSequenceForTerms(number);

            if (ForCeiling && number > 0)
                GenerateSequenceForCeiling(number);

            return Sequence;
        }

        private void GenerateBaseSequence()
        {
            Sequence.Add(_previous);
            _calc = _previous + _previous;
            Sequence.Add(_calc);
        }

        private void GenerateSequenceForTerms(int numberOfTerms)
        {
            GenerateBaseSequence();
            for (int i = 1; i < numberOfTerms - 1; i++)
            {
                _sum = _previous + _calc;
                Sequence.Add(_sum);
                _previous = _calc;
                _calc = _sum;
            }
        }

        private void GenerateSequenceForCeiling(Int32 ceiling)
        {
            GenerateBaseSequence();
            while (Sequence.Sum() < ceiling)
            {
                _sum = _previous + _calc;
                Sequence.Add(_sum);
                _previous = _calc;
                _calc = _sum;
            }

            if (Sequence.Sum() > ceiling)
            {
                var listCount = Sequence.Count();
                Sequence.RemoveAt(listCount - 1);
            }
        }
    }
}
