﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class FakturyZewnetrzneSzczegoly : Form
    {
        public FakturyZewnetrzneSzczegoly(SzwalniaEntities db, int ID)
        {
            InitializeComponent();

            Faktury_Zewnetrzne faktura = db.Faktury_Zewnetrzne.Where(wybrane => wybrane.ID_Faktura_zewnetrzna == ID).First();
            txtNrFaktury.Text = faktura.Nr_Faktury;
            txtNazwaFirmy.Text = faktura.Nazwa_Firmy;
           // txtKosztNetto.Text = faktura.Netto;
           // txtKosztBrutto.Text = faktura.Brutto;
          //  txtWartoscPodatku.Text = faktura.Podatek;
        }

            private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
