namespace Two_Dice_Pig
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox_logo = new PictureBox();
            label_TitreAcceuil = new Label();
            textBox_J2 = new TextBox();
            label_AjoutJoueur = new Label();
            checkBox_J3 = new CheckBox();
            textBox_J3 = new TextBox();
            checkBox_J4 = new CheckBox();
            textBox_J4 = new TextBox();
            button_quitter = new Button();
            button_instruction = new Button();
            button_demarrer = new Button();
            label_pointsGagner = new Label();
            radioButton_150 = new RadioButton();
            radioButton_300 = new RadioButton();
            radioButton_200 = new RadioButton();
            richTextBox_meilleursGagnant = new RichTextBox();
            button_J1 = new Button();
            pictureBox_logo2 = new PictureBox();
            errorProvider = new ErrorProvider(components);
            button_J4 = new Button();
            button_J3 = new Button();
            button_J2 = new Button();
            colorDialog_J1 = new ColorDialog();
            colorDialog_J2 = new ColorDialog();
            colorDialog_J3 = new ColorDialog();
            colorDialog_J4 = new ColorDialog();
            textBox_J1 = new TextBox();
            label_MeilleurGagnant = new Label();
            menuStrip_Acceuil = new MenuStrip();
            Menu_Demarrer = new ToolStripMenuItem();
            MenuItem_Demarrer = new ToolStripMenuItem();
            MenuItem_Quitter = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            menuStrip_Acceuil.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_logo
            // 
            pictureBox_logo.Location = new Point(257, 266);
            pictureBox_logo.Name = "pictureBox_logo";
            pictureBox_logo.Size = new Size(88, 80);
            pictureBox_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_logo.TabIndex = 0;
            pictureBox_logo.TabStop = false;
            // 
            // label_TitreAcceuil
            // 
            label_TitreAcceuil.AutoSize = true;
            label_TitreAcceuil.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label_TitreAcceuil.Location = new Point(10, 27);
            label_TitreAcceuil.Name = "label_TitreAcceuil";
            label_TitreAcceuil.Size = new Size(239, 52);
            label_TitreAcceuil.TabIndex = 1;
            label_TitreAcceuil.Text = "Two-Dice Pig";
            // 
            // textBox_J2
            // 
            textBox_J2.BackColor = Color.Lime;
            textBox_J2.Font = new Font("Comic Sans MS", 14.25F);
            textBox_J2.Location = new Point(35, 148);
            textBox_J2.Name = "textBox_J2";
            textBox_J2.Size = new Size(128, 34);
            textBox_J2.TabIndex = 3;
            textBox_J2.Text = "J2";
            textBox_J2.KeyPress += textBox_J2_KeyPress;
            textBox_J2.Validating += textBox_J2_Validating;
            // 
            // label_AjoutJoueur
            // 
            label_AjoutJoueur.AutoSize = true;
            label_AjoutJoueur.Font = new Font("Comic Sans MS", 14.25F);
            label_AjoutJoueur.Location = new Point(10, 187);
            label_AjoutJoueur.Name = "label_AjoutJoueur";
            label_AjoutJoueur.Size = new Size(188, 26);
            label_AjoutJoueur.TabIndex = 4;
            label_AjoutJoueur.Text = "Ajouter des joueurs";
            // 
            // checkBox_J3
            // 
            checkBox_J3.AutoSize = true;
            checkBox_J3.Location = new Point(10, 226);
            checkBox_J3.Name = "checkBox_J3";
            checkBox_J3.Size = new Size(15, 14);
            checkBox_J3.TabIndex = 5;
            checkBox_J3.UseVisualStyleBackColor = true;
            checkBox_J3.CheckedChanged += checkBox_J3_CheckedChanged;
            // 
            // textBox_J3
            // 
            textBox_J3.BackColor = Color.Yellow;
            textBox_J3.Enabled = false;
            textBox_J3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_J3.Location = new Point(35, 214);
            textBox_J3.Name = "textBox_J3";
            textBox_J3.Size = new Size(128, 34);
            textBox_J3.TabIndex = 6;
            textBox_J3.Text = "J3";
            textBox_J3.KeyPress += textBox_J3_KeyPress;
            textBox_J3.Validating += textBox_J3_Validating;
            // 
            // checkBox_J4
            // 
            checkBox_J4.AutoSize = true;
            checkBox_J4.Enabled = false;
            checkBox_J4.Location = new Point(10, 263);
            checkBox_J4.Name = "checkBox_J4";
            checkBox_J4.Size = new Size(15, 14);
            checkBox_J4.TabIndex = 7;
            checkBox_J4.UseVisualStyleBackColor = true;
            checkBox_J4.CheckedChanged += checkBox_J4_CheckedChanged;
            // 
            // textBox_J4
            // 
            textBox_J4.BackColor = Color.Red;
            textBox_J4.Enabled = false;
            textBox_J4.Font = new Font("Comic Sans MS", 14.25F);
            textBox_J4.Location = new Point(35, 251);
            textBox_J4.Name = "textBox_J4";
            textBox_J4.Size = new Size(128, 34);
            textBox_J4.TabIndex = 8;
            textBox_J4.Text = "J4";
            textBox_J4.KeyPress += textBox_J4_KeyPress;
            textBox_J4.Validating += textBox_J4_Validating;
            // 
            // button_quitter
            // 
            button_quitter.Font = new Font("Comic Sans MS", 14.25F);
            button_quitter.Location = new Point(12, 396);
            button_quitter.Name = "button_quitter";
            button_quitter.Size = new Size(203, 44);
            button_quitter.TabIndex = 9;
            button_quitter.Text = "Quitter";
            button_quitter.UseVisualStyleBackColor = true;
            button_quitter.Click += button_quitter_Click;
            // 
            // button_instruction
            // 
            button_instruction.Font = new Font("Comic Sans MS", 14.25F);
            button_instruction.Location = new Point(297, 393);
            button_instruction.Name = "button_instruction";
            button_instruction.Size = new Size(203, 46);
            button_instruction.TabIndex = 10;
            button_instruction.Text = "Comment Jouer";
            button_instruction.UseVisualStyleBackColor = true;
            button_instruction.Click += button_instruction_Click;
            // 
            // button_demarrer
            // 
            button_demarrer.Font = new Font("Comic Sans MS", 14.25F);
            button_demarrer.Location = new Point(584, 394);
            button_demarrer.Name = "button_demarrer";
            button_demarrer.Size = new Size(204, 44);
            button_demarrer.TabIndex = 11;
            button_demarrer.Text = "Démarrer";
            button_demarrer.UseVisualStyleBackColor = true;
            button_demarrer.Click += button_demarrer_Click;
            // 
            // label_pointsGagner
            // 
            label_pointsGagner.AutoSize = true;
            label_pointsGagner.Font = new Font("Comic Sans MS", 14.25F);
            label_pointsGagner.Location = new Point(257, 111);
            label_pointsGagner.Name = "label_pointsGagner";
            label_pointsGagner.Size = new Size(173, 26);
            label_pointsGagner.TabIndex = 12;
            label_pointsGagner.Text = "Points pour gagner";
            // 
            // radioButton_150
            // 
            radioButton_150.AutoSize = true;
            radioButton_150.Font = new Font("Comic Sans MS", 12F);
            radioButton_150.Location = new Point(239, 140);
            radioButton_150.Name = "radioButton_150";
            radioButton_150.Size = new Size(55, 27);
            radioButton_150.TabIndex = 13;
            radioButton_150.TabStop = true;
            radioButton_150.Text = "150";
            radioButton_150.UseVisualStyleBackColor = true;
            // 
            // radioButton_300
            // 
            radioButton_300.AutoSize = true;
            radioButton_300.Font = new Font("Comic Sans MS", 12F);
            radioButton_300.Location = new Point(386, 140);
            radioButton_300.Name = "radioButton_300";
            radioButton_300.Size = new Size(58, 27);
            radioButton_300.TabIndex = 14;
            radioButton_300.TabStop = true;
            radioButton_300.Text = "300";
            radioButton_300.UseVisualStyleBackColor = true;
            // 
            // radioButton_200
            // 
            radioButton_200.AutoSize = true;
            radioButton_200.Font = new Font("Comic Sans MS", 12F);
            radioButton_200.Location = new Point(314, 140);
            radioButton_200.Name = "radioButton_200";
            radioButton_200.Size = new Size(58, 27);
            radioButton_200.TabIndex = 15;
            radioButton_200.TabStop = true;
            radioButton_200.Text = "200";
            radioButton_200.UseVisualStyleBackColor = true;
            // 
            // richTextBox_meilleursGagnant
            // 
            richTextBox_meilleursGagnant.Enabled = false;
            richTextBox_meilleursGagnant.Font = new Font("Comic Sans MS", 11F);
            richTextBox_meilleursGagnant.Location = new Point(505, 108);
            richTextBox_meilleursGagnant.Name = "richTextBox_meilleursGagnant";
            richTextBox_meilleursGagnant.Size = new Size(283, 234);
            richTextBox_meilleursGagnant.TabIndex = 16;
            richTextBox_meilleursGagnant.Text = "";
            // 
            // button_J1
            // 
            button_J1.BackColor = Color.FromArgb(128, 128, 255);
            button_J1.Font = new Font("Comic Sans MS", 12F);
            button_J1.Location = new Point(168, 111);
            button_J1.Name = "button_J1";
            button_J1.Size = new Size(16, 15);
            button_J1.TabIndex = 17;
            button_J1.UseVisualStyleBackColor = false;
            button_J1.Click += button_J1_Click;
            // 
            // pictureBox_logo2
            // 
            pictureBox_logo2.Location = new Point(342, 184);
            pictureBox_logo2.Name = "pictureBox_logo2";
            pictureBox_logo2.Size = new Size(88, 80);
            pictureBox_logo2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_logo2.TabIndex = 18;
            pictureBox_logo2.TabStop = false;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // button_J4
            // 
            button_J4.BackColor = Color.Red;
            button_J4.Enabled = false;
            button_J4.Font = new Font("Comic Sans MS", 12F);
            button_J4.Location = new Point(168, 251);
            button_J4.Name = "button_J4";
            button_J4.Size = new Size(16, 15);
            button_J4.TabIndex = 19;
            button_J4.UseVisualStyleBackColor = false;
            button_J4.Click += button_J4_Click;
            // 
            // button_J3
            // 
            button_J3.BackColor = Color.Yellow;
            button_J3.Enabled = false;
            button_J3.Font = new Font("Comic Sans MS", 12F);
            button_J3.Location = new Point(168, 214);
            button_J3.Name = "button_J3";
            button_J3.Size = new Size(16, 15);
            button_J3.TabIndex = 20;
            button_J3.UseVisualStyleBackColor = false;
            button_J3.Click += button_J3_Click;
            // 
            // button_J2
            // 
            button_J2.BackColor = Color.Lime;
            button_J2.Font = new Font("Comic Sans MS", 12F);
            button_J2.Location = new Point(168, 148);
            button_J2.Name = "button_J2";
            button_J2.Size = new Size(16, 15);
            button_J2.TabIndex = 21;
            button_J2.UseVisualStyleBackColor = false;
            button_J2.Click += button3_Click;
            // 
            // textBox_J1
            // 
            textBox_J1.BackColor = Color.FromArgb(128, 128, 255);
            textBox_J1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_J1.ForeColor = SystemColors.ControlText;
            textBox_J1.Location = new Point(35, 111);
            textBox_J1.Name = "textBox_J1";
            textBox_J1.Size = new Size(128, 34);
            textBox_J1.TabIndex = 2;
            textBox_J1.Text = "J1";
            textBox_J1.KeyPress += textBox_J1_KeyPress;
            textBox_J1.Validating += textBox_J1_Validating;
            // 
            // label_MeilleurGagnant
            // 
            label_MeilleurGagnant.AutoSize = true;
            label_MeilleurGagnant.Font = new Font("Comic Sans MS", 14.25F);
            label_MeilleurGagnant.Location = new Point(563, 79);
            label_MeilleurGagnant.Name = "label_MeilleurGagnant";
            label_MeilleurGagnant.Size = new Size(168, 26);
            label_MeilleurGagnant.TabIndex = 22;
            label_MeilleurGagnant.Text = "Meilleur Gagnants";
            // 
            // menuStrip_Acceuil
            // 
            menuStrip_Acceuil.ImageScalingSize = new Size(20, 20);
            menuStrip_Acceuil.Items.AddRange(new ToolStripItem[] { Menu_Demarrer });
            menuStrip_Acceuil.Location = new Point(0, 0);
            menuStrip_Acceuil.Name = "menuStrip_Acceuil";
            menuStrip_Acceuil.Padding = new Padding(5, 2, 0, 2);
            menuStrip_Acceuil.Size = new Size(800, 24);
            menuStrip_Acceuil.TabIndex = 23;
            menuStrip_Acceuil.Text = "menuStrip1";
            // 
            // Menu_Demarrer
            // 
            Menu_Demarrer.DropDownItems.AddRange(new ToolStripItem[] { MenuItem_Demarrer, MenuItem_Quitter });
            Menu_Demarrer.Name = "Menu_Demarrer";
            Menu_Demarrer.ShortcutKeys = Keys.Control | Keys.D;
            Menu_Demarrer.Size = new Size(50, 20);
            Menu_Demarrer.Text = "Menu";
            // 
            // MenuItem_Demarrer
            // 
            MenuItem_Demarrer.Name = "MenuItem_Demarrer";
            MenuItem_Demarrer.ShortcutKeys = Keys.Control | Keys.D;
            MenuItem_Demarrer.Size = new Size(180, 22);
            MenuItem_Demarrer.Text = "Démarrer";
            MenuItem_Demarrer.Click += toolStripMenuItemDemarrer_Click;
            // 
            // MenuItem_Quitter
            // 
            MenuItem_Quitter.Name = "MenuItem_Quitter";
            MenuItem_Quitter.ShortcutKeys = Keys.Control | Keys.Q;
            MenuItem_Quitter.Size = new Size(180, 22);
            MenuItem_Quitter.Text = "Quitter";
            MenuItem_Quitter.Click += Menu_Quitter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_MeilleurGagnant);
            Controls.Add(button_J2);
            Controls.Add(button_J3);
            Controls.Add(button_J4);
            Controls.Add(pictureBox_logo2);
            Controls.Add(button_J1);
            Controls.Add(richTextBox_meilleursGagnant);
            Controls.Add(radioButton_200);
            Controls.Add(radioButton_300);
            Controls.Add(radioButton_150);
            Controls.Add(label_pointsGagner);
            Controls.Add(button_demarrer);
            Controls.Add(button_instruction);
            Controls.Add(button_quitter);
            Controls.Add(textBox_J4);
            Controls.Add(checkBox_J4);
            Controls.Add(textBox_J3);
            Controls.Add(checkBox_J3);
            Controls.Add(label_AjoutJoueur);
            Controls.Add(textBox_J2);
            Controls.Add(textBox_J1);
            Controls.Add(label_TitreAcceuil);
            Controls.Add(pictureBox_logo);
            Controls.Add(menuStrip_Acceuil);
            MainMenuStrip = menuStrip_Acceuil;
            Name = "Form1";
            Text = "Two-Dice Pig";
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            menuStrip_Acceuil.ResumeLayout(false);
            menuStrip_Acceuil.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_logo;
        private Label label_TitreAcceuil;
        private TextBox textBox_J2;
        private Label label_AjoutJoueur;
        private CheckBox checkBox_J3;
        private TextBox textBox_J3;
        private CheckBox checkBox_J4;
        private TextBox textBox_J4;
        private Button button_quitter;
        private Button button_instruction;
        private Button button_demarrer;
        private Label label_pointsGagner;
        private RadioButton radioButton_150;
        private RadioButton radioButton_300;
        private RadioButton radioButton_200;
        private RichTextBox richTextBox_meilleursGagnant;
        private Button button_J1;
        private PictureBox pictureBox_logo2;
        private ErrorProvider errorProvider;
        private Button button_J2;
        private Button button_J3;
        private Button button_J4;
        private ColorDialog colorDialog_J1;
        private ColorDialog colorDialog_J2;
        private ColorDialog colorDialog_J3;
        private ColorDialog colorDialog_J4;
        private TextBox textBox_J1;
        private Label label_MeilleurGagnant;
        private MenuStrip menuStrip_Acceuil;
        private ToolStripMenuItem Menu_Demarrer;
        private ToolStripMenuItem MenuItem_Demarrer;
        private ToolStripMenuItem MenuItem_Quitter;
    }
}
