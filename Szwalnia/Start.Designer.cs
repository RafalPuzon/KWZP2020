﻿namespace Szwalnia
{
    partial class Start
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.btnMagazyn = new System.Windows.Forms.Button();
            this.btnPrzygotowanieProdukcji = new System.Windows.Forms.Button();
            this.btnProdukcja = new System.Windows.Forms.Button();
            this.btnZarzadzanie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMagazyn
            // 
            this.btnMagazyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMagazyn.Location = new System.Drawing.Point(39, 197);
            this.btnMagazyn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMagazyn.Name = "btnMagazyn";
            this.btnMagazyn.Size = new System.Drawing.Size(212, 125);
            this.btnMagazyn.TabIndex = 0;
            this.btnMagazyn.Text = "Magazyn";
            this.btnMagazyn.UseVisualStyleBackColor = true;
            this.btnMagazyn.Click += new System.EventHandler(this.btnMagazyn_Click);
            // 
            // btnPrzygotowanieProdukcji
            // 
            this.btnPrzygotowanieProdukcji.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzygotowanieProdukcji.Location = new System.Drawing.Point(273, 40);
            this.btnPrzygotowanieProdukcji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrzygotowanieProdukcji.Name = "btnPrzygotowanieProdukcji";
            this.btnPrzygotowanieProdukcji.Size = new System.Drawing.Size(212, 125);
            this.btnPrzygotowanieProdukcji.TabIndex = 3;
            this.btnPrzygotowanieProdukcji.Text = "Przygotowanie Produkcji";
            this.btnPrzygotowanieProdukcji.UseVisualStyleBackColor = true;
            this.btnPrzygotowanieProdukcji.Click += new System.EventHandler(this.btnPrzygotowanieProdukcji_Click);
            // 
            // btnProdukcja
            // 
            this.btnProdukcja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProdukcja.Location = new System.Drawing.Point(273, 197);
            this.btnProdukcja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProdukcja.Name = "btnProdukcja";
            this.btnProdukcja.Size = new System.Drawing.Size(211, 125);
            this.btnProdukcja.TabIndex = 4;
            this.btnProdukcja.Text = "Produkcja";
            this.btnProdukcja.UseVisualStyleBackColor = true;
            this.btnProdukcja.Click += new System.EventHandler(this.btnProdukcja_Click);
            // 
            // btnZarzadzanie
            // 
            this.btnZarzadzanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZarzadzanie.Location = new System.Drawing.Point(39, 40);
            this.btnZarzadzanie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZarzadzanie.Name = "btnZarzadzanie";
            this.btnZarzadzanie.Size = new System.Drawing.Size(212, 125);
            this.btnZarzadzanie.TabIndex = 5;
            this.btnZarzadzanie.Text = "Zarządzanie";
            this.btnZarzadzanie.UseVisualStyleBackColor = true;
            this.btnZarzadzanie.Click += new System.EventHandler(this.btnZarzadzanie_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 342);
            this.Controls.Add(this.btnZarzadzanie);
            this.Controls.Add(this.btnProdukcja);
            this.Controls.Add(this.btnPrzygotowanieProdukcji);
            this.Controls.Add(this.btnMagazyn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Start";
            this.Text = "Szwalnia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Start_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMagazyn;
        private System.Windows.Forms.Button btnPrzygotowanieProdukcji;
        private System.Windows.Forms.Button btnProdukcja;
        private System.Windows.Forms.Button btnZarzadzanie;
    }
}

