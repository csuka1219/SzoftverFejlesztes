
namespace Könyvkölcsönzés
{
    partial class KölcsönzőForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KölcsönzőForm));
            this.lbl_konyv = new System.Windows.Forms.Label();
            this.lbl_berlo = new System.Windows.Forms.Label();
            this.lbl_peldany = new System.Windows.Forms.Label();
            this.cb_konyv = new System.Windows.Forms.ComboBox();
            this.cb_berlok = new System.Windows.Forms.ComboBox();
            this.Nud_peldany = new System.Windows.Forms.NumericUpDown();
            this.lbl_adatok = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbx_lista = new System.Windows.Forms.ListBox();
            this.btn_addlist = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_peldany)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_konyv
            // 
            this.lbl_konyv.AutoSize = true;
            this.lbl_konyv.Location = new System.Drawing.Point(24, 38);
            this.lbl_konyv.Name = "lbl_konyv";
            this.lbl_konyv.Size = new System.Drawing.Size(47, 17);
            this.lbl_konyv.TabIndex = 0;
            this.lbl_konyv.Text = "Könyv";
            // 
            // lbl_berlo
            // 
            this.lbl_berlo.AutoSize = true;
            this.lbl_berlo.Location = new System.Drawing.Point(24, 94);
            this.lbl_berlo.Name = "lbl_berlo";
            this.lbl_berlo.Size = new System.Drawing.Size(47, 17);
            this.lbl_berlo.TabIndex = 1;
            this.lbl_berlo.Text = "bérlők";
            // 
            // lbl_peldany
            // 
            this.lbl_peldany.AutoSize = true;
            this.lbl_peldany.Location = new System.Drawing.Point(24, 152);
            this.lbl_peldany.Name = "lbl_peldany";
            this.lbl_peldany.Size = new System.Drawing.Size(58, 17);
            this.lbl_peldany.TabIndex = 2;
            this.lbl_peldany.Text = "példány";
            // 
            // cb_konyv
            // 
            this.cb_konyv.FormattingEnabled = true;
            this.cb_konyv.Location = new System.Drawing.Point(118, 38);
            this.cb_konyv.Name = "cb_konyv";
            this.cb_konyv.Size = new System.Drawing.Size(219, 24);
            this.cb_konyv.TabIndex = 3;
            this.cb_konyv.Enter += new System.EventHandler(this.cb_konyv_Enter);
            // 
            // cb_berlok
            // 
            this.cb_berlok.FormattingEnabled = true;
            this.cb_berlok.Location = new System.Drawing.Point(118, 91);
            this.cb_berlok.Name = "cb_berlok";
            this.cb_berlok.Size = new System.Drawing.Size(169, 24);
            this.cb_berlok.TabIndex = 4;
            this.cb_berlok.Enter += new System.EventHandler(this.cb_berlok_Enter);
            // 
            // Nud_peldany
            // 
            this.Nud_peldany.Location = new System.Drawing.Point(118, 152);
            this.Nud_peldany.Name = "Nud_peldany";
            this.Nud_peldany.Size = new System.Drawing.Size(120, 22);
            this.Nud_peldany.TabIndex = 5;
            // 
            // lbl_adatok
            // 
            this.lbl_adatok.AutoSize = true;
            this.lbl_adatok.Location = new System.Drawing.Point(82, 20);
            this.lbl_adatok.Name = "lbl_adatok";
            this.lbl_adatok.Size = new System.Drawing.Size(130, 17);
            this.lbl_adatok.TabIndex = 6;
            this.lbl_adatok.Text = "Kölcsönzési adatok";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_konyv);
            this.panel1.Controls.Add(this.Nud_peldany);
            this.panel1.Controls.Add(this.lbl_berlo);
            this.panel1.Controls.Add(this.cb_berlok);
            this.panel1.Controls.Add(this.lbl_peldany);
            this.panel1.Controls.Add(this.cb_konyv);
            this.panel1.Location = new System.Drawing.Point(58, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 212);
            this.panel1.TabIndex = 7;
            // 
            // lbx_lista
            // 
            this.lbx_lista.FormattingEnabled = true;
            this.lbx_lista.ItemHeight = 16;
            this.lbx_lista.Location = new System.Drawing.Point(499, 30);
            this.lbx_lista.Name = "lbx_lista";
            this.lbx_lista.Size = new System.Drawing.Size(488, 340);
            this.lbx_lista.TabIndex = 8;
            // 
            // btn_addlist
            // 
            this.btn_addlist.Location = new System.Drawing.Point(99, 270);
            this.btn_addlist.Name = "btn_addlist";
            this.btn_addlist.Size = new System.Drawing.Size(265, 36);
            this.btn_addlist.TabIndex = 9;
            this.btn_addlist.Text = "tárolja listában";
            this.btn_addlist.UseVisualStyleBackColor = true;
            this.btn_addlist.Click += new System.EventHandler(this.btn_addlist_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(301, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Mentés az adatbázisba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KölcsönzőForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_addlist);
            this.Controls.Add(this.lbx_lista);
            this.Controls.Add(this.lbl_adatok);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KölcsönzőForm";
            this.Text = "KölcsönzőForm";
            ((System.ComponentModel.ISupportInitialize)(this.Nud_peldany)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_konyv;
        private System.Windows.Forms.Label lbl_berlo;
        private System.Windows.Forms.Label lbl_peldany;
        private System.Windows.Forms.ComboBox cb_konyv;
        private System.Windows.Forms.ComboBox cb_berlok;
        private System.Windows.Forms.NumericUpDown Nud_peldany;
        private System.Windows.Forms.Label lbl_adatok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbx_lista;
        private System.Windows.Forms.Button btn_addlist;
        private System.Windows.Forms.Button button1;
    }
}