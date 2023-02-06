using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForceApp
{
    public class HybridBruteForce
    {
        public bool ObradaPodatakaHibrid(string unetaSifra, List<string> najcesceSifre)
        {
            foreach (var sifra in najcesceSifre)
            {
                if(unetaSifra == sifra)
                {
                    return true;
                }  
            }
            return false;
        }
    }
}
