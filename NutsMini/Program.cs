using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutsMini
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// teller antall siffer i et tall
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int Len(int num)
        {
            int digits = 1;
            while ((num /= 10) != 0)
                digits++;
            return digits;
        }

        /// <summary>
        /// teller antall siffer i et tall - muhannads versjon
        /// hva må utbedres på denne tilsynelatende perfekte versjonen?
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int len(int num)
        {
            int len = 0;
            for (int i = 1; i < num; i *= 10)
            {
                len++;
            }
            return len;
        }
    }
}
