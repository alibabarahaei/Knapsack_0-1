using System;



// is developing ....



namespace Knapsack_Project
{
    public class BranchandBound
    {
        static int[] v = new int[] { 10, 40, 30, 50 };
        static int[] wt = new int[] { 5, 4, 6, 3 };
        static int W = 10;
        static int n = v.Length;

                static int maxProfit;
                static int[,] m = new int[n + 1, W + 1];
        public static void InitializeMatrix()
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= W; j++)
                {
                    m[i, j] = -1;
                }
            }
            maxProfit = knapSack(0, W);
            Console.WriteLine("Maximum Profit: " + maxProfit);
            Console.ReadKey();
        }
        static int knapSack(int i, int w)
        {
            if (i == n || w == 0)
            {
                return 0;
            }
            if (m[i, w] != -1)

            {
                return m[i, w];
            }
            else
            {
                return 10;
            }
         
        }
    }
}
