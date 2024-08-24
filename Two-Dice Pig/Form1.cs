namespace Two_Dice_Pig
{
    public partial class Form1 : Form
    {
        private string J3T;
        private string J4T;
        private Color J3C;
        private Color J4C;
        private const string CHOISIR_PTS = "Veuiller choisir un nombre de points.";
        private const string NOM_UNIQUE = "Les noms doivent etre uniques";
        private const string NOM_VIDE = "Le joueur doit avoir un nom";

        public Form1()
        {
            InitializeComponent();
            imageAuHarsard();


            if (File.Exists(Application.StartupPath + "/Partie.txt"))
            {
                StreamWriter ecriture = new StreamWriter(Application.StartupPath + "/Partie.txt", false);
                ecriture.Close();
            }

            if (File.Exists(Application.StartupPath + "/Gagnant.txt"))
            {
                StreamWriter ecriture = new StreamWriter(Application.StartupPath + "/Gagnant.txt", false);
                ecriture.Close();
            }
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox_J3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_J3.Checked)
            {
                textBox_J3.Enabled = true;
                button_J3.Enabled = true;
                checkBox_J4.Enabled = true;
            }
            else
            {
                textBox_J3.Enabled = false;
                button_J3.Enabled = false;
                checkBox_J4.Enabled = false;
                checkBox_J4.Checked = false;
            }

        }

        private void checkBox_J4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_J4.Checked)
            {
                textBox_J4.Enabled = true;
                button_J4.Enabled = true;
            }
            else
            {
                textBox_J4.Enabled = false;
                button_J4.Enabled = false;
            }

        }

        private void textBox_J1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_J1.Text))
            {
                errorProvider.SetError(textBox_J1, NOM_VIDE);
                e.Cancel = true;
            }
            else if (textBox_J1.Text == textBox_J2.Text || textBox_J1.Text == textBox_J3.Text || textBox_J1.Text == textBox_J4.Text)
            {
                errorProvider.SetError(textBox_J1, NOM_UNIQUE);
                e.Cancel = true;
            }
            else
            {
                errorProvider.Clear();
                e.Cancel = false;
            }
        }

        private void textBox_J2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_J2.Text))
            {
                errorProvider.SetError(textBox_J2, NOM_VIDE);
                e.Cancel = true;
            }
            else if (textBox_J2.Text == textBox_J1.Text || textBox_J2.Text == textBox_J3.Text || textBox_J2.Text == textBox_J4.Text)
            {
                errorProvider.SetError(textBox_J2, NOM_UNIQUE);
                e.Cancel = true;
            }
            else
            {
                errorProvider.Clear();
                e.Cancel = false;
            }
        }

        private void textBox_J3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_J3.Text))
            {
                errorProvider.SetError(textBox_J3, NOM_VIDE);
                e.Cancel = true;
            }
            else if (textBox_J3.Text == textBox_J1.Text || textBox_J3.Text == textBox_J2.Text || textBox_J3.Text == textBox_J4.Text)
            {
                errorProvider.SetError(textBox_J3, NOM_UNIQUE);
                e.Cancel = true;
            }
            else
            {
                errorProvider.Clear();
                e.Cancel = false;
            }
        }

        private void textBox_J4_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_J4.Text))
            {
                errorProvider.SetError(textBox_J4, NOM_VIDE);
                e.Cancel = true;
            }
            else if (textBox_J4.Text == textBox_J1.Text || textBox_J4.Text == textBox_J2.Text || textBox_J4.Text == textBox_J3.Text)
            {
                errorProvider.SetError(textBox_J4, NOM_UNIQUE);
                e.Cancel = true;
            }
            else
            {
                errorProvider.Clear();
                e.Cancel = false;
            }
        }

        private void keyPress(KeyPressEventArgs e)
        {
            char touche = e.KeyChar;

            if (!char.IsLetterOrDigit(touche) && touche != '-' && touche != '_' && !char.IsControl(touche))
            {
                e.Handled = true;
            }
        }

        private void textBox_J1_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(e);
        }

        private void textBox_J2_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(e);
        }

        private void textBox_J3_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(e);
        }

        private void textBox_J4_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(e);
        }

        private void button_instruction_Click(object sender, EventArgs e)
        {
            Instruction instruction = new Instruction();
            instruction.ShowDialog();
        }

        private void imageAuHarsard()
        {
            string chemin = Application.StartupPath + "/De";
            string[] fichierImage = Directory.GetFiles(chemin, "*.png");

            if (fichierImage.Length >= 2)
            {
                Random random = new Random();
                int index1 = random.Next(0, fichierImage.Length);
                int index2;

                do
                {
                    index2 = random.Next(0, fichierImage.Length);
                } while (index2 == index1);

                pictureBox_logo.Image = Image.FromFile(fichierImage[index1]);
                pictureBox_logo2.Image = Image.FromFile(fichierImage[index2]);
            }

        }

        private void button_J1_Click(object sender, EventArgs e)
        {

            if (colorDialog_J1.ShowDialog() == DialogResult.OK)
            {
                textBox_J1.BackColor = colorDialog_J1.Color;
                button_J1.BackColor = colorDialog_J1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (colorDialog_J2.ShowDialog() == DialogResult.OK)
            {
                textBox_J2.BackColor = colorDialog_J2.Color;
                button_J2.BackColor = colorDialog_J2.Color;
            }
        }

        private void button_J3_Click(object sender, EventArgs e)
        {

            if (colorDialog_J3.ShowDialog() == DialogResult.OK)
            {
                textBox_J3.BackColor = colorDialog_J3.Color;
                button_J3.BackColor = colorDialog_J3.Color;
            }
        }

        private void button_J4_Click(object sender, EventArgs e)
        {

            if (colorDialog_J4.ShowDialog() == DialogResult.OK)
            {
                textBox_J4.BackColor = colorDialog_J4.Color;
                button_J4.BackColor = colorDialog_J4.Color;
            }
        }


        private void button_demarrer_Click(object sender, EventArgs e)
        {

            if (radioButton_150.Checked || radioButton_200.Checked || radioButton_300.Checked)
            {

                if (checkBox_J3.Checked)
                {
                    J3T = textBox_J3.Text;
                    J3C = textBox_J3.BackColor;

                }
                if (checkBox_J4.Checked)
                {
                    J4T = textBox_J4.Text;
                    J4C = textBox_J4.BackColor;

                }

                EcranDeJeu ecranDeJeu = new EcranDeJeu(textBox_J1.Text, textBox_J2.Text, J3T, J4T, textBox_J1.BackColor, textBox_J2.BackColor, J3C, J4C, radioButtonSelectionne(), nombreJoueur());
                ecranDeJeu.ShowDialog();

                meilleurGagnant();

            }
            else
            {
                MessageBox.Show(CHOISIR_PTS);
            }

        }

        private int radioButtonSelectionne()
        {
            if (radioButton_150.Checked)
            {
                return 150;  //Changer la valeur ici pour tester sans devoir faire une partie complete
            }
            else if (radioButton_200.Checked)
            {
                return 200;
            }
            else if (radioButton_300.Checked)
            {
                return 300;
            }
            else
            {
                return 0;
            }
        }

        private int nombreJoueur()
        {
            int nombreJoueur;

            if (checkBox_J3.Checked && checkBox_J4.Checked)
            {
                nombreJoueur = 4;
            }
            else if (checkBox_J3.Checked || checkBox_J4.Checked)
            {
                nombreJoueur = 3;
            }
            else
            {
                nombreJoueur = 2;
            }


            return nombreJoueur;
        }

        private void meilleurGagnant()
        {
            string ligne;
            int position = 1;

            if (File.Exists(Application.StartupPath + "/Gagnant.txt"))
            {
                richTextBox_meilleursGagnant.Clear();
                StreamReader lecture = new StreamReader(Application.StartupPath + "/Gagnant.txt");

                while ((ligne = lecture.ReadLine()) != null)
                {
                    string[] donnees = ligne.Split(';');

                    richTextBox_meilleursGagnant.Text += position++ + " - " + donnees[0] + " - " + donnees[1] + " pts - " + donnees[2] + " tours - " + donnees[3] + "pts/tours" + "\r\n";
                }

                lecture.Close();
            }
        }


        private void toolStripMenuItemDemarrer_Click(object sender, EventArgs e)
        {
            if (radioButton_150.Checked || radioButton_200.Checked || radioButton_300.Checked)
            {

                if (checkBox_J3.Checked)
                {
                    J3T = textBox_J3.Text;
                    J3C = textBox_J3.BackColor;

                }
                if (checkBox_J4.Checked)
                {
                    J4T = textBox_J4.Text;
                    J4C = textBox_J4.BackColor;

                }

                EcranDeJeu ecranDeJeu = new EcranDeJeu(textBox_J1.Text, textBox_J2.Text, J3T, J4T, textBox_J1.BackColor, textBox_J2.BackColor, J3C, J4C, radioButtonSelectionne(), nombreJoueur());
                ecranDeJeu.ShowDialog();

                meilleurGagnant();

            }
            else
            {
                MessageBox.Show(CHOISIR_PTS);
            }
        }

        private void Menu_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

