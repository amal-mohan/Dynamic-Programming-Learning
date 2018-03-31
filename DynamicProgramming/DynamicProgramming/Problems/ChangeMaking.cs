using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.Problems
{
    class ChangeMaking
    {
        private int n;
        private int[] coinValue;
        private int denomination;

        public ChangeMaking(int n, int[] coinValue, int denomination)
        {
            this.n = n;
            this.coinValue = coinValue;
            this.denomination = denomination;
        }

        internal int[] CalculateDenominations()
        {
            int j;
            int[] result = new int[denomination+1];
            int[] cost = new int[denomination+1];
            int temp = 0,temp1;
            Array.Sort(coinValue);
            result[0] = 0;
            cost[0] = 0;
            for (int i=1;i<=denomination;i++)
            {
                j = 0;
                temp = coinValue[n-1]+1;
                temp1 = 0;
                while (j<n&&i>=coinValue[j])
                {
                    if (cost[i - coinValue[j]] < temp)
                    {
                        temp = cost[i - coinValue[j]];
                        temp1 = coinValue[j];  
                    }
                    j++;
                }
                cost[i] = temp + 1;
                result[i] = temp1;
            }
            List<int> DenominationMatrixList = new List<int>();
            j = denomination;
            int k = denomination;
            while (j>0)
            {
                DenominationMatrixList.Add(result[j]);
                j -= result[j];
            }
            int[] DenominationMatrix = DenominationMatrixList.ToArray();
            return DenominationMatrix;
        }
    }
}
