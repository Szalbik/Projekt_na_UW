using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_na_projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceReference1.WebService1SoapClient polaFigur = new ServiceReference1.WebService1SoapClient();
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = polaFigur.kwadrat(Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = polaFigur.trojkat(Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference4.USZipSoapClient Client = new ServiceReference4.USZipSoapClient();
            richTextBox1.Text = Client.GetInfoByZIP(textBox2.Text).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string liczby = textBox5.Text;
            string operacja;

            ServiceReference5.WebService1SoapClient klient = new ServiceReference5.WebService1SoapClient();
            ServiceReference5.ArrayOfDouble aod = new ServiceReference5.ArrayOfDouble();
            foreach(var d in liczby.Split(','))
            {
                aod.Add(Convert.ToDouble(d));
            }

            switch (comboBox2.SelectedItem)
            {
                case "Mediana":
                    button4.Text = klient.mediana(aod).ToString();
                    break;
                case "Srednia":
                    button4.Text = klient.srednia(aod).ToString();
                    break;
                case "Wariancja":
                    button4.Text = klient.wariancja(aod).ToString();
                    break;
                case "Standardowe odchylenie":
                    button4.Text = klient.std_odchylenie(aod).ToString();
                    break;
                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
