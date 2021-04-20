using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Könyvkölcsönzés
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_kolcson.BackColor = Color.FromArgb(128, 64, 0);
            btn_kolcson.ForeColor = Color.FromArgb(255, 255, 128);
            btn_vissza.BackColor = Color.FromArgb(128, 64, 0);
            btn_vissza.ForeColor = Color.FromArgb(255, 255, 128);
            btn_keses.BackColor = Color.FromArgb(128, 64, 0);
            btn_keses.ForeColor = Color.FromArgb(255, 255, 128);
        }

        private void btn_kolcson_Click(object sender, EventArgs e)
        {
            KölcsönzőForm frm = new KölcsönzőForm();
            frm.Show();
        }

        private void btn_vissza_Click(object sender, EventArgs e)
        {
            VisszavételForm frm = new VisszavételForm();
            frm.Show();
        }

        private void btn_keses_Click(object sender, EventArgs e)
        {
            kesesek frm = new kesesek();
            frm.Show();
        }
    }
}
