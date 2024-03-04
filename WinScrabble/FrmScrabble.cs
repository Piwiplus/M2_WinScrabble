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
        string Joueur1 = "";
        string Joueur2 = "";


        public FrmScrabble()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxJ1J2.Visible = true;
            Random rdm = new Random();
            joueurDebut = rdm.Next(3);
            if (joueurDebut == 1)
            {
                label7.Visible= true;
                label7.Text = "oui " + Joueur1 + " commence";
            }
            else
            {
                label7.Visible= true;
                label7.Text = "non " + Joueur2 + " commence";
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnOkJ1_Click(object sender, EventArgs e)
        {
            btnOkJ1.Enabled = false;
            btnOkJ2.Enabled = true;
            string leMot = txtSaisieMotJ1.Text;
            int nbPoints = Utilitaire.PointsMot(leMot);
            totalPoints1 = nbPoints + totalPoints1;
            txtPointJ1.Text = nbPoints.ToString();
            txtScoreJ1.Text = totalPoints1.ToString();
            lesMots1[nbMots1] = leMot;
            nbMots1++;
            if (nbPoints > meilPoint)
            {
                meilMot1 = leMot;
            }
            if (nbMots1==10)
            {
                btnOkJ1.Enabled = false;
            }
            labelSaisieJ1.Text = "\"Nombre de mots saisis : " + nbMots1 + " Mot(s)";
            if (nbMots1 == 10 && nbMots2 == 10)
            {
                foreach (string Mot in lesMots1)
                {
                    listResult.AppendText(Mot + "\n");
                }
                if (totalPoints1 > totalPoints2)
                {
                    label23.Visible = true;
                    label24.Visible = true;
                    label23.Text = "Le Joueur 1 a gagné avec un total de" + nbMots1 + "points";
                    label24.Text = "Le mot ayant rapporté le plus de points est :" + meilMot1 ;

                }
                else
                {
                    label23.Visible = true;
                    label24.Visible = true;
                    label23.Text = "Le Joueur 2 a gagné avec un total de" + nbMots2 + "points";
                    label24.Text = "Le mot ayant rapporté le plus de points est :" + meilMot1;
                }
            }
        }

        private void labelSaisieJ1_Click(object sender, EventArgs e)
        {

        }

        private void btnOkJ2_Click(object sender, EventArgs e)
        {
            btnOkJ1.Enabled = true;
            btnOkJ2.Enabled = false;
            string leMot = txtSaisieMotJ1.Text;
            int nbPoints = Utilitaire.PointsMot(leMot);
            totalPoints2 = nbPoints + totalPoints2;
            txtPointJ2.Text = nbPoints.ToString();
            txtScoreJ2.Text = totalPoints2.ToString();
            lesMots2[nbMots2] = leMot;
            nbMots2++;
            if (nbPoints > meilPoint)
            {
                meilMot2 = leMot;
            }
            if (nbMots2 == 10)
            {
                btnOkJ2.Enabled = false;
            }
            labelSaisieJ2.Text = "\"Nombre de mots saisis : " + nbMots2 + " Mot(s)";
            if (nbMots2 == 10 && nbMots1 == 10)
            {
                foreach (string Mot in lesMots2)
                {
                    listResult.AppendText(Mot + "\n");
                }
            }
            if (totalPoints1 > totalPoints2)
            {
                label23.Visible = true;
                label24.Visible = true;
                label23.Text = "Le Joueur 1 a gagné avec un total de" + nbMots1 + "points";
                label24.Text = "Le mot ayant rapporté le plus de points est :" + meilMot1;
            }
            else
            {
                label23.Visible = true;
                label24.Visible = true;
                label23.Text = "Le Joueur 2 a gagné avec un total de" + nbMots2 + "points";
                label24.Text = "Le mot ayant rapporté le plus de points est :" + meilMot1;
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
          
        }

        private void txtJoueur1_TextChanged(object sender, EventArgs e)
        {
            Joueur1 = txtJoueur1.Text;
            Joueur2 = txtJoueur2.Text;
        }
    }
}