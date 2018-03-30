using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class Fibonacci
    {
        private int n;

        public Fibonacci(int n)
        {
            this.n = n;
        }

        internal int GenerateFib()
        {
            int[] FibStore = new int[n];
            FibStore[0] = 1;
            FibStore[1] = 1;
            for(int i=2;i<n;i++)
            {
                FibStore[i] = FibStore[i - 1] + FibStore[i - 2];
            }
            return FibStore[n-1];
        }
    }
}
