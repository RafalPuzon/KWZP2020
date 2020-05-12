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
    public partial class ElementyForm : Form
    {
        public SzwalniaEntities db;
        public ElementyForm(SzwalniaEntities szwalnia)
        {
            InitializeComponent();
            db = szwalnia;
        }

        private void btnWybor_Click(object sender, EventArgs e)
        {
            WyborElementu wybor = new WyborElementu(db);
            wybor.Show();
            this.Hide();
        }

        private void btnElement_Click(object sender, EventArgs e)
        {
            DodawanieTypu typ = new DodawanieTypu();
            typ.Show();
            this.Hide();
        }

        private void btnTyp_Click(object sender, EventArgs e)
        {
            WyborElementu wybor = new WyborElementu(db);
            wybor.Show();
            this.Hide();
        }

        private void btnCecha_Click(object sender, EventArgs e)
        {
            WyborElementu wybor = new WyborElementu(db);
            wybor.Show();
            this.Hide();
        }

        private void btnJednostka_Click(object sender, EventArgs e)
        {
            WyborElementu wybor = new WyborElementu(db);
            wybor.Show();
            this.Hide();
        }

        private void btnCechyElementow_Click(object sender, EventArgs e)
        {
            WyborElementu wybor = new WyborElementu(db);
            wybor.Show();
            this.Hide();
        }
    }
}