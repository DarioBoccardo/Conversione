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
            int[] dp = new int[4] {10, 10, 10, 1};

            /*Console.WriteLine("Inserisci i 4 otteti dell'indirizzo IP in decimale puntato");
            for(int i = 0; i < dp.Length; i++)
            {
                dp[i] = Convert.ToInt32(Console.ReadLine());
            }   */

            Console.WriteLine(ConvertDpToInt(dp)); // Converte la stringa inserita dall'utente in int 2°

            bool[] bn = ConvertDpBi(dp); // Converte l'intero in decimale puntato ad booleano in binario 1°

            Console.WriteLine(ConvertBiInt(bn)); // Converte l'array di bool in un array int 3°
            
            ConvertBiDp(bn); // Converte il binario booleano in un decimale 4°

            Console.ReadLine();
        }
        static int ConvertDpToInt(int[] dp) // Metodo per ottenere il valore della somma dei decimali puntati in decimale
        {
            double valInt = 0;
            int j = 3;
            for (int i = 0; i < dp.Length; i++)
            {
                valInt = valInt + dp[i] * Math.Pow(256, j);
                j--;
            }
            return (int)valInt;
        }
        static bool[] ConvertDpBi(int[] dp)
        {
            int resto;
            bool[] bn = new bool[32];
            string binarioStri = "";
            for(int i = 0; i < dp.Length; i++)
            {
                do
                {
                    resto = dp[i] % 2;
                    dp[i] = dp[i] / 2;
                    binarioStri += resto;
                } while (dp[i] >= 2);
                if(binarioStri.Length * i == 8 * i)
                {

                }
                else
                {
                    for(int j = 0; j < i * 8; j++)
                    {
                        binarioStri += '0';
                    }
                }
            }
            for (int i = 0; i < bn.Length; i++)
            {
                bn[i] = binarioStri[i] == '1';
            }
            return bn;
        }
        static int ConvertBiInt(bool[] bn) 
        {
            int[] Binario = new int[32];
            double valInt = 0;
            int j = 31;
            for(int i = 0; i < bn.Length; i++)
            {
                if (bn[i] == true)
                {
                    Binario[i] = 1;
                }
                else
                {
                    Binario[i] = 0;
                }
            }

            for(int i = 0; i < Binario.Length; i++)
            {
                valInt = valInt + Binario[i] * Math.Pow(2, j);
                j--;
            }
            return (int)valInt; 
        }
        static int[] ConvertBiDp(bool[] bn)
        {
            int[] dp = new int[4];
            double[] valInt = new double[4];
            int j = 31;
            int[] binario = new int[32];
            for (int i = 0; i < bn.Length; i++)
            {
                if (bn[i] == true)
                {
                    binario[i] = 1;
                }
                else
                {
                    binario[i] = 0;
                }
            }
            j = 4;
            for(int y = 0; y < 4; y++)
            {
                for (int i = 0; i < binario.Length/4; i++)
                {
                    valInt[y] = valInt[y] + binario[i] * Math.Pow(2, j);
                    j--;
                }
            }
            for(int i = 0; i < dp.Length; i++)
            {
                dp[i] = (int)(valInt[i] * Math.Pow(2, j));
                j--;
            }
            return dp;
        }
    }
}