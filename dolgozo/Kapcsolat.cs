using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace április_20
{
    class Kapcsolat
    {
        public MySqlConnection conn;
        protected string database = "dolgozo";
        protected string host = "localhost";
        protected string user = "root";
        protected string pwd = "";
        public void Kapcsolodas()
        {
            MySqlConnectionStringBuilder db = new MySqlConnectionStringBuilder();
            db.Server = this.host;
            db.Database = this.database;
            db.UserID = this.user;
            db.Password = this.pwd;

            conn = new MySqlConnection(db.ToString());
            conn.Open();
        }
    }
}
