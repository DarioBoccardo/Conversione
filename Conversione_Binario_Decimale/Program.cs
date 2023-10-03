using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Conversione_Binario_Decimale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dp = new int[4];

            Console.WriteLine("Inserisci l'indirizzo IP in decimale puntato");
            for(int i = 0; i < dp.Length; i++)
            {
                dp[i] = Convert.ToInt32(Console.ReadLine());
            }     
            bool[] bn = ConvertDpBi(dp); // Converte l'intero in decimale puntato ad booleano in binario
            ConvertDpToInt(dp); // Converte la stringa inserita dall'utente in int
            ConvertBiInt(bn); // Converte l'array di bool in un array int
            //ConvertBiDp(); // Converte il binario booleano in un decimale

            Console.ReadLine();
        }
        static bool[] ConvertDpBi(int[] dp)
        {
            int resto = 0, cont = 31;
            bool[] bn = new bool[32];
            for(int i = 0; i < dp.Length; i++)
            {
                do
                {
                    resto = dp[i] % 2;
                    dp[i] = dp[i] / 2;
                    bn[cont] = resto == 0;
                    cont--;
                } while (dp[i] < 2);
            }
            return bn;
        }
        static int ConvertDpToInt(int[] dp) // Metodo per ottenere il valore della somma dei decimali puntati in decimale
        {
            double valInt = 0;
            int j = 3;
            for(int i = 0; i < dp.Length; i++)
            {
                valInt = valInt + dp[i]* Math.Pow(256, j);
                j--;
            }
            return (int)valInt;
        }
        static int ConvertBiInt(bool[] bn) 
        {

            return 0; 
        }
        /*static int[] ConvertBiDp()
        {
            
        }*/
    }
}
