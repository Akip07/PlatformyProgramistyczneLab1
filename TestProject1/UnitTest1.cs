using ConsoleApp6;
using System.Collections.Generic;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckIfAtLeastOneElement()
        {
            Backpack bckp = new(0, 0);
            bckp.items.Add(new Item(1, 10, 1));
            Result r = bckp.Solve(1);
            Assert.IsTrue(r.GetTotalValue() > 0);
        }

        [TestMethod]
        public void CheckIfNoneWhenTooBig()
        {
            Backpack bckp = new(0, 0);
            bckp.items.Add(new Item(1, 10, 10));
            Result r = bckp.Solve(1);
            Assert.IsTrue(r.GetTotalValue() == 0);

        }

        [TestMethod]
        public void CheckDifferentOrder()
        {
            Backpack bckp1 = new (3, 2137);
            Backpack bckp2 = new(3, 2137);
            bckp2.items.Reverse();

            Result r1 = bckp1.Solve(15);
            Result r2 = bckp2.Solve(15);

            Assert.AreEqual(r1.GetTotalValue(), r2.GetTotalValue());

        }

        [TestMethod]
        public void CheckResultValue()
        {
            Backpack bckp = new(0, 0);
            for(int i = 0; i<10; i++)
            {
                bckp.items.Add(new Item(i, i, 10 - i));
            }
            Console.WriteLine(bckp.Solve(15).itemsId);
            List<int> result = bckp.Solve(15).itemsId;
            List<int> check = new List<int> { 9, 8, 7, 6, 5 };

            foreach (var n in result.Zip(check, Tuple.Create))
            {
                Assert.AreEqual(n.Item1, n.Item2);
            }

        }

        [TestMethod]
        public void CheckForNegativeNumberOfItems()
        {
            Backpack bckp = new(-5,420);
            Assert.AreEqual(bckp.items.Count, 0);

          
        }

        [TestMethod]
        public void CheckForNegativeValuesOfItems()
        {
            Backpack bckp = new(0, 0);
            bckp.items.Add(new Item(0, -10, 10));
            bckp.items.Add(new Item(0, 10, -10));
            Assert.AreEqual(bckp.items[0].GetValue(), 0);
            Assert.AreEqual(bckp.items[1].GetWeight(), 0);

        }

        [TestMethod]
        public void CheckIfExecutesForManyItems()
        {
            try
            {
                Backpack bckp = new(10000, 420);
                bckp.Solve(10000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Program crashed");
            }
            
            
        }

        [TestMethod]
        public void CheckForNegativeCapacity()
        {
            Backpack bckp = new Backpack(5, 420);
            Assert.IsTrue(bckp.Solve(-10).GetTotalWeight() == 0);
            Assert.IsTrue(bckp.Solve(-10).GetTotalValue() == 0);

        }


    }
}