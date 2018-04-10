using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.Problems
{
    class CoinCollecting
    {
        private int[,] matrix;
        private int rows;
        private int cols;

        public CoinCollecting(int[,] matrix, int rows, int cols)
        {
            this.matrix = matrix;
            this.rows = rows;
            this.cols = cols;
        }

        internal int MaximumCoinsCollected()
        {
            int[,] CoinMatrix = new int[rows, cols];
            
            CoinMatrix[0, 0] = matrix[0, 0];
            for(int i=1;i<cols;i++)
            {
                CoinMatrix[0, i] = CoinMatrix[0, i-1] + matrix[0, i];
            }
            for(int i=1;i<rows;i++)
            {
                CoinMatrix[i, 0] = CoinMatrix[i - 1, 0] + matrix[i, 0];
                for(int j=1;j<cols;j++)
                {
                    if(CoinMatrix[i-1,j]>CoinMatrix[i,j-1])
                    {
                        CoinMatrix[i, j] = CoinMatrix[i - 1, j] + matrix[i, j];
                    }
                    else
                    {
                        CoinMatrix[i, j] = CoinMatrix[i, j - 1] + matrix[i, j];
                    }
                }
            }

            return CoinMatrix[rows - 1, cols - 1];
        }
    }
}

