using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Complex
{
    public class AveragingCalculator : ICalculator
    {
        public Observation AggregateCollection(IEnumerable<Observation> observations)
        {
            return new Observation()
            {
                HighValue = observations.Average(m => m.HighValue),
                LowValue = observations.Average(m => m.LowValue)
            };
        }
    }
}
