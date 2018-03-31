using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.Problems
{

    public class CoinRow
    {
        private int[] coinValues;
        private int N;


        public CoinRow(int n, int[] coinValues) 
        {
            this.N = n;
            this.coinValues = coinValues;
        }

        internal int CalculateMaxValue()
        {
            int[] Max_Value=new int[N + 1];
            Max_Value[0] = 0;
            Max_Value[1] = coinValues[0];
            for(int i=2;i<=N;i++)
            {
                Max_Value[i] = Math.Max(coinValues[i-1]+Max_Value[i-2],Max_Value[i-1]);
            }
            return Max_Value[N];
        }
    }
}