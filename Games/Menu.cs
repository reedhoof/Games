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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_cha1_Click(object sender, EventArgs e)

        {

            Challenge1 form = new Challenge1();

            form.Show();
            this.Hide();

        }

        private void btn_cha2_Click(object sender, EventArgs e)

        {

            Challenge2 form = new Challenge2();

            form.Show();
            this.Hide();

        }
    }
}
