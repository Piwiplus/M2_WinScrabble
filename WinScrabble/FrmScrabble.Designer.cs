
namespace WinScrabble
{
    partial class FrmScrabble
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJoueur1 = new System.Windows.Forms.TextBox();
            this.txtJoueur2 = new System.Windows.Forms.TextBox();
            this.btnCommencerJoueur = new System.Windows.Forms.Button();
            this.groupBoxStart = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listResult = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtMeilMot = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBoxJ1J2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelSaisieJ2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtScoreJ2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPointJ2 = new System.Windows.Forms.TextBox();
            this.btnOkJ2 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSaisieMotJ2 = new System.Windows.Forms.TextBox();
            this.txtLettre7Bis = new System.Windows.Forms.MaskedTextBox();
            this.txtLettre6Bis = new System.Windows.Forms.MaskedTextBox();
            this.txtLettre5Bis = new System.Windows.Forms.MaskedTextBox();
            this.txtLettre4Bis = new System.Windows.Forms.MaskedTextBox();
            this.txtLettre3Bis = new System.Windows.Forms.MaskedTextBox();
            this.txtLettre2Bis = new System.Windows.Forms.MaskedTextBox();
            this.txtLettre1Bis = new System.Windows.Forms.MaskedTextBox();
            this.labelJoueur2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSaisieJ1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtScoreJ1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPointJ1 = new System.Windows.Forms.TextBox();
            this.btnOkJ1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSaisieMotJ1 = new System.Windows.Forms.TextBox();
            this.txtLettre7 = new System.Windows.Forms.MaskedTextBox();
            this.txtLettre6 = new System.Windows.Forms.MaskedTextBox();
            this.txtLettre5 = new System.Windows.Forms.MaskedTextBox();
            this.txtLettre4 = new System.Windows.Forms.MaskedTextBox();
            this.txtLettre3 = new System.Windows.Forms.MaskedTextBox();
            this.txtLettre2 = new System.Windows.Forms.MaskedTextBox();
            this.txtLettre1 = new System.Windows.Forms.MaskedTextBox();
            this.labelJoueur1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxStart.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBoxJ1J2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.64F);
            this.label1.Location = new System.Drawing.Point(363, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCRABBLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(72, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom joueur 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(72, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom joueur 2";
            // 
            // txtJoueur1
            // 
            this.txtJoueur1.Location = new System.Drawing.Point(189, 28);
            this.txtJoueur1.Name = "txtJoueur1";
            this.txtJoueur1.Size = new System.Drawing.Size(140, 20);
            this.txtJoueur1.TabIndex = 3;
            // 
            // txtJoueur2
            // 
            this.txtJoueur2.Location = new System.Drawing.Point(189, 63);
            this.txtJoueur2.Name = "txtJoueur2";
            this.txtJoueur2.Size = new System.Drawing.Size(140, 20);
            this.txtJoueur2.TabIndex = 4;
            // 
            // btnCommencerJoueur
            // 
            this.btnCommencerJoueur.Location = new System.Drawing.Point(502, 63);
            this.btnCommencerJoueur.Name = "btnCommencerJoueur";
            this.btnCommencerJoueur.Size = new System.Drawing.Size(90, 23);
            this.btnCommencerJoueur.TabIndex = 5;
            this.btnCommencerJoueur.Text = "COMMENCER";
            this.btnCommencerJoueur.UseVisualStyleBackColor = true;
            this.btnCommencerJoueur.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxStart
            // 
            this.groupBoxStart.Controls.Add(this.btnCommencerJoueur);
            this.groupBoxStart.Controls.Add(this.label2);
            this.groupBoxStart.Controls.Add(this.txtJoueur2);
            this.groupBoxStart.Controls.Add(this.label3);
            this.groupBoxStart.Controls.Add(this.txtJoueur1);
            this.groupBoxStart.Location = new System.Drawing.Point(12, 44);
            this.groupBoxStart.Name = "groupBoxStart";
            this.groupBoxStart.Size = new System.Drawing.Size(618, 105);
            this.groupBoxStart.TabIndex = 6;
            this.groupBoxStart.TabStop = false;
            this.groupBoxStart.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(641, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 105);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "JOUEUR XX COMMENCE";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.txtMeilMot);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.listResult);
            this.groupBox5.Location = new System.Drawing.Point(12, 604);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(860, 145);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            // 
            // listResult
            // 
            this.listResult.Location = new System.Drawing.Point(473, 19);
            this.listResult.Multiline = true;
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(327, 120);
            this.listResult.TabIndex = 24;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.64F);
            this.label22.Location = new System.Drawing.Point(367, 571);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(162, 32);
            this.label22.TabIndex = 14;
            this.label22.Text = "RESULTAT";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label23.Location = new System.Drawing.Point(72, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(319, 17);
            this.label23.TabIndex = 25;
            this.label23.Text = "Le Joueur XX a gagné avec un total de XX points";
            this.label23.Visible = false;
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // txtMeilMot
            // 
            this.txtMeilMot.Location = new System.Drawing.Point(298, 70);
            this.txtMeilMot.Name = "txtMeilMot";
            this.txtMeilMot.Size = new System.Drawing.Size(132, 20);
            this.txtMeilMot.TabIndex = 30;
            this.txtMeilMot.Visible = false;
            this.txtMeilMot.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label24.Location = new System.Drawing.Point(6, 70);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(286, 17);
            this.label24.TabIndex = 31;
            this.label24.Text = "Le mot ayant rapporté le plus de points est :";
            this.label24.Visible = false;
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // groupBoxJ1J2
            // 
            this.groupBoxJ1J2.Controls.Add(this.groupBox3);
            this.groupBoxJ1J2.Controls.Add(this.groupBox2);
            this.groupBoxJ1J2.Controls.Add(this.label4);
            this.groupBoxJ1J2.Location = new System.Drawing.Point(12, 155);
            this.groupBoxJ1J2.Name = "groupBoxJ1J2";
            this.groupBoxJ1J2.Size = new System.Drawing.Size(865, 413);
            this.groupBoxJ1J2.TabIndex = 15;
            this.groupBoxJ1J2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelSaisieJ2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtScoreJ2);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtPointJ2);
            this.groupBox3.Controls.Add(this.btnOkJ2);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtSaisieMotJ2);
            this.groupBox3.Controls.Add(this.txtLettre7Bis);
            this.groupBox3.Controls.Add(this.txtLettre6Bis);
            this.groupBox3.Controls.Add(this.txtLettre5Bis);
            this.groupBox3.Controls.Add(this.txtLettre4Bis);
            this.groupBox3.Controls.Add(this.txtLettre3Bis);
            this.groupBox3.Controls.Add(this.txtLettre2Bis);
            this.groupBox3.Controls.Add(this.txtLettre1Bis);
            this.groupBox3.Controls.Add(this.labelJoueur2);
            this.groupBox3.Location = new System.Drawing.Point(458, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 359);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // labelSaisieJ2
            // 
            this.labelSaisieJ2.AutoSize = true;
            this.labelSaisieJ2.Location = new System.Drawing.Point(115, 323);
            this.labelSaisieJ2.Name = "labelSaisieJ2";
            this.labelSaisieJ2.Size = new System.Drawing.Size(148, 13);
            this.labelSaisieJ2.TabIndex = 33;
            this.labelSaisieJ2.Text = "Nombre de mots saisis : 0 Mot";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Point(s)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Point(s)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 266);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Score";
            // 
            // txtScoreJ2
            // 
            this.txtScoreJ2.Location = new System.Drawing.Point(118, 263);
            this.txtScoreJ2.Name = "txtScoreJ2";
            this.txtScoreJ2.Size = new System.Drawing.Size(93, 20);
            this.txtScoreJ2.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Ce mot rapporte";
            // 
            // txtPointJ2
            // 
            this.txtPointJ2.Location = new System.Drawing.Point(118, 218);
            this.txtPointJ2.Name = "txtPointJ2";
            this.txtPointJ2.Size = new System.Drawing.Size(93, 20);
            this.txtPointJ2.TabIndex = 27;
            // 
            // btnOkJ2
            // 
            this.btnOkJ2.Location = new System.Drawing.Point(304, 167);
            this.btnOkJ2.Name = "btnOkJ2";
            this.btnOkJ2.Size = new System.Drawing.Size(59, 23);
            this.btnOkJ2.TabIndex = 26;
            this.btnOkJ2.Text = "Ok";
            this.btnOkJ2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 173);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "Saisie un mot";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 113);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "Lettre disponible";
            // 
            // txtSaisieMotJ2
            // 
            this.txtSaisieMotJ2.Location = new System.Drawing.Point(118, 170);
            this.txtSaisieMotJ2.Name = "txtSaisieMotJ2";
            this.txtSaisieMotJ2.Size = new System.Drawing.Size(140, 20);
            this.txtSaisieMotJ2.TabIndex = 23;
            // 
            // txtLettre7Bis
            // 
            this.txtLettre7Bis.Location = new System.Drawing.Point(304, 110);
            this.txtLettre7Bis.Name = "txtLettre7Bis";
            this.txtLettre7Bis.Size = new System.Drawing.Size(25, 20);
            this.txtLettre7Bis.TabIndex = 22;
            // 
            // txtLettre6Bis
            // 
            this.txtLettre6Bis.Location = new System.Drawing.Point(273, 110);
            this.txtLettre6Bis.Name = "txtLettre6Bis";
            this.txtLettre6Bis.Size = new System.Drawing.Size(25, 20);
            this.txtLettre6Bis.TabIndex = 21;
            // 
            // txtLettre5Bis
            // 
            this.txtLettre5Bis.Location = new System.Drawing.Point(242, 110);
            this.txtLettre5Bis.Name = "txtLettre5Bis";
            this.txtLettre5Bis.Size = new System.Drawing.Size(25, 20);
            this.txtLettre5Bis.TabIndex = 20;
            // 
            // txtLettre4Bis
            // 
            this.txtLettre4Bis.Location = new System.Drawing.Point(211, 110);
            this.txtLettre4Bis.Name = "txtLettre4Bis";
            this.txtLettre4Bis.Size = new System.Drawing.Size(25, 20);
            this.txtLettre4Bis.TabIndex = 19;
            // 
            // txtLettre3Bis
            // 
            this.txtLettre3Bis.Location = new System.Drawing.Point(180, 110);
            this.txtLettre3Bis.Name = "txtLettre3Bis";
            this.txtLettre3Bis.Size = new System.Drawing.Size(25, 20);
            this.txtLettre3Bis.TabIndex = 18;
            // 
            // txtLettre2Bis
            // 
            this.txtLettre2Bis.Location = new System.Drawing.Point(149, 110);
            this.txtLettre2Bis.Name = "txtLettre2Bis";
            this.txtLettre2Bis.Size = new System.Drawing.Size(25, 20);
            this.txtLettre2Bis.TabIndex = 17;
            // 
            // txtLettre1Bis
            // 
            this.txtLettre1Bis.Location = new System.Drawing.Point(118, 110);
            this.txtLettre1Bis.Name = "txtLettre1Bis";
            this.txtLettre1Bis.Size = new System.Drawing.Size(25, 20);
            this.txtLettre1Bis.TabIndex = 16;
            // 
            // labelJoueur2
            // 
            this.labelJoueur2.AutoSize = true;
            this.labelJoueur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.64F);
            this.labelJoueur2.Location = new System.Drawing.Point(143, 16);
            this.labelJoueur2.Name = "labelJoueur2";
            this.labelJoueur2.Size = new System.Drawing.Size(125, 32);
            this.labelJoueur2.TabIndex = 9;
            this.labelJoueur2.Text = "Joueur 2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSaisieJ1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtScoreJ1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtPointJ1);
            this.groupBox2.Controls.Add(this.btnOkJ1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSaisieMotJ1);
            this.groupBox2.Controls.Add(this.txtLettre7);
            this.groupBox2.Controls.Add(this.txtLettre6);
            this.groupBox2.Controls.Add(this.txtLettre5);
            this.groupBox2.Controls.Add(this.txtLettre4);
            this.groupBox2.Controls.Add(this.txtLettre3);
            this.groupBox2.Controls.Add(this.txtLettre2);
            this.groupBox2.Controls.Add(this.txtLettre1);
            this.groupBox2.Controls.Add(this.labelJoueur1);
            this.groupBox2.Location = new System.Drawing.Point(6, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 359);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // labelSaisieJ1
            // 
            this.labelSaisieJ1.AutoSize = true;
            this.labelSaisieJ1.Location = new System.Drawing.Point(115, 323);
            this.labelSaisieJ1.Name = "labelSaisieJ1";
            this.labelSaisieJ1.Size = new System.Drawing.Size(148, 13);
            this.labelSaisieJ1.TabIndex = 33;
            this.labelSaisieJ1.Text = "Nombre de mots saisis : 0 Mot";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(239, 266);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Point(s)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(239, 221);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Point(s)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Score";
            // 
            // txtScoreJ1
            // 
            this.txtScoreJ1.Location = new System.Drawing.Point(118, 263);
            this.txtScoreJ1.Name = "txtScoreJ1";
            this.txtScoreJ1.Size = new System.Drawing.Size(93, 20);
            this.txtScoreJ1.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Ce mot rapporte";
            // 
            // txtPointJ1
            // 
            this.txtPointJ1.Location = new System.Drawing.Point(118, 218);
            this.txtPointJ1.Name = "txtPointJ1";
            this.txtPointJ1.Size = new System.Drawing.Size(93, 20);
            this.txtPointJ1.TabIndex = 27;
            // 
            // btnOkJ1
            // 
            this.btnOkJ1.Location = new System.Drawing.Point(304, 167);
            this.btnOkJ1.Name = "btnOkJ1";
            this.btnOkJ1.Size = new System.Drawing.Size(59, 23);
            this.btnOkJ1.TabIndex = 26;
            this.btnOkJ1.Text = "Ok";
            this.btnOkJ1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Saisie un mot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Lettre disponible";
            // 
            // txtSaisieMotJ1
            // 
            this.txtSaisieMotJ1.Location = new System.Drawing.Point(118, 170);
            this.txtSaisieMotJ1.Name = "txtSaisieMotJ1";
            this.txtSaisieMotJ1.Size = new System.Drawing.Size(140, 20);
            this.txtSaisieMotJ1.TabIndex = 23;
            // 
            // txtLettre7
            // 
            this.txtLettre7.Location = new System.Drawing.Point(304, 110);
            this.txtLettre7.Name = "txtLettre7";
            this.txtLettre7.Size = new System.Drawing.Size(25, 20);
            this.txtLettre7.TabIndex = 22;
            // 
            // txtLettre6
            // 
            this.txtLettre6.Location = new System.Drawing.Point(273, 110);
            this.txtLettre6.Name = "txtLettre6";
            this.txtLettre6.Size = new System.Drawing.Size(25, 20);
            this.txtLettre6.TabIndex = 21;
            // 
            // txtLettre5
            // 
            this.txtLettre5.Location = new System.Drawing.Point(242, 110);
            this.txtLettre5.Name = "txtLettre5";
            this.txtLettre5.Size = new System.Drawing.Size(25, 20);
            this.txtLettre5.TabIndex = 20;
            // 
            // txtLettre4
            // 
            this.txtLettre4.Location = new System.Drawing.Point(211, 110);
            this.txtLettre4.Name = "txtLettre4";
            this.txtLettre4.Size = new System.Drawing.Size(25, 20);
            this.txtLettre4.TabIndex = 19;
            // 
            // txtLettre3
            // 
            this.txtLettre3.Location = new System.Drawing.Point(180, 110);
            this.txtLettre3.Name = "txtLettre3";
            this.txtLettre3.Size = new System.Drawing.Size(25, 20);
            this.txtLettre3.TabIndex = 18;
            // 
            // txtLettre2
            // 
            this.txtLettre2.Location = new System.Drawing.Point(149, 110);
            this.txtLettre2.Name = "txtLettre2";
            this.txtLettre2.Size = new System.Drawing.Size(25, 20);
            this.txtLettre2.TabIndex = 17;
            // 
            // txtLettre1
            // 
            this.txtLettre1.Location = new System.Drawing.Point(118, 110);
            this.txtLettre1.Name = "txtLettre1";
            this.txtLettre1.Size = new System.Drawing.Size(25, 20);
            this.txtLettre1.TabIndex = 16;
            // 
            // labelJoueur1
            // 
            this.labelJoueur1.AutoSize = true;
            this.labelJoueur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.64F);
            this.labelJoueur1.Location = new System.Drawing.Point(133, 16);
            this.labelJoueur1.Name = "labelJoueur1";
            this.labelJoueur1.Size = new System.Drawing.Size(125, 32);
            this.labelJoueur1.TabIndex = 9;
            this.labelJoueur1.Text = "Joueur 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.64F);
            this.label4.Location = new System.Drawing.Point(399, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "JEU";
            // 
            // FrmScrabble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 761);
            this.Controls.Add(this.groupBoxJ1J2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBoxStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmScrabble";
            this.Text = "JEU DU SCRABBLE - MODE 2 JOUEURS";
            this.groupBoxStart.ResumeLayout(false);
            this.groupBoxStart.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBoxJ1J2.ResumeLayout(false);
            this.groupBoxJ1J2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJoueur1;
        private System.Windows.Forms.TextBox txtJoueur2;
        private System.Windows.Forms.Button btnCommencerJoueur;
        private System.Windows.Forms.GroupBox groupBoxStart;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox listResult;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtMeilMot;
        private System.Windows.Forms.GroupBox groupBoxJ1J2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelSaisieJ2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtScoreJ2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPointJ2;
        private System.Windows.Forms.Button btnOkJ2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSaisieMotJ2;
        private System.Windows.Forms.MaskedTextBox txtLettre7Bis;
        private System.Windows.Forms.MaskedTextBox txtLettre6Bis;
        private System.Windows.Forms.MaskedTextBox txtLettre5Bis;
        private System.Windows.Forms.MaskedTextBox txtLettre4Bis;
        private System.Windows.Forms.MaskedTextBox txtLettre3Bis;
        private System.Windows.Forms.MaskedTextBox txtLettre2Bis;
        private System.Windows.Forms.MaskedTextBox txtLettre1Bis;
        private System.Windows.Forms.Label labelJoueur2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelSaisieJ1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtScoreJ1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPointJ1;
        private System.Windows.Forms.Button btnOkJ1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSaisieMotJ1;
        private System.Windows.Forms.MaskedTextBox txtLettre7;
        private System.Windows.Forms.MaskedTextBox txtLettre6;
        private System.Windows.Forms.MaskedTextBox txtLettre5;
        private System.Windows.Forms.MaskedTextBox txtLettre4;
        private System.Windows.Forms.MaskedTextBox txtLettre3;
        private System.Windows.Forms.MaskedTextBox txtLettre2;
        private System.Windows.Forms.MaskedTextBox txtLettre1;
        private System.Windows.Forms.Label labelJoueur1;
        private System.Windows.Forms.Label label4;
    }
}

