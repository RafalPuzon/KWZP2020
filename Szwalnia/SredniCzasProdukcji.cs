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
    public partial class SredniCzasProdukcji : Form
    {
        public SzwalniaEntities db;
        public SredniCzasProdukcji(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
            dgvSredniCzasProdukcji.DataSource = db.vSredniCzasWgElementu.ToList();
            dgvSredniCzasProdukcji.Columns[0].Visible = false;
        }
    }
}
