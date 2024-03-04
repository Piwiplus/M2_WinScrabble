using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinScrabble
{
    public partial class FrmScrabble : Form

    {
        int totalPoints = 0;                // nombre de points du joueur
        int nbMots = 0;                     // nombre de mots proposés par le joueur
        string[] lesMots = new string[10];  // mots proposés par le joueur
        int joueurDebut = 0; //joueur qui commence
        public FrmScrabble()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            random rdm = new Random();   
            joueurDebut = rdm.next(3);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOkJ1_Click(object sender, EventArgs e)
        {
            string leMot = txtSaisieMotJ1.Text;
            int nbPoints = Utilitaire.PointsMot(leMot);
            totalPoints = nbPoints + totalPoints;
            txtPointsJ1.Text = nbPoints.ToString();
            totPoints.Text = totalPoints.ToString();
        }

        private void btnOkJ2_Click(object sender, EventArgs e)
        {
            string leMot = txtMot.Text;
            int nbPoints = Utilitaire.PointsMot(leMot);
            totalPoints = nbPoints + totalPoints;
            txtPoints.Text = nbPoints.ToString();
            totPoints.Text = totalPoints.ToString();
        }

        private void txtLettre1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
