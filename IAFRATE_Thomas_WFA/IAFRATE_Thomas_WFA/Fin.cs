using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAFRATE_Thomas_WFA
{
    public partial class Fin : Form
    {
        public Fin()
        {
            InitializeComponent();
        }

        private void Rejouer_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void Accueil_Click(object sender, EventArgs e)
        {
            Accueil Accueil = new Accueil();
            this.Hide();
            Accueil.Show();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
