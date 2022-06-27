using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms.Recursions
{
    class Recursion
    {
        public void headRecursion(int n)
        {
            if (n > 0)
            {
                headRecursion(n - 1);
                int k = n * n;
                Console.WriteLine(k);
            }
        }

        public void tailRecursion(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                tailRecursion(n-1);
            }
        }

        public void treeRecursion(int n)
        {
            if (n > 0)
            {
                treeRecursion(n-1);
                int k = n * n;
                Console.WriteLine(k);
                treeRecursion(n-1);
            }
        }
    }
}
