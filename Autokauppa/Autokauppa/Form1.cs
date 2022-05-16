using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autokauppa.controller;
using Autokauppa.model;
namespace Autokauppa
{
    public partial class Form1 : Form
    {

        KaupanLogiikka registerHandler;

        mallimerkit mallitMERKIT;

        public Form1()
        {
            registerHandler = new KaupanLogiikka();
            mallitMERKIT = new mallimerkit(this);
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            
            mallitMERKIT.Merkit();

            comboBox1.Items.Add(registerHandler.getAllAutoMakers());
            comboBox1.DataSource = mallitMERKIT.Merkkio;


            Console.WriteLine(string.Join("\t", registerHandler.getAllAutoMakers()));


            // mallitMERKIT.esto();
            mallitMERKIT.Mallit();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void testDbConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerHandler.TestDatabaseConnection();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mallitMERKIT.Mallit();

            comboBox2.DataSource = null;

                    comboBox2.Items.Add(registerHandler.getAutoModels());

                    comboBox2.DataSource = mallitMERKIT.Mallio;

                    Console.WriteLine(haku()); 
        }
        
        public string haku()
        {
          string selected1 = comboBox1.SelectedItem.ToString();
          return selected1;
        } 

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
