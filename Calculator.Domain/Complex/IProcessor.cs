using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Calculator.Domain.Complex
{
    public interface IProcessor
    {
        IEnumerable<Observation> LoadandAggregateData(XDocument document);
    }
}
