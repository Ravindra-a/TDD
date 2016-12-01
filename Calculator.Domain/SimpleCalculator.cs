using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Domain
{
    public class SimpleCalculator
    {

        public CalculationResult Add(int p1, int p2)
        {
            if (p1 == int.MaxValue || p2 == int.MaxValue)
            {
                throw new NotSupportedException("Max values not supported");
            }
            return new CalculationResult() { OutCome = p1 + p2};
        }
    }
}
