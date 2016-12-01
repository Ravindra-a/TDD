using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Complex
{
    public class DefaultPartitioner : IPartitioner
    {
        private readonly int _size;

        public DefaultPartitioner(int size)
        {
            _size = size;
        }
 
        public IEnumerable<IEnumerable<Observation>> Partition(IList<Observation> observations)
        {
            List<List<Observation>> observation = new List<List<Observation>>();
            int total = 0;
            while (total < observations.Count)
            {
                List<Observation> obj = new List<Observation>();
                obj = observations.Skip(total).Take(_size).ToList();
                //yield return observations.Skip(total).Take(_size);
                observation.Add(obj);
                total += _size;
            }
            return observation;
        }
    }
}
