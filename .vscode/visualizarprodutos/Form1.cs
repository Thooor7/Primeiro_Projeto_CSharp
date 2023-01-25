using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visualizarprodutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;

            if (comboBox1.Text == "Adidas")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Messi");
                comboBox2.Items.Add("Predador");
                comboBox2.Items.Add("X Speedportal");
            }
            else if (comboBox1.Text == "Nike")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Phantom GT2");
                comboBox2.Items.Add("Tiempo Legend 9 Club");
                comboBox2.Items.Add("Vapor 15 Club Campo");
            }
            else if (comboBox1.Text == "Puma")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Future");
                comboBox2.Items.Add("King");
            }
            else if (comboBox1.Text == "Umbro") 
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Fuzion Z");
                comboBox2.Items.Add("Velocita Alchemist Club");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] fotoChuteiras = Directory.GetFiles(@"C:\Users\heito\Documents\Projeto_C#\Imagens\Chuteiras");

            foreach ( string img in fotoChuteiras ) 
            {
                string[] separador = img.Split('\\');
                string[] selecionado = separador[7].Split('.');
                
              if (comboBox2.Text == selecionado[0])
                {
                    pictureBox1.ImageLocation = @"C:\Users\heito\Documents\Projeto_C#\Imagens\Chuteiras\" + comboBox2.Text + ".jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                } 


            }
        }
    }
}
