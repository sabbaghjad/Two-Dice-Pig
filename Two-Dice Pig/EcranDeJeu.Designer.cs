namespace Two_Dice_Pig
{
    partial class EcranDeJeu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label_J1 = new Label();
            label_J2 = new Label();
            label_J3 = new Label();
            label_J4 = new Label();
            button_lancer = new Button();
            button_Stop = new Button();
            button_PasserTour = new Button();
            pictureBox_De1 = new PictureBox();
            pictureBox_De2 = new PictureBox();
            label_PointPourGagner = new Label();
            textBox_PointPourGagner = new TextBox();
            textBox_ScoreJ3 = new TextBox();
            textBox_ScoreJ2 = new TextBox();
            textBox_ScoreJ1 = new TextBox();
            textBox_ScoreJ4 = new TextBox();
            button_NouvellePartie = new Button();
            button_Retour = new Button();
            label_TitreEcranDeJeu = new Label();
            menuStrip_EcranDeJeu = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            Menu2_NouvellePartie = new ToolStripMenuItem();
            Menu2_Retour = new ToolStripMenuItem();
            Menu2_Propriété = new ToolStripMenuItem();
            joueurToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox_J1 = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripTextBox_J2 = new ToolStripTextBox();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripTextBox_J3 = new ToolStripTextBox();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripTextBox_J4 = new ToolStripTextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox_De1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_De2).BeginInit();
            menuStrip_EcranDeJeu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label_J1
            // 
            label_J1.AutoSize = true;
            label_J1.Font = new Font("Comic Sans MS", 14.25F);
            label_J1.Location = new Point(333, 18);
            label_J1.Name = "label_J1";
            label_J1.Size = new Size(62, 26);
            label_J1.TabIndex = 0;
            label_J1.Text = "label1";
            label_J1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_J2
            // 
            label_J2.AutoSize = true;
            label_J2.Font = new Font("Comic Sans MS", 14.25F);
            label_J2.Location = new Point(552, 134);
            label_J2.Name = "label_J2";
            label_J2.Size = new Size(65, 26);
            label_J2.TabIndex = 1;
            label_J2.Text = "label2";
            label_J2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_J3
            // 
            label_J3.AutoSize = true;
            label_J3.Font = new Font("Comic Sans MS", 14.25F);
            label_J3.Location = new Point(333, 250);
            label_J3.Name = "label_J3";
            label_J3.Size = new Size(65, 26);
            label_J3.TabIndex = 2;
            label_J3.Text = "label3";
            label_J3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_J4
            // 
            label_J4.AutoSize = true;
            label_J4.Font = new Font("Comic Sans MS", 14.25F);
            label_J4.Location = new Point(102, 134);
            label_J4.Name = "label_J4";
            label_J4.Size = new Size(65, 26);
            label_J4.TabIndex = 3;
            label_J4.Text = "label4";
            label_J4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_lancer
            // 
            button_lancer.BackColor = Color.Lime;
            button_lancer.Font = new Font("Comic Sans MS", 14.25F);
            button_lancer.Location = new Point(271, 169);
            button_lancer.Margin = new Padding(3, 2, 3, 2);
            button_lancer.Name = "button_lancer";
            button_lancer.Size = new Size(93, 30);
            button_lancer.TabIndex = 4;
            button_lancer.Text = "Lancer";
            button_lancer.UseVisualStyleBackColor = false;
            button_lancer.Click += button_lancer_Click;
            // 
            // button_Stop
            // 
            button_Stop.AutoSize = true;
            button_Stop.BackColor = Color.Red;
            button_Stop.Enabled = false;
            button_Stop.Font = new Font("Comic Sans MS", 14.25F);
            button_Stop.Location = new Point(358, 169);
            button_Stop.Margin = new Padding(3, 2, 3, 2);
            button_Stop.Name = "button_Stop";
            button_Stop.Size = new Size(97, 36);
            button_Stop.TabIndex = 5;
            button_Stop.Text = "Stop";
            button_Stop.UseVisualStyleBackColor = false;
            button_Stop.Click += button_Stop_Click;
            // 
            // button_PasserTour
            // 
            button_PasserTour.BackColor = Color.FromArgb(192, 192, 255);
            button_PasserTour.Font = new Font("Comic Sans MS", 14.25F);
            button_PasserTour.Location = new Point(271, 203);
            button_PasserTour.Margin = new Padding(3, 2, 3, 2);
            button_PasserTour.Name = "button_PasserTour";
            button_PasserTour.Size = new Size(184, 29);
            button_PasserTour.TabIndex = 6;
            button_PasserTour.Text = "Passer le tour";
            button_PasserTour.UseVisualStyleBackColor = false;
            button_PasserTour.Click += button_PasserTour_Click;
            // 
            // pictureBox_De1
            // 
            pictureBox_De1.Image = Properties.Resources._1;
            pictureBox_De1.InitialImage = Properties.Resources._1;
            pictureBox_De1.Location = new Point(271, 86);
            pictureBox_De1.Name = "pictureBox_De1";
            pictureBox_De1.Size = new Size(87, 78);
            pictureBox_De1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_De1.TabIndex = 7;
            pictureBox_De1.TabStop = false;
            // 
            // pictureBox_De2
            // 
            pictureBox_De2.Image = Properties.Resources._1;
            pictureBox_De2.Location = new Point(364, 86);
            pictureBox_De2.Name = "pictureBox_De2";
            pictureBox_De2.Size = new Size(91, 78);
            pictureBox_De2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_De2.TabIndex = 8;
            pictureBox_De2.TabStop = false;
            // 
            // label_PointPourGagner
            // 
            label_PointPourGagner.AutoSize = true;
            label_PointPourGagner.Font = new Font("Comic Sans MS", 14.25F);
            label_PointPourGagner.Location = new Point(508, 18);
            label_PointPourGagner.Name = "label_PointPourGagner";
            label_PointPourGagner.Size = new Size(182, 26);
            label_PointPourGagner.TabIndex = 9;
            label_PointPourGagner.Text = "Points pour Gagner ";
            // 
            // textBox_PointPourGagner
            // 
            textBox_PointPourGagner.Enabled = false;
            textBox_PointPourGagner.Font = new Font("Comic Sans MS", 14.25F);
            textBox_PointPourGagner.Location = new Point(552, 50);
            textBox_PointPourGagner.Name = "textBox_PointPourGagner";
            textBox_PointPourGagner.Size = new Size(73, 34);
            textBox_PointPourGagner.TabIndex = 10;
            textBox_PointPourGagner.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_ScoreJ3
            // 
            textBox_ScoreJ3.Enabled = false;
            textBox_ScoreJ3.Font = new Font("Comic Sans MS", 14.25F);
            textBox_ScoreJ3.Location = new Point(330, 279);
            textBox_ScoreJ3.Name = "textBox_ScoreJ3";
            textBox_ScoreJ3.Size = new Size(65, 34);
            textBox_ScoreJ3.TabIndex = 11;
            textBox_ScoreJ3.Text = "0";
            textBox_ScoreJ3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_ScoreJ2
            // 
            textBox_ScoreJ2.Enabled = false;
            textBox_ScoreJ2.Font = new Font("Comic Sans MS", 14.25F);
            textBox_ScoreJ2.Location = new Point(552, 163);
            textBox_ScoreJ2.Name = "textBox_ScoreJ2";
            textBox_ScoreJ2.Size = new Size(65, 34);
            textBox_ScoreJ2.TabIndex = 12;
            textBox_ScoreJ2.Text = "0";
            textBox_ScoreJ2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_ScoreJ1
            // 
            textBox_ScoreJ1.Enabled = false;
            textBox_ScoreJ1.Font = new Font("Comic Sans MS", 14.25F);
            textBox_ScoreJ1.Location = new Point(333, 50);
            textBox_ScoreJ1.Name = "textBox_ScoreJ1";
            textBox_ScoreJ1.Size = new Size(65, 34);
            textBox_ScoreJ1.TabIndex = 13;
            textBox_ScoreJ1.Text = "0";
            textBox_ScoreJ1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_ScoreJ4
            // 
            textBox_ScoreJ4.Enabled = false;
            textBox_ScoreJ4.Font = new Font("Comic Sans MS", 14.25F);
            textBox_ScoreJ4.Location = new Point(102, 163);
            textBox_ScoreJ4.Name = "textBox_ScoreJ4";
            textBox_ScoreJ4.Size = new Size(65, 34);
            textBox_ScoreJ4.TabIndex = 14;
            textBox_ScoreJ4.Text = "0";
            textBox_ScoreJ4.TextAlign = HorizontalAlignment.Center;
            // 
            // button_NouvellePartie
            // 
            button_NouvellePartie.Enabled = false;
            button_NouvellePartie.Font = new Font("Comic Sans MS", 14.25F);
            button_NouvellePartie.Location = new Point(529, 302);
            button_NouvellePartie.Name = "button_NouvellePartie";
            button_NouvellePartie.Size = new Size(159, 30);
            button_NouvellePartie.TabIndex = 15;
            button_NouvellePartie.Text = "Nouvelle Partie";
            button_NouvellePartie.UseVisualStyleBackColor = true;
            button_NouvellePartie.Click += button_NouvellePartie_Click;
            // 
            // button_Retour
            // 
            button_Retour.Enabled = false;
            button_Retour.Font = new Font("Comic Sans MS", 14.25F);
            button_Retour.Location = new Point(12, 302);
            button_Retour.Name = "button_Retour";
            button_Retour.Size = new Size(136, 30);
            button_Retour.TabIndex = 16;
            button_Retour.Text = "Retour";
            button_Retour.UseVisualStyleBackColor = true;
            button_Retour.Click += button_Retour_Click;
            // 
            // label_TitreEcranDeJeu
            // 
            label_TitreEcranDeJeu.AutoSize = true;
            label_TitreEcranDeJeu.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label_TitreEcranDeJeu.Location = new Point(12, 21);
            label_TitreEcranDeJeu.Name = "label_TitreEcranDeJeu";
            label_TitreEcranDeJeu.Size = new Size(239, 52);
            label_TitreEcranDeJeu.TabIndex = 17;
            label_TitreEcranDeJeu.Text = "Two-Dice Pig";
            // 
            // menuStrip_EcranDeJeu
            // 
            menuStrip_EcranDeJeu.ImageScalingSize = new Size(20, 20);
            menuStrip_EcranDeJeu.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip_EcranDeJeu.Location = new Point(0, 0);
            menuStrip_EcranDeJeu.Name = "menuStrip_EcranDeJeu";
            menuStrip_EcranDeJeu.Padding = new Padding(5, 2, 0, 2);
            menuStrip_EcranDeJeu.Size = new Size(700, 24);
            menuStrip_EcranDeJeu.TabIndex = 18;
            menuStrip_EcranDeJeu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Menu2_NouvellePartie, Menu2_Retour, Menu2_Propriété });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // Menu2_NouvellePartie
            // 
            Menu2_NouvellePartie.Enabled = false;
            Menu2_NouvellePartie.Name = "Menu2_NouvellePartie";
            Menu2_NouvellePartie.ShortcutKeys = Keys.Control | Keys.N;
            Menu2_NouvellePartie.Size = new Size(207, 22);
            Menu2_NouvellePartie.Text = "Nouvelle Partie";
            Menu2_NouvellePartie.Click += Menu2_NouvellePartie_Click;
            // 
            // Menu2_Retour
            // 
            Menu2_Retour.Enabled = false;
            Menu2_Retour.Name = "Menu2_Retour";
            Menu2_Retour.ShortcutKeys = Keys.Control | Keys.Q;
            Menu2_Retour.Size = new Size(207, 22);
            Menu2_Retour.Text = "Retour à l'acceuil";
            Menu2_Retour.Click += Menu2_Retour_Click;
            // 
            // Menu2_Propriété
            // 
            Menu2_Propriété.DropDownItems.AddRange(new ToolStripItem[] { joueurToolStripMenuItem });
            Menu2_Propriété.Name = "Menu2_Propriété";
            Menu2_Propriété.Size = new Size(207, 22);
            Menu2_Propriété.Text = "Propriété du joueur";
            // 
            // joueurToolStripMenuItem
            // 
            joueurToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox_J1, toolStripSeparator1, toolStripTextBox_J2, toolStripSeparator2, toolStripTextBox_J3, toolStripSeparator3, toolStripTextBox_J4 });
            joueurToolStripMenuItem.Name = "joueurToolStripMenuItem";
            joueurToolStripMenuItem.Size = new Size(210, 22);
            joueurToolStripMenuItem.Text = "Modifier nom des joueurs";
            // 
            // toolStripTextBox_J1
            // 
            toolStripTextBox_J1.Name = "toolStripTextBox_J1";
            toolStripTextBox_J1.Size = new Size(100, 23);
            toolStripTextBox_J1.TextChanged += toolStripTextBox_J1_TextChanged;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // toolStripTextBox_J2
            // 
            toolStripTextBox_J2.Name = "toolStripTextBox_J2";
            toolStripTextBox_J2.Size = new Size(100, 23);
            toolStripTextBox_J2.TextChanged += toolStripTextBox_J2_TextChanged;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // toolStripTextBox_J3
            // 
            toolStripTextBox_J3.Name = "toolStripTextBox_J3";
            toolStripTextBox_J3.Size = new Size(100, 23);
            toolStripTextBox_J3.Visible = false;
            toolStripTextBox_J3.TextChanged += toolStripTextBox_J3_TextChanged;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // toolStripTextBox_J4
            // 
            toolStripTextBox_J4.Name = "toolStripTextBox_J4";
            toolStripTextBox_J4.Size = new Size(100, 23);
            toolStripTextBox_J4.Visible = false;
            toolStripTextBox_J4.TextChanged += toolStripTextBox_J4_TextChanged;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // EcranDeJeu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label_TitreEcranDeJeu);
            Controls.Add(button_Retour);
            Controls.Add(button_NouvellePartie);
            Controls.Add(textBox_ScoreJ4);
            Controls.Add(textBox_ScoreJ1);
            Controls.Add(textBox_ScoreJ2);
            Controls.Add(textBox_ScoreJ3);
            Controls.Add(textBox_PointPourGagner);
            Controls.Add(label_PointPourGagner);
            Controls.Add(pictureBox_De2);
            Controls.Add(pictureBox_De1);
            Controls.Add(button_PasserTour);
            Controls.Add(button_Stop);
            Controls.Add(button_lancer);
            Controls.Add(label_J4);
            Controls.Add(label_J3);
            Controls.Add(label_J2);
            Controls.Add(label_J1);
            Controls.Add(menuStrip_EcranDeJeu);
            MainMenuStrip = menuStrip_EcranDeJeu;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EcranDeJeu";
            Text = "EcranDeJeu";
            ((System.ComponentModel.ISupportInitialize)pictureBox_De1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_De2).EndInit();
            menuStrip_EcranDeJeu.ResumeLayout(false);
            menuStrip_EcranDeJeu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_J1;
        private Label label_J2;
        private Label label_J3;
        private Label label_J4;
        private Button button_lancer;
        private Button button_Stop;
        private Button button_PasserTour;
        private PictureBox pictureBox_De1;
        private PictureBox pictureBox_De2;
        private Label label_PointPourGagner;
        private TextBox textBox_PointPourGagner;
        private TextBox textBox_ScoreJ3;
        private TextBox textBox_ScoreJ2;
        private TextBox textBox_ScoreJ1;
        private TextBox textBox_ScoreJ4;
        private Button button_NouvellePartie;
        private Button button_Retour;
        private Label label_TitreEcranDeJeu;
        private MenuStrip menuStrip_EcranDeJeu;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem Menu2_NouvellePartie;
        private ToolStripMenuItem Menu2_Retour;
        private ToolStripMenuItem Menu2_Propriété;
        private ToolStripMenuItem joueurToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox_J1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox toolStripTextBox_J2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripTextBox toolStripTextBox_J3;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripTextBox toolStripTextBox_J4;
        private ErrorProvider errorProvider;
    }
}