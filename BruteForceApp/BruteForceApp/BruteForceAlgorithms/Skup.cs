using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForceApp
{
    public class Skup
    {
     
        public List<char> GetMalaSlova()
        {
            List<char> malaSlova = new List<char>(26);

            for (char i = 'a'; i <= 'z'; i++)
            {
                malaSlova.Add(i);
            }

            return malaSlova;
        }

        public List<char> GetVelikaSlova()
        {
            List<char> velikaSlova = new List<char>();

            for(char i = 'A'; i <= 'Z'; i++)
            {
                velikaSlova.Add(i);
            }

            return velikaSlova;
        }

        public List<char> GetBrojevi()
        {
            List<char> brojevi = new List<char>();

            for(int i = 0; i <= 9; i++)
            {
                brojevi.Add((i).ToString()[0]);
            }

            return brojevi;
        }

        public List<char> GetSpecChar()
        {
            return new List<char>()
            {
                '!', '@', '#', '$', '%', '&', '*', '(', ')', '_', '+', '-', '=', ';', ':', '"', '<', '>', '.', '?'
            };
            
        }
    }
}
