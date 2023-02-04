using System.Collections.Generic;
using System.Windows.Controls.Primitives;
using Knapsack_Project.DTO;

namespace Knapsack_Project
{
    public class BackTracking_Algorithm
    {


        public long max(long a, long b) { return (a > b) ? a : b; }
        public double totalVal = 0;
        public List<long> company_list = new List<long>();
        public long recurison( item[] items, double W,long n)                                       //Time Complexity O(2^n)
        {

          
            if (n == 0 || W == 0)
                return 0;

            if (items[n - 1].weight > W)
                return recurison( items,W, n - 1);
            else
                return max(items[n - 1].value
                           + recurison( items, W - items[n - 1].weight,   n - 1),
                    recurison( items,W, n - 1));
        }


        public void knapSack_BackTracking(item[] items, double W, long n)
        {
            totalVal= recurison(items,W, n);
        }


    }


   
}
