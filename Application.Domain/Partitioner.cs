using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Domain
{
    public class Partitioner
    {
        private int _partitionSize;

        public Partitioner(int partitionSize)
        {
            this._partitionSize = partitionSize;
        }

        public Partition Partition(List<Share> sharesList)
        {
            IList<IList<Share>> partioningResult = new List<IList<Share>>();
            int currentIndex =0 ;
            while (currentIndex < sharesList.Count)
            {
                List<Share> subGroup = sharesList.Skip(currentIndex).Take(_partitionSize).ToList();
                currentIndex += _partitionSize;
                partioningResult.Add(subGroup);
            }
            return new Partition() { PartitioningResult = partioningResult, Size = partioningResult.Count };
        }
    }
}
