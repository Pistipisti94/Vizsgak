using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Levesek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_feltolt_Click(object sender, EventArgs e)
        {
            if (textBox_megnevezes.Text == "" || textBox_kaloria.Text == "" || textBox_feherje.Text == "" || textBox_zsir.Text == "" || textBox_szenhidrat.Text == "" || textBox_hamu.Text == "" || textBox_rost.Text == "")
            {
                MessageBox.Show("Üres mező");
            }
            else
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost/Levesek-feladat/backend/index.php?levesek");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"megnevezes\":"+textBox_megnevezes.Text+"," +
                                  "\"kaloria\":"+textBox_kaloria.Text+"," +
                                  "\"feherje\":" + textBox_feherje.Text + "," +
                                  "\"zsir\":" + textBox_zsir.Text + "," +
                                  "\"szenhidrat\":" + textBox_szenhidrat.Text + "," +
                                  "\"hamu\":" + textBox_hamu.Text + "," +
                                  "\"rost\":" + textBox_rost.Text + "}";

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
            }
        }
    }
}
