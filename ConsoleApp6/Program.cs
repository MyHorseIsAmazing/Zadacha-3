using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp220
{
    class Program
    {
        static bool plndrm(string S, int ij)
        {
            if (ij < 2)
            {
                return true;
            }
            else
            {
                int M = 0;
                if (ij % 2 == 1)
                {
                    M = (ij + 1) / 2;
                }
                else
                {
                    M = ij / 2;
                }
                for (int i = 1; i <= M; i++)
                {
                    if (S.Substring(i - 1, 1) != S.Substring(ij - i, 1))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi duma: ");
            string pln = Console.ReadLine();
            int lnght = pln.Length;
            Console.WriteLine(plndrm(pln, lnght));
            Console.ReadLine();
        }
    }
}
