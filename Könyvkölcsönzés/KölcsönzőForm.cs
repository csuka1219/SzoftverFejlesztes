using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Könyvkölcsönzés
{
    public partial class KölcsönzőForm : Form
    {
        public KölcsönzőForm()
        {
            InitializeComponent();
            btn_addlist.BackColor = Color.FromArgb(128, 64, 0);
            btn_addlist.ForeColor = Color.FromArgb(255, 255, 128);
            button1.BackColor = Color.FromArgb(128, 64, 0);
            button1.ForeColor = Color.FromArgb(255, 255, 128);
        }
        string berlokstr;
        string konyvstr;
        private string berlokID;
        private string KonyvekID;
        private List<string> BerloIDList = new List<string>();
        private List<string> KonyvIDList = new List<string>();
        List<int> peldany = new List<int>();

        private void btn_addlist_Click(object sender, EventArgs e)
        {
            Kapcsolat connect = new Kapcsolat();
            connect.Kapcsolodas();
            if (connect.conn.State == ConnectionState.Closed)
            {
                connect.conn.Open();
            }
            lbx_lista.Items.Add(cb_berlok.SelectedItem + " :" + cb_konyv.SelectedItem + " (" + Nud_peldany.Value + ")");

            konyvstr = cb_konyv.SelectedItem.ToString();
            BerloID(connect.conn, berlokstr);
            KonyvID(connect.conn, konyvstr);
            BerloIDList.Add(berlokID);
            KonyvIDList.Add(KonyvekID);
            peldany.Add((int)Nud_peldany.Value);
            button1.Enabled = true;
        }

        private void cb_konyv_Enter(object sender, EventArgs e)
        {
            Kapcsolat connect = new Kapcsolat();
            connect.Kapcsolodas();
            if (connect.conn.State == ConnectionState.Closed)
            {
                connect.conn.Open();
            }
            feltolt(connect.conn);
            connect.conn.Close();
        }
        private void feltolt(MySqlConnection conn)
        {
            using (MySqlCommand query = new MySqlCommand("SELECT CONCAT (`Szerzo`,': ', `Cím`) FROM `konyvek`", conn))
            {
                try
                {
                    MySqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        cb_konyv.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        private void KonyvID(MySqlConnection conn, string konyvsrt)
        {
            using (MySqlCommand query = new MySqlCommand("SELECT `Kod` FROM `konyvek` WHERE CONCAT (`Szerzo`,': ', `Cím`) = @konyvstr", conn))
            {
                query.Parameters.Add("@konyvstr", MySqlDbType.VarChar).Value = konyvstr;
                try
                {
                    MySqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        KonyvekID = reader.GetString(0);
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                }
            }
        }

        private void cb_berlok_Enter(object sender, EventArgs e)
        {
            Kapcsolat connect = new Kapcsolat();
            connect.Kapcsolodas();
            if (connect.conn.State == ConnectionState.Closed)
            {
                connect.conn.Open();
            }
            berlok(connect.conn);
            connect.conn.Close();
        }
        private void BerloID(MySqlConnection conn,string berlokstr)
        {
            berlokstr = cb_berlok.SelectedItem.ToString();
            using (MySqlCommand query=new MySqlCommand("SELECT `ID` FROM `kolcsonzo` WHERE `nev` = @berlokstr",conn))
            {
                query.Parameters.Add("@berlokstr", MySqlDbType.VarChar).Value = berlokstr;
                try
                {
                     MySqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        berlokID = reader.GetString(0);
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                }
            }
        }
        private void berlok(MySqlConnection conn)
        {
            using (MySqlCommand query = new MySqlCommand("SELECT `nev` FROM `kolcsonzo`", conn))
            {
                try
                {
                    MySqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        cb_berlok.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Kapcsolat connect = new Kapcsolat();
            connect.Kapcsolodas();
            if (connect.conn.State == ConnectionState.Closed)
            {
                connect.conn.Open();
            }
            Insert(connect.conn);
            connect.conn.Close();

        }
        private void Insert(MySqlConnection conn)
        {
            bool succes = false;
            for (int i = 0; i < KonyvIDList.Count; i++)
            {
                using (MySqlCommand insert = new MySqlCommand("INSERT INTO `kolcsonzes`(`konyvID`, `kolcsonzoID`, `kivetelDatum`, `peldany`) VALUES (@konyv,@berlo,NOW(),@peldany)", conn))
                {
                    insert.Parameters.Add("@konyv", MySqlDbType.VarChar).Value = KonyvIDList[i];
                    insert.Parameters.Add("@berlo", MySqlDbType.Int32).Value = BerloIDList[i];
                    insert.Parameters.Add("@peldany", MySqlDbType.Int32).Value = peldany[i];

                    try
                    {
                        insert.ExecuteNonQuery();
                        succes = true;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            if (succes)
            {
                MessageBox.Show("Sikeres feltöltés!");
            }
        }
    }
}
