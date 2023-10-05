using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Conversione_Binario_Decimale
{
    internal class Program // Dario Boccardo 4°E
    {
        static void Main(string[] args)
        {
            int[] dp = new int[4];
            Console.WriteLine($"Inserisci gli otteti dell'indirizzo IP");
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool[] bn = ConvertDpToBn(dp);
            Console.WriteLine($"Ecco l'indirizzo convertito in decimale: {ConvertDpToInt(dp)}");
            Console.WriteLine($"Ecco l'indirizzo binario convertito in decimale: {ConvertBnToInt(bn)}");
            Console.WriteLine($"Ecco l'indirizzo convertito in binario: {ConvertBnToDc(bn)}");

            Console.ReadLine();
        }

        static bool[] ConvertDpToBn(int[] dp)
        {
            bool[] bn = new bool[32];
            int j = bn.Length - 1; 

            for (int i = 0; i < dp.Length; i++)
            {
                int otteto = dp[i]; 
                for (int y = 0; y < 8; y++)
                {
                    bn[j] = otteto % 2 == 1;
                    otteto =+ otteto / 2;
                    j--;
                }
            }
            return bn;
        }

        static int ConvertDpToInt(int[] dp)
        {
            int decimale = 0;
            int j = 3;
            for (int i = 0; i < dp.Length; i++)
            {
                decimale += dp[i] * (int)Math.Pow(256, j--);
            }
            return decimale;
        }

        static int ConvertBnToInt(bool[] bn)
        {
            int bnInt = 0;
            int j = bn.Length - 1;

            for (int i = 0; i < bn.Length; i++)
            {
                if (bn[i])
                {
                    bnInt += (int)Math.Pow(2, j);
                }
                j--;
            }
            return bnInt;
        }
        static int ConvertBnToDc(bool[] bn)
        {
            int numDec = 0;

            for (int i = 0; i < bn.Length; i++)
            {
                if (bn[i] == true)
                {
                    numDec = numDec + (int)Math.Pow(10, 31 - i);
                }
            }
            return numDec;
        }
    }
}