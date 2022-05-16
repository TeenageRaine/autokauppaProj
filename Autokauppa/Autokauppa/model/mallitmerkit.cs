using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autokauppa.model;
using MySql.Data.MySqlClient;

namespace Autokauppa.model
{
    public class mallimerkit
    {
        public List<string> Merkkio = new List<string>();
        public List<string> Mallio = new List<string>();



        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection dbYhteys = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=autokauppa;Allow User Variables=True");

         public string Auton_mallin_nimi { get; set; }
         public string Merkki { get; set; }


        Form1 frm1;

        public mallimerkit(Form1 frm)
        {
            frm1 = frm;
        }


        public void Mallit()
         {
             Console.WriteLine("malleja!");

             dbYhteys.Open();

             frm1.haku();

             string s = frm1.haku();


             string sql = "Select Auton_mallin_nimi, AutonMerkkiID, autonmerkki.ID from autonmerkki, autonmallit where autonmerkki.merkki = @Merkki and autonmerkki.ID = autonmallit.AutonMerkkiID;";

             cmd = new MySqlCommand(sql, dbYhteys);

             cmd.Parameters.Add("@Merkki", MySqlDbType.VarChar);
             cmd.Parameters["@Merkki"].Value = s;

             MySqlDataReader reader = cmd.ExecuteReader();


            Mallio.Clear();

             while (reader.Read())
             {
                Auton_mallin_nimi = (String)reader["Auton_mallin_nimi"];
                Mallio.Add(Auton_mallin_nimi);
             }

            dbYhteys.Close();

        }

        public void Merkit()
        {
            Console.WriteLine("merkkej!");

            dbYhteys.Open();

            string sql = "SELECT * FROM autonmerkki";

            cmd = new MySqlCommand(sql, dbYhteys);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Merkki = (String)reader["Merkki"];
                
                Merkkio.Add(Merkki);
            }

           
            Console.WriteLine(string.Join("\t", Merkkio));



            dbYhteys.Close();

        }

    }
}
