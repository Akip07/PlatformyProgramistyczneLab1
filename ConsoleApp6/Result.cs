using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Result
    {
        List<int> itemsId = new List<int>();
        int totalWeight = 0;
        int totalValue = 0;

        public int GetTotalWeight() { return totalWeight; }
        public int GetTotalValue() {  return totalValue; }
        public void Add(Item item)
        {
            itemsId.Add(item.getId());
            totalWeight += item.GetWeight();
            totalValue += item.GetValue();

        }
        override public string ToString()
        {
            string str = $"RESULT \nTotal weight:\t{totalWeight}\nTotal value:\t{totalValue}\nItem list:\t";
            for (int i = 0; i < itemsId.Count; i++)
            {
                str += $"{itemsId[i]}\t";
            }
            return str;
        }

    }
}
