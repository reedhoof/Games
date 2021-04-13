using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games
{
    public partial class Challenge3 : Form

    {

        public List<string> ListaPalabras = new List<string>();
        public int puntaje = 0;
        public int contador = 0;

        public Challenge3()

        {
            InitializeComponent();

            lbl_palabra.Text = RetonarPalabra();

        }

        private void button1_Click(object sender, EventArgs e)

        {

            bool existe = Existe(lbl_palabra.Text);

            if(existe != false)

            {

                puntaje++;
                lbl_palabra.Text = RetonarPalabra();

            }

            if(existe != true)

            {

                MessageBox.Show("Perdiste, tu puntaje fue de " + puntaje);
                puntaje = 0;
                contador = 0;
                ListaPalabras.Clear();
                lbl_palabra.Text = RetonarPalabra();

            }
        }

        private void button2_Click(object sender, EventArgs e)

        {

            bool existe = Existe(lbl_palabra.Text);

            if (existe != true)

            {

                puntaje++;
                lbl_palabra.Text = RetonarPalabra();

            }

            if (existe != false)

            {

                MessageBox.Show("Perdiste, tu puntaje fue de " + puntaje);
                puntaje = 0;
                contador = 0;
                ListaPalabras.Clear();
                lbl_palabra.Text = RetonarPalabra();

            }
        }

        public string RetonarPalabra()

        {

            string[] words = { "Espejo", "Mundo", "Hola", "Puerta", "Memoria", "Perro", "Gato", "Animal",
            "Papá", "Mamá" };

            Random random = new Random();

            string word = words[random.Next(0, words.Length)];

            return word;

        }

        public bool Existe(string palabra)

        {

            ListaPalabras.Add(palabra);

            contador = ListaPalabras.Count(s => s.Contains(palabra));

            if (contador > 1)
                return true;

            return false;

        }
    }
}
