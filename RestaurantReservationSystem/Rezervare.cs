using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace RestaurantReservationSystem
{
    public class Rezervare
    {
        public string NumeClient { get; set; }
        public DateTime DataRezervare { get; set; }
        public int NrPersoane { get; set; }

        public override string ToString()
        {
            return $"{NumeClient} - {DataRezervare.ToString("g")} - {NrPersoane} persoane";
        }
    }
}