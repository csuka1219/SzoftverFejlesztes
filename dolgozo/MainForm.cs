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

namespace április_20
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CB_dolgozok_Enter(object sender, EventArgs e)
        {
            Kapcsolat connect = new Kapcsolat();
            connect.Kapcsolodas();
            if (connect.conn.State == ConnectionState.Closed)
            {
                connect.conn.Open();
            }
            Combo_Feltolt(connect.conn);
            connect.conn.Close();
        }
        private void Combo_Feltolt(MySqlConnection conn)
        {
            using(MySqlCommand query=new MySqlCommand("SELECT `nev` FROM `torzs`",conn))
            {
                try
                {
                    MySqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        if (!CB_dolgozok.Items.Contains(reader.GetString(0)))
                        {
                            CB_dolgozok.Items.Add(reader.GetString(0));
                        }
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
            Feltolt_kifizetesek(connect.conn);
            connect.conn.Close();
        }
        private void Feltolt_kifizetesek(MySqlConnection conn)
        {
            int osszeg = (int)NUD_Penz.Value;
            bool success = false;
            using(MySqlCommand insert=new MySqlCommand("INSERT INTO `kifizetes`(`dolgozoid`, `osszeg`, `datum`) VALUES (@ID,@osszeg,NOW())", conn))
            {
                insert.Parameters.Add("@ID", MySqlDbType.Int32).Value =ID;
                insert.Parameters.Add("@osszeg", MySqlDbType.Int32).Value =osszeg;

                try
                {
                    insert.ExecuteNonQuery();
                    success = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            if (success == true)
            {
                MessageBox.Show("Sikeres feltöltés!");
            }
        }

        private void CB_dolgozok_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Kapcsolat connect = new Kapcsolat();
            connect.Kapcsolodas();
            if (connect.conn.State == ConnectionState.Closed)
            {
                connect.conn.Open();
            }
            GetSelectedID(connect.conn);
            LbxFeltolt(connect.conn);
            connect.conn.Close();
        }
        private int ID;
        private void GetSelectedID(MySqlConnection conn)
        {
            string selecteditem = CB_dolgozok.SelectedItem.ToString();
            using(MySqlCommand query=new MySqlCommand("SELECT `id` FROM `torzs` WHERE `nev`=@selecteditem", conn))
            {
                query.Parameters.Add("@selecteditem", MySqlDbType.VarChar).Value = selecteditem;
                try
                {
                    MySqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        ID = reader.GetInt32(0);
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        private void LbxFeltolt(MySqlConnection conn)
        {
            int atlag = 0;
            int i = 1;
            using(MySqlCommand query=new MySqlCommand("SELECT `osszeg` FROM `kifizetes` WHERE `dolgozoid`=@ID", conn))
            {
                query.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;
                try
                {
                    MySqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        listBox1.Items.Add(CB_dolgozok.SelectedItem.ToString() + " : " + reader.GetInt32(0).ToString()+" FT");
                        atlag += reader.GetInt32(0);
                        i++;
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                i = i - 1;
                if (atlag > 0)
                {
                     atlag = atlag / i;

                }
                lbl_atlagfizu.Text = Convert.ToString(atlag+" FT");
            }
        }
    }
}
