using Knapsack_Project.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack_Project.Tools
{
    internal class cprCompare : IComparer
    {
        public int Compare(Object x, Object y)
        {
            item item1 = (item)x;
            item item2 = (item)y;
            double cpr1 = (double)item1.value
                          / (double)item1.weight;
            double cpr2 = (double)item2.value
                          / (double)item2.weight;

            if (cpr1 < cpr2)
                return 1;

            return cpr1 > cpr2 ? -1 : 0;
        }
    }

}
