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


    }
}