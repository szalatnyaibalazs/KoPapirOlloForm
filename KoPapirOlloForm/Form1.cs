using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoPapirOlloForm
{
    public partial class frmFo : Form
    {
        public int Jatekos { get; private set; }
        public int Szgep { get; private set; }
        public frmFo()
        {
            InitializeComponent();
            KezdetiBeallitas();
        }

        private void pbJatekos_Click(object sender, EventArgs e)
        {

        }

        private void frmFo_Load(object sender, EventArgs e)
        {

        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            KezdetiBeallitas();
        }

        private void KezdetiBeallitas()
        {
            lblJatekos.Text = "";
            lblGep.Text = "";
            lblGyoztes.Text = "";
            Jatekos = 0;
            Szgep = 0;
        }

        private void btnKo_Click(object sender, EventArgs e)
        {
            pbJatekos.Image = Image.FromFile("ko.jpg");
        }

        private void btnPapir_Click(object sender, EventArgs e)
        {
            pbJatekos.Image = Image.FromFile("papir.jpg");
        }

        private void btnOllo_Click(object sender, EventArgs e)
        {
            pbJatekos.Image = Image.FromFile("ollo.jpg");
        }

        private void Fordulo(int jatekos)
        {
            Random rand = new Random();
            int gep = rand.Next(1,4);

            if (gep == jatekos)
            {
                jatekos++;
                Szgep++;
            }
            else
            {
                if ((jatekos == 1 && gep==3) || 
                   (jatekos == 2 && gep == 1)||
                   (jatekos == 3 && gep == 2))
                {
                    Jatekos++;
                }
                else
                {
                    Szgep++;
                }
            }
        }
    }
}
