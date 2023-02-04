using Knapsack_Project.DTO;
using System;
using System.Collections.Generic;

namespace Knapsack_Project
{
    public class Dynamic_Algorithm
    {


        public double totalVal = 0;
        public List<long> company_list = new List<long>();




        public void R_Companies(long n, long total_W, long[,] k, item[] items)
        {

            long current_value = 0;
            long preview_value = 0;
            for (long j = n; j > 0; j--)                            //Time Complexity  O(n)
            {
                current_value = k[j, total_W];
                preview_value = k[j - 1, total_W];
                if (current_value > preview_value)
                {
                    company_list.Add((items[j - 1].id));
                    total_W = total_W - items[j - 1].weight;
                }
            }

        }



        public void knapSack_Dynamic(item[] items, long W)
        {
            long n = items.Length;

            long[,] K = new long[n + 1, W + 1];

            for (long i = 0; i <= n; i++)                            //Time Complexity  O(N*W)
            {
                for (long w = 0; w <= W; w++)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;

                    else if (items[i - 1].weight <= w)
                        K[i, w] = Math.Max(items[i - 1].value + K[i - 1, w - items[i - 1].weight], K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            totalVal = K[n, W];
            R_Companies(n, W, K, items);
        }


        public void knapSack_Dynamic_optimized(item[] items, long W)
        {
            long n = items.Length;

            double[] k = new double[W + 1];

            for (long i = 1; i < n + 1; i++)                           //Time Complexity  O(N*W)  
            {
                for (long w = W; w >= 0; w--)
                {
                    if (items[i - 1].weight <= w)
                    {
                        k[w] = Math.Max(k[w], k[w - items[i - 1].weight]+ items[i - 1].value);
                    }
                }
            }
            totalVal = k[W];
        }

        private long max(long a, long b) { return (a > b) ? a : b; }
    }
}

