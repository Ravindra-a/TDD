using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Complex
{
    public class Aggregator
    {
        private readonly IList<Observation> _observations;

        public Aggregator(IList<Observation> observations)
        {
            _observations = observations;
        }

        public IEnumerable<Observation> Aggregate(IPartitioner partitioner,
                                                          ICalculator calculator)
        {
            var partitions = partitioner.Partition(_observations);
            foreach (var partition in partitions)
            {
                yield return calculator.AggregateCollection(partition);
            }
        }
    }
}
