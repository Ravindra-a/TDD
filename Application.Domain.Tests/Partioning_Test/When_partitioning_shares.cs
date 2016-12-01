using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Domain;

namespace Application.Domain.Tests.Partioning_Test
{
    [Category("Application.Domain.Partitioning")]
    [TestFixture]
    public class When_partitioning_shares
    {

        List<Share> _sharesList;

        [SetUp]
        public void SetupTest()
        {
            _sharesList = CreateSharesListofSize(4);
        }

        [Test]
        public void Partitioning_a_list_of_one_item_by_one_produces_a_partition_of_size_one()
        {
            List<Share> sharesList = new List<Share>();

            Share shareOne = new Share();
            shareOne.Maximum = 100;
            shareOne.Minimum = 13;
            sharesList.Add(shareOne);
            sharesList.Add(new Share() { Maximum = 50, Minimum = 10 });  

            Partitioner partitioner = new Partitioner(1);
            var partition = partitioner.Partition(sharesList);

            Assert.AreEqual(2, partition.Size);
        }

        [Test]
        public void partitioning_a_list_of_four_items_by_one_produces_a_partition_of_size_four()
        {
            Partitioner partitioner = new Partitioner(1);
            var partition = partitioner.Partition(_sharesList);

            Assert.AreEqual(4, partition.Size);
        }

        [Test]
        public void partitioning_a_list_of_four_items_by_four_produces_a_partition_of_size_one()
        {
            Partitioner partitioner = new Partitioner(4);
            var partition = partitioner.Partition(_sharesList);

            Assert.AreEqual(1, partition.Size);
        }

        [Test]
        public void partitioning_a_list_of_four_items_by_two_produces_a_partition_of_size_two()
        {
            Partitioner partitioner = new Partitioner(2);
            var partition = partitioner.Partition(_sharesList);

            Assert.AreEqual(2, partition.Size);
        }


        private List<Share> CreateSharesListofSize(int size)
        {
            List<Share> shares = new List<Share>();
            for(int i=0;i<size;i++)
            {
                shares.Add(new Share() {Minimum = 100 , Maximum = 150 });
            }
            return shares;
        }
    }
}
