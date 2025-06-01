using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReservationSystem; // Numele proiectului tău principal
using System;
using System.Collections.Generic;

namespace RezervariTests
{
    [TestClass]
    public class RezervareTests
    {
        [TestMethod]
        public void Test_AdaugareRezervare_CresteLista()
        {
         
            List<Rezervare> lista = new List<Rezervare>();
            var rezervareNoua = new Rezervare
            {
                NumeClient = "Ion Popescu",
                DataRezervare = new DateTime(2025, 6, 1, 19, 0, 0),
                NrPersoane = 4
            };
            lista.Add(rezervareNoua);
            Assert.AreEqual(1, lista.Count);
            Assert.AreEqual("Ion Popescu", lista[0].NumeClient);
        }
    }
}
