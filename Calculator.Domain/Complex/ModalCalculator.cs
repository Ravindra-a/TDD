using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Complex
{
    public class ModalCalculator
    {
        public Observation AggregateCollection(IEnumerable<Observation> observations)
        {
            double highValue = observations.GroupBy(m => m.HighValue)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key).FirstOrDefault();

            double lowValue = observations.GroupBy(m => m.LowValue)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key).FirstOrDefault();

            return new Observation()
            {
                HighValue = highValue,
                LowValue = lowValue
            };
        }
    }
}
