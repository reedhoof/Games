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

    public partial class Challenge2 : Form

    {

        public int puntaje = 0;
        public int numeroInicial = 0;
        public int n2 = 0;

        public Challenge2()

        {

            InitializeComponent();

        }

        private void Challenge2_Load(object sender, EventArgs e)

        {

            lbl_num.Text = SacarNumero().ToString();
            button1.Image = Image.FromFile(@"C:\Users\dmellado\Downloads\down-arrow.png");
            button2.Image = Image.FromFile(@"C:\Users\dmellado\Downloads\up-arrow.png");
            button1.FlatStyle = FlatStyle.Flat;
            button2.FlatStyle = FlatStyle.Flat;
            button1.Enabled = false;
            button2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)

        {

            bool comparar = ValidarInferior(Convert.ToInt32(lbl_num.Text));

            if (comparar != false)


            {

                puntaje++;
                CambiarLabel();

            }

            if(comparar != true)

            {

                MessageBox.Show("Perdiste, puntaje de: " + puntaje.ToString());
                puntaje = 0;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
                //CambiarLabel();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            bool comparar = ValidarSuperior(Convert.ToInt32(lbl_num.Text));

            if (comparar != false)


            {

                puntaje++;
                CambiarLabel();

            }

            if (comparar != true)

            {

                MessageBox.Show("Perdiste, puntaje de: " + puntaje.ToString());
                puntaje = 0;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
                //CambiarLabel();

            }
        }

        private void button3_Click(object sender, EventArgs e)

        {

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            numeroInicial = Convert.ToInt32(lbl_num.Text);
            lbl_num.Text = SacarNumero().ToString();

        }

        public bool ValidarSuperior(int txt_num)

        {

            bool activo = false;

            if (numeroInicial < txt_num)

            {

                numeroInicial = txt_num;
                activo = true;

            }

            return activo;

        }

        public bool ValidarInferior(int txt_num)

        {

            bool activo = false;

            if (numeroInicial > txt_num)

            {

                numeroInicial = txt_num;
                activo = true;

            }

            return activo;

        }

        public string CambiarLabel()


        {

            return lbl_num.Text = SacarNumero().ToString();

        }

        public int SacarNumero()

        {

            int[] arr = new int[101];

            for (int i = 1; i < arr.Length; i++)

            {

                arr[i] = i;

            }

            arr = arr.Skip(1).ToArray();

            Random random = new Random();

            int index = random.Next(arr.Length);
            int numero = arr[index];

            return numero;

        }
    }
}
