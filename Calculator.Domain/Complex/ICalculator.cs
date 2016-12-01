using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Domain.Complex
{
    public interface ICalculator
    {
        Observation AggregateCollection(IEnumerable<Observation> observations);
    }
}
