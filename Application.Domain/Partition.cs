using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Domain
{
    public class Partition
    {
        public object Size { get; set; }
        public IList<IList<Share>> PartitioningResult;
    }
}
