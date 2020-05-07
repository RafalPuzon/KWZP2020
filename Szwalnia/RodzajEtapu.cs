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
    public partial class RodzajEtapu : Form
    {
        public SzwalniaEntities db;
        public RodzajEtapu(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
            dgvRodzajEtapu.DataSource = db.Rodzaj_Etapu.ToList();
            dgvRodzajEtapu.Columns[2].Visible = false;
            dgvRodzajEtapu.Columns[3].Visible = false;

        }
    }
}
