using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaVizsga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Adatbazis Adatbazis = new Adatbazis();
        List<Futar> futars = new List<Futar>();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFutars();
        }

        private void LoadFutars()
        {
            futars = Adatbazis.GetAllFutar();
            foreach (var item in futars)
            {
                listBox_futars.Items.Add(item);
            }
        }

        private void listBox_futars_SelectedIndexChanged(object sender, EventArgs e)
        {
            Futar futar = listBox_futars.SelectedItem as Futar;
            textBox_fazon.Text = futar.fazon.ToString();
            textBox_fnev.Text = futar.fnev;
            textBox_ftel.Text = futar.ftel.ToString();
            textBox_ftel.MaxLength = 12;                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Adatbazis.Modosit(textBox_ftel.Text, textBox_fnev.Text); 
                listBox_futars.Items.Clear();
                LoadFutars();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_ftel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_ftel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string s = textBox_ftel.Text;
                if (s.Length == 7)
                {
                    double sAsD = double.Parse(s);
                    textBox_ftel.Text = string.Format("{0:+36 ###-####}", sAsD).ToString();
                }
                if (textBox_ftel.Text.Length > 1)
                    textBox_ftel.SelectionStart = textBox_ftel.Text.Length;
                textBox_ftel.SelectionLength = 0;
            }
            catch (Exception)
            {
            }
            
        }
    }
}
