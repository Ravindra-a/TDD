using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Calculator.Domain.Complex
{
    public abstract class ProcessorBase
    {
        public abstract IEnumerable<Observation> AggregateMeasurements(List<Observation> observationList);
        public abstract List<Observation> ParseMeasurements(XDocument document);

    }
}
