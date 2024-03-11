using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinScrabble
{
    public partial class FrmScrabble : Form

    {
        int totalPoints1 = 0;                // nombre de points du joueur 1
        int nbMots1 = 0;                     // nombre de mots proposés par le joueur 1
        string[] lesMots1 = new string[10];  // mots proposés par le joueur 1
        int totalPoints2 = 0;                // nombre de points du joueur 2
        int nbMots2 = 0;                     // nombre de mots proposés par le joueur 2
        string[] lesMots2 = new string[10];  // mots proposés par le joueur 2
        int joueurDebut = 0; //joueur qui commence
        string meilMot1 = "";
        string meilMot2= "";
        int meilPoint = 0;


        public FrmScrabble()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Joueur1 = txtJoueur1.Text;
            string Joueur2 = txtJoueur2.Text;
            labelJoueur1.Text = Joueur1;
            labelJoueur2.Text = Joueur2;
            groupBoxJ1J2.Visible = true;
            groupBoxStart.Visible = false;
            Random rdm = new Random();
            joueurDebut = rdm.Next(3);
            if (joueurDebut == 1)
            {
                label7.Visible= true;
                label7.Text = Joueur1 + " commence";
                groupBox3.Enabled = false;
                groupBox2.Enabled = true;
                txtLettre1.Text = Utilitaire.RandomChar();
                txtLettre2.Text = Utilitaire.RandomChar();
                txtLettre3.Text = Utilitaire.RandomChar();
                txtLettre4.Text = Utilitaire.RandomChar();
                txtLettre5.Text = Utilitaire.RandomChar();
                txtLettre6.Text = Utilitaire.RandomChar();
                txtLettre7.Text = Utilitaire.RandomChar();
            }
            else
            {
                label7.Visible= true;
                label7.Text = Joueur2 + " commence";
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
                txtLettre1Bis.Text = Utilitaire.RandomChar();
                txtLettre2Bis.Text = Utilitaire.RandomChar();
                txtLettre3Bis.Text = Utilitaire.RandomChar();
                txtLettre4Bis.Text = Utilitaire.RandomChar();
                txtLettre5Bis.Text = Utilitaire.RandomChar();
                txtLettre6Bis.Text = Utilitaire.RandomChar();
                txtLettre7Bis.Text = Utilitaire.RandomChar();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnOkJ1_Click(object sender, EventArgs e)
        {
            btnOkJ1.Enabled = false;
            string leMot = txtSaisieMotJ1.Text;
            int nbPoints = Utilitaire.PointsMot(leMot);
            totalPoints1 = nbPoints + totalPoints1;
            txtPointJ1.Text = nbPoints.ToString();
            txtScoreJ1.Text = totalPoints1.ToString();
            lesMots1[nbMots1] = leMot;
            nbMots1++;
            txtLettre1.Text = "";
            txtLettre2.Text = "";
            txtLettre3.Text = "";
            txtLettre4.Text = "";
            txtLettre5.Text = "";
            txtLettre6.Text = "";
            txtLettre7.Text = "";
            txtLettre1Bis.Text = Utilitaire.RandomChar();
            txtLettre2Bis.Text = Utilitaire.RandomChar();
            txtLettre3Bis.Text = Utilitaire.RandomChar();
            txtLettre4Bis.Text = Utilitaire.RandomChar();
            txtLettre5Bis.Text = Utilitaire.RandomChar();
            txtLettre6Bis.Text = Utilitaire.RandomChar();
            txtLettre7Bis.Text = Utilitaire.RandomChar();
            if (nbPoints > meilPoint)
            {
                meilMot1 = leMot;
            }
            if (nbMots2 != 10)
            {
                btnOkJ2.Enabled = true;
            }
            labelSaisieJ1.Text = "\"Nombre de mots saisis : " + nbMots1 + " Mot(s)";
            if (nbMots2 == 10 && nbMots1 == 10)
            {
                string Joueur1 = txtJoueur1.Text;
                string Joueur2 = txtJoueur2.Text;
                labelJoueur1.Text = Joueur1;
                labelJoueur2.Text = Joueur2;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                foreach (string Mot in lesMots2)
                {
                    listResult.AppendText(Mot + "\n");
                }
                if (totalPoints1 > totalPoints2)
                {
                    label23.Visible = true;
                    label24.Visible = true;
                    label23.Text = "Le " + Joueur1 + " a gagné avec un total de " + totalPoints1 + " points";
                    label24.Text = "Le mot ayant rapporté le plus de points est : " + meilMot1;
                }
                else
                {
                    label23.Visible = true;
                    label24.Visible = true;
                    label23.Text = "Le " + Joueur2 + " a gagné avec un total de " + totalPoints2 + " points";
                    label24.Text = "Le mot ayant rapporté le plus de points est : " + meilMot1;
                }
            }
            txtSaisieMotJ1.Clear();
            groupBox2.Enabled = false;
            groupBox3.Enabled = true;
        }

        private void labelSaisieJ1_Click(object sender, EventArgs e)
        {

        }

        private void btnOkJ2_Click(object sender, EventArgs e)
        {
            btnOkJ2.Enabled = false;
            string leMot = txtSaisieMotJ2.Text;
            int nbPoints = Utilitaire.PointsMot(leMot);
            totalPoints2 = nbPoints + totalPoints2;
            txtPointJ2.Text = nbPoints.ToString();
            txtScoreJ2.Text = totalPoints2.ToString();
            lesMots2[nbMots2] = leMot;
            nbMots2++;
            txtLettre1.Text = Utilitaire.RandomChar();
            txtLettre2.Text = Utilitaire.RandomChar();
            txtLettre3.Text = Utilitaire.RandomChar();
            txtLettre4.Text = Utilitaire.RandomChar();
            txtLettre5.Text = Utilitaire.RandomChar();
            txtLettre6.Text = Utilitaire.RandomChar();
            txtLettre7.Text = Utilitaire.RandomChar();
            txtLettre1Bis.Text = "";
            txtLettre2Bis.Text = "";
            txtLettre3Bis.Text = "";
            txtLettre4Bis.Text = "";
            txtLettre5Bis.Text = "";
            txtLettre6Bis.Text = "";
            txtLettre7Bis.Text = "";
            if (nbPoints > meilPoint)
            {
                meilMot2 = leMot;
            }
            if (nbMots1 != 10)
            {
                btnOkJ1.Enabled = true;
            }
            labelSaisieJ2.Text = "\"Nombre de mots saisis : " + nbMots2 + " Mot(s)";
            if (nbMots2 == 10 && nbMots1 == 10)
            {
                string Joueur1 = txtJoueur1.Text;
                string Joueur2 = txtJoueur2.Text;
                labelJoueur1.Text = Joueur1;
                labelJoueur2.Text = Joueur2;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                foreach (string Mot in lesMots2)
                {
                    listResult.AppendText(Mot + "\n");
                }
                if (totalPoints1 > totalPoints2)
                {
                    label23.Visible = true;
                    label24.Visible = true;
                    label23.Text = "Le "+Joueur1+" a gagné avec un total de " + totalPoints1 + " points";
                    label24.Text = "Le mot ayant rapporté le plus de points est : " + meilMot1;
                }
                else
                {
                    label23.Visible = true;
                    label24.Visible = true;
                    label23.Text = "Le "+Joueur2+" a gagné avec un total de " + totalPoints2 + " points";
                    label24.Text = "Le mot ayant rapporté le plus de points est : " + meilMot1;
                }
            }
            txtSaisieMotJ2.Clear();
            groupBox3.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void label23_Click(object sender, EventArgs e)
        {
          
        }

        private void txtJoueur1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtLettre1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtLettre1Bis_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtSaisieMotJ2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelJoueur1_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}