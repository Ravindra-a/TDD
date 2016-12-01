using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Domain.Complex
{
    public interface IPartitioner
    {
        IEnumerable<IEnumerable<Observation>> Partition(IList<Observation> observations);
    }
}
