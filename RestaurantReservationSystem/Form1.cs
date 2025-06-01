using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
namespace RestaurantReservationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly string caleFisier = "rezervari.json";
        private List<Rezervare> rezervari = new List<Rezervare>();
        private void btnAdaugaRezervare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeClient.Text))
            {
                MessageBox.Show("Introduceti numele clientului.");
                return;
            }

            Rezervare rez = new Rezervare()
            {
                NumeClient = txtNumeClient.Text,
                DataRezervare = dtpDataRezervare.Value,
                NrPersoane = (int)nudNrPersoane.Value
            };

            rezervari.Add(rez);
            ActualizeazaLista();
            GolesteCampuri();
            SalveazaRezervari();
        }

        private void btnStergeRezervare_Click(object sender, EventArgs e)
        {
            if (lstRezervari.SelectedIndex >= 0)
            {
                rezervari.RemoveAt(lstRezervari.SelectedIndex);
                ActualizeazaLista();
                SalveazaRezervari();
            }
            else
            {
                MessageBox.Show("Selectati o rezervare");
            }
        }
        private void ActualizeazaLista()
        {
            lstRezervari.Items.Clear();
            foreach (var r in rezervari)
            {
                lstRezervari.Items.Add(r);
            }
        }

        private void GolesteCampuri()
        {
            txtNumeClient.Clear();
            dtpDataRezervare.Value = DateTime.Now;
            nudNrPersoane.Value = 1;
        }
        private void SalveazaRezervari()
        {
            var json = JsonSerializer.Serialize(rezervari);
            File.WriteAllText(caleFisier, json);
        }

        private void IncarcaRezervari()
        {
            if (File.Exists(caleFisier))
            {
                var json = File.ReadAllText(caleFisier);
                rezervari = JsonSerializer.Deserialize<List<Rezervare>>(json);
                ActualizeazaLista();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IncarcaRezervari();
        }

        private void btnValidare_Click(object sender, EventArgs e)
        {
            if (lstRezervari.SelectedIndex >= 0)
            {
                rezervari.RemoveAt(lstRezervari.SelectedIndex);
                ActualizeazaLista();
                SalveazaRezervari();
                MessageBox.Show("Rezervarea a fost onorata");
            }
            else
            {
                MessageBox.Show("Selectati o rezervare");
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string cautaText = txtSearch.Text.ToLower();

            for (int i = 0; i < lstRezervari.Items.Count; i++)
            {
                string item = lstRezervari.Items[i].ToString().ToLower();

                // Selectăm prima potrivire
                if (item.Contains(cautaText))
                {
                    lstRezervari.SetSelected(i, true);
                    return;
                }
            }

            MessageBox.Show("Nicio rezervare găsita!", "Căutare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
