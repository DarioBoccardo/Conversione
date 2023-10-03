using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversione_Binario_Decimale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] indirizzoIp = new int[4];
            bool[] bn = new bool[32];

            Console.WriteLine("Inserisci l'indirizzo IP in decimale puntato");
            for(int i = 0; i < indirizzoIp.Length; i++)
            {
                indirizzoIp[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        /*static bool[] ConvertDeBi()
        {
            return;
        }*/
        /*static int ConvertDpToInt() 
        {
            return 0;
        }
        static int ConvertBiInt() 
        {
            return 0; 
        }*/
        /*static int[] ConvertBiDe()
        {
            
        }*/
    }
}
