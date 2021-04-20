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
    public partial class kesesek : Form
    {
        public kesesek()
        {
            InitializeComponent();
        }

        private void cb_kesok_Enter(object sender, EventArgs e)
        {
            Kapcsolat connect = new Kapcsolat();
            connect.Kapcsolodas();
            if (connect.conn.State == ConnectionState.Closed)
            {
                connect.conn.Open();
            }
            Kesokfeltoltes(connect.conn);
            GetNev(connect.conn);
        }
        private List<int> berloID = new List<int>();
        private List<int> peldany = new List<int>();
        private List<string> konyvID = new List<string>();
        private void Kesokfeltoltes(MySqlConnection conn)
        {
            using(MySqlCommand query=new MySqlCommand("SELECT `konyvID`, `kolcsonzoID`, `kivetelDatum`, `peldany` FROM `kolcsonzes` ", conn))
            {
                try
                {
                    MySqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        DateTime date = DateTime.UtcNow.Date;
                        string kiveteldatum = reader.GetString(2);
        ;
                        DateTime kolcsonzesDatuma = DateTime.ParseExact(kiveteldatum, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                        int diff = Convert.ToInt32((date - kolcsonzesDatuma).TotalDays);
                        if (diff > 30)
                        {
                            berloID.Add(reader.GetInt32(1));
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

        private void GetNev(MySqlConnection conn)
        {
            for (int i = 0; i < berloID.Count; i++)
            {
                using(MySqlCommand query=new MySqlCommand($"SELECT `nev` FROM `kolcsonzo` WHERE `ID`={berloID[i]}",conn))
                {
                    try
                    {
                        MySqlDataReader reader = query.ExecuteReader();
                        while (reader.Read())
                        {
                            cb_kesok.Items.Add(reader.GetString(0));
                        }
                        reader.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
        }

        private void cb_kesok_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            konyvID.Clear();
            Kapcsolat connect = new Kapcsolat();
            connect.Kapcsolodas();
            if (connect.conn.State == ConnectionState.Closed)
            {
                connect.conn.Open();
            }
            GetselectedID(connect.conn);
            GetKonyv(connect.conn);
        }
        private int ID;
        private void GetselectedID(MySqlConnection conn)
        {
            string selecteditem = cb_kesok.SelectedItem.ToString();
            using(MySqlCommand query=new MySqlCommand("SELECT `ID` FROM `kolcsonzo` WHERE `nev`=@selecteditem", conn))
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

        private void GetKonyv(MySqlConnection conn)
        {
            using (MySqlCommand query = new MySqlCommand($"SELECT `konyvID`,`peldany`,`kivetelDatum` FROM `kolcsonzes` WHERE `kolcsonzoID`={ID}", conn))
            {
                try
                {
                    MySqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        DateTime date = DateTime.UtcNow.Date;
                        string kiveteldatum = reader.GetString(2);
                        ;
                        DateTime kolcsonzesDatuma = DateTime.ParseExact(kiveteldatum, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                        int diff = Convert.ToInt32((date - kolcsonzesDatuma).TotalDays);
                        if (diff > 30)
                        {
                            konyvID.Add(reader.GetString(0));
                            peldany.Add(reader.GetInt32(1));
                        }
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            for (int i = 0; i < konyvID.Count; i++)
            {
                string cim = konyvID[i];
                using (MySqlCommand query = new MySqlCommand("SELECT `Cím`, `Szerzo` FROM `konyvek` WHERE `Kod`=@cim", conn))
                {
                    query.Parameters.Add("@cim", MySqlDbType.VarChar).Value = cim;
                    try
                    {
                        MySqlDataReader reader = query.ExecuteReader();
                        while (reader.Read())
                        {
                            listBox1.Items.Add(cb_kesok.Text+" -> "+reader.GetString(1)+":"+reader.GetString(0)+" ("+peldany[i].ToString()+")");
                        }
                        reader.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
        }
    }
}
