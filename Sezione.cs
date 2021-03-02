using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_2
{
    class Sezione
    {
       internal List<Pagina> pagine { get; private set; } = new List<Pagina>();
        
        public void StampaPagine(int n = 20)
        {
            Pagina p = new Pagina();
            for (int i = 10; i <= n; i++)
            {
                pagine.Add(p);
                Console.WriteLine($"pagina numero: {i} testo: {p.StampaRandom()}");
            }

        }
    }
}
