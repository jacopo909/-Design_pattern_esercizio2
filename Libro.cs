using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_2
{
    public class Libro
    {
       internal List<Sezione> sezioni { get; private set; } = new List<Sezione>();

        public void StampaLibro()
        {
            Sezione s = new Sezione();
            s.StampaPagine();
        }
    }
}
