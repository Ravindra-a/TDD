using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Calculator.Domain.Complex
{
    public class Processor : ProcessorBase, IProcessor
    {
        public IEnumerable<Observation> LoadandAggregateData(XDocument document)
        {
            List<Observation> observationList = ParseMeasurements(document);
            return AggregateMeasurements(observationList);
        }

        public override IEnumerable<Observation> AggregateMeasurements(List<Observation> observationList)
        {
            Aggregator aggregator = new Aggregator(observationList);
            IPartitioner partitioner = new DefaultPartitioner(2);
            ICalculator calculator = new AveragingCalculator();
            IEnumerable<Observation> observations = aggregator.Aggregate(partitioner, calculator);
            return observations;
        }

        public override List<Observation> ParseMeasurements(XDocument document)
        {
            List<Observation> observationList = new List<Observation>();
            //XDocument document = XDocument.Load("observations.xml");

            foreach (XElement element in document.Element("Observations").Elements())
            {
                double highValue = (double)element.Attribute("High");
                double lowValue = (double)element.Attribute("Low");
                Observation observation = new Observation();
                observation.HighValue = highValue;
                observation.LowValue = lowValue;
                observationList.Add(observation);
            }
            return observationList;
        }
    }
}
