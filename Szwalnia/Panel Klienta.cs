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
    public partial class Panel_Klienta : Form
    {
        public SzwalniaEntities db;
        public Panel_Klienta (SzwalniaEntities szwalnia)
        {
            InitializeComponent();
            db = szwalnia;
        }
       private void btnKlient_Click(object sender, EventArgs e)
        {
            WyborKlienta wyborKlienta = new WyborKlienta(db);
            wyborKlienta.Show();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNowyKlient_Click(object sender, EventArgs e)
        {
            Nowy_Klient nowyKlient = new Nowy_Klient(db);
            nowyKlient.Show();
        }
    }
}
