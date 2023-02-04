using System;
using System.Collections;
using System.Collections.Generic;
using Knapsack_Project.DTO;
using Knapsack_Project.Tools;


namespace Knapsack_Project
{
    public class Greedy_Algorithm
    {

        public double totalVal = 0d;
        public List<long> company_list=new List<long>();
        public double KnapSack_Greedy(item[] items, long w)
        {

        
            cprCompare cmc = new cprCompare();
            Array.Sort(items, cmc);                   //Time Complexity O(nlogn)


            long currentW = 0;
            foreach (item i in items)                 //Time Complexity O(n)
            {
                long remaining = w - currentW;
                if (i.weight <= remaining)
                {
                    totalVal +=i.value;
                    currentW += i.weight;
                    company_list.Add(i.id);
                }
                if (remaining == 0)
                    break;
            }
            return totalVal;
        }
    }



   










}
