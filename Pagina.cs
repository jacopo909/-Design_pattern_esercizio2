using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_2
{
    class Pagina
    {
        Sezione s = new Sezione();
        Random r = new Random();
        public string StampaRandom()
        {
            string[] parole = new string[] { "parona n: 1 ", "parona n: 2", "parola n: 3", "parola n: 4", "parola n: 5", "parola n: 6", "parola n: 7", "parola n: 8", "parola n: 9" };
            return (parole[r.Next(1, 9)]);
        }
    }
}
