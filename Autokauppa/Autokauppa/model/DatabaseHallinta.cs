
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Autokauppa;



namespace Autokauppa.model
{
    public class DatabaseHallinta
    {
        MySqlConnection dbYhteys = new MySqlConnection();
        string yhteysTiedot;


        mallimerkit mallimerkit2 = new mallimerkit(frm);
        private static Form1 frm;

        // SqlConnection dbYhteys;


        public DatabaseHallinta()
        {
            yhteysTiedot = ("datasource=localhost;port=3306;username=root;password=;database=autokauppa");
        }

        public bool connectDatabase()
        {
            dbYhteys.ConnectionString = (yhteysTiedot);

            try
            {
                dbYhteys.Open();
                Console.WriteLine("Toimii!");

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e);
                dbYhteys.Close();
                return false;

            }

        }

        public void disconnectDatabase()
        {
            dbYhteys.Close();
        }

        public bool saveAutoIntoDatabase(Auto newAuto)
        {
            bool palaute = false;
            return palaute;


        }

        public List<string> getAllAutoMakersFromDatabase()
        {
            List<string> palaute = mallimerkit2.Merkkio;

            return palaute;
        }

        public List<string> getAutoModelsByMakerId()

        {
            List<string> palaute = mallimerkit2.Mallio;

            return palaute;

        }

    }
}
