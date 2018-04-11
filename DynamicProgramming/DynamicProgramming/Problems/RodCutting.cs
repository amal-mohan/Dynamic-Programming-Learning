using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.Problems
{
    class RodCutting
    {
        private int n;
        private int[] rodPrice;

        public RodCutting(int n, int[] rodPrice)
        {
            this.n = n;
            this.rodPrice = rodPrice;
        }

        internal Tuple<int[],int> CalculateOptimalCuts()
        {
            int[] OptValues = new int[n+1];
            int[] Cuts = new int[n+1];
            Cuts[0] = 0;
            OptValues[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                int temp1 = -1;
                int temp2 = 0;
                for (int j = 0; j < i; j++)
                {
                    if (rodPrice[j]+Cuts[i-j-1]>temp1)
                    {
                        temp1 = rodPrice[j] + Cuts[i-j-1];
                        temp2 = j;
                    }
                }
                Cuts[i] = temp1;
                OptValues[i] = temp2+1;
            }
            List<int> OptValuesList = new List<int>();
            for(int i=n;i>0;)
            {
                OptValuesList.Add(OptValues[i]);
                i -= OptValues[i];
            }

            int[] OptVals = OptValuesList.ToArray();
            Tuple<int[], int> Rod = Tuple.Create(OptVals,Cuts[n]);
            return Rod;
        }
    }
}
