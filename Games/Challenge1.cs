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
    public partial class Challenge1 : Form

    {

        public int puntaje = 0;

        public Challenge1()

        {

            InitializeComponent();

        }

        private void Challenge1_Load(object sender, EventArgs e)

        {

            lbl_num1.Text = RetonarValor();
            txt_first.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)

        {

            bool ValidarNumero = IsNumeric(lbl_num1.Text);

            if (ValidarNumero == false)

            {

                puntaje = puntaje + 1;
                lbl_num1.Text = RetonarValor();

            }

            if (ValidarNumero == true)

            {

                MessageBox.Show("Perdiste, tu puntaje fue de: " + puntaje.ToString());
                puntaje = 0;
                lbl_num1.Text = RetonarValor();

            }
        }

        private void button2_Click(object sender, EventArgs e)

        {

            bool ValidarNumero = IsNumeric(lbl_num1.Text);

            if (ValidarNumero == true)

            {

                puntaje = puntaje + 1;
                lbl_num1.Text = RetonarValor();

            }

            if (ValidarNumero == false)

            {

                MessageBox.Show("Perdiste, tu puntaje fue de: " + puntaje.ToString());
                puntaje = 0;
                lbl_num1.Text = RetonarValor();

            }
        }

        public bool Probabilidad()

        {

            Random random = new Random();
            int prob = random.Next(100);

            if (prob == 50)

            {

                prob = random.Next(100);

            }
            
            return prob < 50;

        }

        public string RetonarValor()

        {

            bool probabilidad = Probabilidad();

            string index = "";

            if(probabilidad != true)

            {

                index = Convert.ToString(SacarNumero());

            }

            if(probabilidad != false)

            {

                index = Convert.ToString(SacarLetra());

            }

            return index;

        }

        public int SacarNumero()

        {

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Random random = new Random();

            int index = random.Next(arr.Length);
            int numero = arr[index];

            return numero;

        }

        public char SacarLetra()

        {

            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            Random random = new Random();

            int index = random.Next(alpha.Length);
            char letra = alpha[index];

            return letra;
            
        }

        public bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
    }
}
    