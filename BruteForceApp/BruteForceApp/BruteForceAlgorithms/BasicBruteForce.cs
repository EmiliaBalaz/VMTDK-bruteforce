using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForceApp
{
    public class BasicBruteForce
    {
        public void ObradaPodataka(List<char> skup, string sifraZaRazbijanje)
        {
            List<int> trenutnaKombinacija = new List<int>(20) { 0 };

            while(true)
            {
                if(ProveriSifru(trenutnaKombinacija, sifraZaRazbijanje, skup) == true)
                {
                    return;
                }
                PromeniKombinaciju(skup, trenutnaKombinacija);
            }
        }

        private void PromeniKombinaciju(List<char> skup, List<int> trenutnaKombinacija)
        {
            int trenutniIndex = trenutnaKombinacija.Count - 1;

            if(trenutnaKombinacija[trenutniIndex] == skup.Count-1)
            {
                trenutnaKombinacija[trenutniIndex] = 0;

                if(trenutnaKombinacija.Count == 1)
                {
                    trenutnaKombinacija.Add(0);
                    return;
                }

                for(int i = trenutniIndex - 1; i >= 0; i--)
                {
                    if(trenutnaKombinacija[i] != skup.Count - 1)
                    {
                        trenutnaKombinacija[i]++;
                        break;
                    }
                    else
                    {
                        trenutnaKombinacija[i] = 0;
                        if(i == 0)
                        {
                            trenutnaKombinacija.Add(0);
                        }
                       
                    }
                }
            }
            else
            {
                trenutnaKombinacija[trenutniIndex]++;
            }
        }

        public bool ProveriSifru(List<int> trenutnaKombinacija, string sifraZaRazbijanje, List<char> skup)
        {
            string sifra = "";
            foreach (var element in trenutnaKombinacija)
            {
                sifra += skup[element];
            }

            return sifra == sifraZaRazbijanje;
        }
    }
}
