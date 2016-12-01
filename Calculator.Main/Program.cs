using Calculator.Domain.Complex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Calculator.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor processor = new Processor();
            IEnumerable<Observation> observations = processor.LoadandAggregateData(XDocument.Load("observations.xml"));
            foreach (Observation o in observations)
            {
                Console.WriteLine("{0}:{1}", o.LowValue, o.HighValue);
            }

            Console.ReadLine();
        }
    }
}
