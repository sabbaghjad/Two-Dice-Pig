using System.Security.Cryptography;
using static System.Windows.Forms.LinkLabel;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Two_Dice_Pig
{
    public partial class EcranDeJeu : Form
    {
        private Partie maPartie;
        private string nom_J1;
        private string nom_J2;
        private string nom_J3;
        private string nom_J4;
        private Color color_J1;
        private Color color_J2;
        private Color color_J3;
        private Color color_J4;
        private int nbPointsPourGagner;
        private int nbJoueur;
        Random aleatoire;
        Thread changementDes;
        private bool arreterChangementDes = false;
        private int valeurDe1, valeurDe2;
        private int joueurActuel;
        List<TextBox> listeTextBox = new List<TextBox>();
        private int nbPointDuTour = 0;
        private static List<Joueur> listGagnant = new List<Joueur>();
        private const string NOM_UNIQUE = "Les noms doivent etre uniques";
        private const string NOM_VIDE = "Le joueur doit avoir un nom";
        private string tempJ1, tempJ2, tempJ3, tempJ4;

        public EcranDeJeu(string nom_J1, string nom_J2, string nom_J3, string nom_J4, Color color_J1, Color color_J2, Color color_J3, Color color_J4, int nbPoints, int nbJoueur)
        {
            InitializeComponent();
            this.nom_J1 = nom_J1;
            this.nom_J2 = nom_J2;
            this.nom_J3 = nom_J3;
            this.nom_J4 = nom_J4;
            this.color_J1 = color_J1;
            this.color_J2 = color_J2;
            this.color_J3 = color_J3;
            this.color_J4 = color_J4;
            this.nbPointsPourGagner = nbPoints;
            this.nbJoueur = nbJoueur;

            label_J1.Text = nom_J1;
            label_J2.Text = nom_J2;
            label_J3.Text = nom_J3;
            label_J4.Text = nom_J4;

            label_J1.ForeColor = color_J1;
            label_J2.ForeColor = color_J2;
            label_J3.ForeColor = color_J3;
            label_J4.ForeColor = color_J4;

            maPartie = new Partie
            {
                nombreJoueurs = nbJoueur,
                listJoueurs = new List<Joueur>
                    {
                        new Joueur { nomJoueur = nom_J1, colorJoueur = color_J1, score = 0, nbTour = 1 },
                        new Joueur { nomJoueur = nom_J2, colorJoueur = color_J2, score = 0, nbTour = 1 },
                        new Joueur { nomJoueur = nom_J3, colorJoueur = color_J3, score = 0, nbTour = 1 },
                        new Joueur { nomJoueur = nom_J4, colorJoueur = color_J4, score = 0, nbTour = 1 }
                    },
                pointsPourGagner = nbPoints,
                tours = 1
            };


            Partie.ajoutPartie(maPartie);

            aleatoire = new Random();

            textBox_PointPourGagner.Text = nbPoints.ToString();

            if (Partie.listPartie.Count > 0)
            {
                AjusterDisposition(Partie.listPartie[Partie.listPartie.Count - 1].nombreJoueurs);
            }

            joueurActuel = 0;



            if (maPartie != null)
            {
                listeTextBox.Add(textBox_ScoreJ1);
                listeTextBox.Add(textBox_ScoreJ2);
                toolStripTextBox_J1.Text = nom_J1;
                toolStripTextBox_J2.Text = nom_J2;
                tempJ1 = nom_J1;
                tempJ2 = nom_J2;

                if (maPartie.nombreJoueurs >= 3)
                {
                    listeTextBox.Add(textBox_ScoreJ3);
                    toolStripTextBox_J3.Visible = true;
                    toolStripTextBox_J3.Text = nom_J3;
                    tempJ3 = nom_J3;
                }

                if (maPartie.nombreJoueurs == 4)
                {
                    listeTextBox.Add(textBox_ScoreJ4);
                    toolStripTextBox_J4.Visible = true;
                    toolStripTextBox_J4.Text = nom_J4;
                    tempJ4 = nom_J4;
                }

            }





            listeTextBox[joueurActuel].BackColor = Color.Yellow;
        }


        private void AjusterDisposition(int nombreJoueurs)
        {
            switch (nombreJoueurs)
            {
                case 2:
                    label_J1.Location = new Point(381, 24);
                    label_J2.Location = new Point(333, 250);
                    label_J3.Visible = false;
                    label_J4.Visible = false;

                    textBox_ScoreJ1.Location = new Point(381, 66);
                    textBox_ScoreJ2.Location = new Point(330, 279);
                    textBox_ScoreJ3.Visible = false;
                    textBox_ScoreJ4.Visible = false;
                    break;

                case 3:
                    label_J1.Location = new Point(381, 24);
                    label_J2.Location = new Point(552, 206);
                    label_J3.Location = new Point(116, 206);
                    label_J4.Visible = false;

                    textBox_ScoreJ1.Location = new Point(381, 66);
                    textBox_ScoreJ2.Location = new Point(552, 235);
                    textBox_ScoreJ3.Location = new Point(116, 235);
                    textBox_ScoreJ4.Visible = false;
                    break;


                default:
                    label_J1.Location = new Point(381, 24);
                    label_J2.Location = new Point(552, 134);
                    label_J3.Location = new Point(333, 250);
                    label_J4.Location = new Point(102, 134);

                    textBox_ScoreJ1.Location = new Point(381, 66);
                    textBox_ScoreJ2.Location = new Point(552, 163);
                    textBox_ScoreJ3.Location = new Point(333, 279);
                    textBox_ScoreJ4.Location = new Point(102, 163);

                    label_J3.Visible = true;
                    label_J4.Visible = true;
                    textBox_ScoreJ3.Visible = true;
                    textBox_ScoreJ4.Visible = true;
                    break;
            }
        }



        private void button_lancer_Click(object sender, EventArgs e)
        {
            SoundPlayer lecteur = new SoundPlayer();
            lecteur.SoundLocation = Application.StartupPath + "/lancer.wav";
            lecteur.Play();
            button_lancer.Enabled = false;
            button_PasserTour.Enabled = false;
            button_Stop.Enabled = true;
            changementDes = new Thread(t =>
            {
                try
                {
                    while (changementDes.IsAlive)
                    {
                        valeurDe1 = aleatoire.Next(1, 7);
                        valeurDe2 = aleatoire.Next(1, 7);

                        afficheDe(valeurDe1, pictureBox_De1);
                        afficheDe(valeurDe2, pictureBox_De2);

                        Thread.Sleep(50);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erreur dans le thread : {ex.Message}");
                }
            })
            { IsBackground = true };

            changementDes.Start();
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {

            if (changementDes != null)
            {
                button_lancer.Enabled = true;
                button_PasserTour.Enabled = true;
                button_Stop.Enabled = false;
                arreterChangementDes = true;

                changementDes.Interrupt();

                int valeurDe1 = valeurDes(pictureBox_De1);
                int valeurDe2 = valeurDes(pictureBox_De2);

                int pointDuTour = calculerPoints(valeurDe1, valeurDe2);

                MettreAJourScores();
            }
        }
        private void afficheDe(int valeurDe, PictureBox pictureBox)
        {
            string cheminImage = Application.StartupPath + $"/ThreadDes/{valeurDe}.png";
            pictureBox.Image = Image.FromFile(cheminImage);
            pictureBox.Tag = valeurDe;
        }

        private int valeurDes(PictureBox pictureBox)
        {
            if (pictureBox.Tag != null && int.TryParse(pictureBox.Tag.ToString(), out int valeurDe))
            {
                return valeurDe;
            }

            return -1;
        }

        private int calculerPoints(int valeurDe1, int valeurDe2)
        {
            int nbPoint = 0;



            if (valeurDe1 == valeurDe2 && valeurDe1 == 1)
            {
                SoundPlayer lecteur = new SoundPlayer();
                lecteur.SoundLocation = Application.StartupPath + "/AvoirDouble1.wav";
                lecteur.Play();

                nbPoint = 0;
                nbPointDuTour = 0;
                maPartie.listJoueurs[joueurActuel].score = 0;
                listeTextBox[joueurActuel].BackColor = Color.White;
                joueurActuel = (joueurActuel + 1) % maPartie.nombreJoueurs;
                if (joueurActuel == 0)
                {
                    maPartie.tours++;
                }
                maPartie.listJoueurs[joueurActuel].nbTour++;
                listeTextBox[joueurActuel].BackColor = Color.Yellow;

            }
            else if (valeurDe1 != valeurDe2 && ((valeurDe1 == 1) || (valeurDe2 == 1)))
            {
                nbPoint = 0;
                maPartie.listJoueurs[joueurActuel].score -= nbPointDuTour;
                nbPointDuTour = 0;
                listeTextBox[joueurActuel].BackColor = Color.White;
                joueurActuel = (joueurActuel + 1) % maPartie.nombreJoueurs;
                if (joueurActuel == 0)
                {
                    maPartie.tours++;
                }
                maPartie.listJoueurs[joueurActuel].nbTour++;
                listeTextBox[joueurActuel].BackColor = Color.Yellow;

            }
            else
            {
                nbPoint += valeurDe1 + valeurDe2;
                nbPointDuTour += nbPoint;
                maPartie.listJoueurs[joueurActuel].score += nbPoint;

                if (maPartie.listJoueurs[joueurActuel].score >= maPartie.pointsPourGagner)
                {
                    SoundPlayer lecteur = new SoundPlayer();
                    lecteur.SoundLocation = Application.StartupPath + "/FinDePartie.wav";
                    lecteur.Play();

                    maPartie.listJoueurs[joueurActuel].score = maPartie.pointsPourGagner;
                    button_lancer.Enabled = false;
                    button_Stop.Enabled = false;
                    button_PasserTour.Enabled = false;
                    button_Retour.Enabled = true;
                    button_NouvellePartie.Enabled = true;
                    Menu2_NouvellePartie.Enabled = true;
                    Menu2_Retour.Enabled = true;
                    maPartie.listJoueurs[joueurActuel].ratio = maPartie.pointsPourGagner / maPartie.listJoueurs[joueurActuel].nbTour;
                    listGagnant.Add(maPartie.listJoueurs[joueurActuel]);
                    SauvegarderListeGagnants();
                    SauvegardePartie();

                }
            }

            MettreAJourScores();

            return nbPoint;
        }

        private void button_PasserTour_Click(object sender, EventArgs e)
        {
            listeTextBox[joueurActuel].BackColor = Color.White;
            joueurActuel = (joueurActuel + 1) % maPartie.nombreJoueurs;
            listeTextBox[joueurActuel].BackColor = Color.Yellow;
            nbPointDuTour = 0;
            maPartie.listJoueurs[joueurActuel].nbTour++;

            if (joueurActuel == 0)
            {
                maPartie.tours++;
            }

            MettreAJourScores();
        }

        private void MettreAJourScores()
        {
            if (maPartie != null)
            {
                textBox_ScoreJ1.Text = maPartie.listJoueurs[0].score.ToString();
                textBox_ScoreJ2.Text = maPartie.listJoueurs[1].score.ToString();

                if (maPartie.nombreJoueurs >= 3)
                {
                    textBox_ScoreJ3.Text = maPartie.listJoueurs[2].score.ToString();
                }

                if (maPartie.nombreJoueurs == 4)
                {
                    textBox_ScoreJ4.Text = maPartie.listJoueurs[3].score.ToString();
                }
            }
        }


        private void SauvegardePartie()
        {
            string ligne = "";

            if (maPartie != null)
            {
                StringBuilder lineBuilder = new StringBuilder();

                lineBuilder.Append($"{maPartie.idPartie};{maPartie.nombreJoueurs}");

                for (int i = 0; i < maPartie.nombreJoueurs; i++)
                {
                    lineBuilder.Append($";{maPartie.listJoueurs[i].nomJoueur}");
                }

                lineBuilder.Append($";{maPartie.pointsPourGagner};{maPartie.tours}");

                ligne = lineBuilder.ToString();
            }

            if (File.Exists(Application.StartupPath + "/Partie.txt"))
            {
                StreamWriter ecriture = new StreamWriter(Application.StartupPath + "/Partie.txt", true);

                ecriture.WriteLine(ligne);
                ecriture.Close();
            }
        }

        private void button_Retour_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button_NouvellePartie_Click(object sender, EventArgs e)
        {


            textBox_ScoreJ1.Clear();
            textBox_ScoreJ2.Clear();
            textBox_ScoreJ3.Clear();
            textBox_ScoreJ4.Clear();

            button_PasserTour.Enabled = true;
            button_lancer.Enabled = true;
            button_Retour.Enabled = false;
            button_NouvellePartie.Enabled = false;
            Menu2_Retour.Enabled = false;
            Menu2_NouvellePartie.Enabled = false;


            joueurActuel = 0;

            foreach (var textBox in listeTextBox)
            {
                textBox.BackColor = Color.White;
            }

            listeTextBox[joueurActuel].BackColor = Color.Yellow;

            nbPointDuTour = 0;

            maPartie = new Partie
            {
                nombreJoueurs = nbJoueur,
                listJoueurs = new List<Joueur>
                    {
                        new Joueur { nomJoueur = nom_J1, colorJoueur = color_J1, score = 0, nbTour = 1 },
                        new Joueur { nomJoueur = nom_J2, colorJoueur = color_J2, score = 0, nbTour = 1 },
                        new Joueur { nomJoueur = nom_J3, colorJoueur = color_J3, score = 0, nbTour = 1 },
                        new Joueur { nomJoueur = nom_J4, colorJoueur = color_J4, score = 0, nbTour = 1 }
                    },
                pointsPourGagner = nbPointsPourGagner,
                tours = 1
            };


            Partie.ajoutPartie(maPartie);


        }
        public void SauvegarderListeGagnants()
        {
            listGagnant = listGagnant.OrderByDescending(joueur => joueur.ratio).ToList();

            if (File.Exists(Application.StartupPath + "/Gagnant.txt"))
            {
                StreamWriter ecriture = new StreamWriter(Application.StartupPath + "/Gagnant.txt", false);

                foreach (var joueur in listGagnant)
                {
                    ecriture.WriteLine($"{joueur.nomJoueur};{joueur.score};{joueur.nbTour};{joueur.ratio}");
                }

                ecriture.Close();
            }

        }

        private void Menu2_NouvellePartie_Click(object sender, EventArgs e)
        {
            textBox_ScoreJ1.Clear();
            textBox_ScoreJ2.Clear();
            textBox_ScoreJ3.Clear();
            textBox_ScoreJ4.Clear();

            button_PasserTour.Enabled = true;
            button_lancer.Enabled = true;
            button_Retour.Enabled = false;
            button_NouvellePartie.Enabled = false;
            Menu2_Retour.Enabled = false;
            Menu2_NouvellePartie.Enabled = false;


            joueurActuel = 0;

            foreach (var textBox in listeTextBox)
            {
                textBox.BackColor = Color.White;
            }

            listeTextBox[joueurActuel].BackColor = Color.Yellow;

            nbPointDuTour = 0;

            maPartie = new Partie
            {
                nombreJoueurs = nbJoueur,
                listJoueurs = new List<Joueur>
                    {
                        new Joueur { nomJoueur = nom_J1, colorJoueur = color_J1, score = 0, nbTour = 1 },
                        new Joueur { nomJoueur = nom_J2, colorJoueur = color_J2, score = 0, nbTour = 1 },
                        new Joueur { nomJoueur = nom_J3, colorJoueur = color_J3, score = 0, nbTour = 1 },
                        new Joueur { nomJoueur = nom_J4, colorJoueur = color_J4, score = 0, nbTour = 1 }
                    },
                pointsPourGagner = nbPointsPourGagner,
                tours = 1
            };

            Partie.ajoutPartie(maPartie);

        }

        private void Menu2_Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripTextBox_J1_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(toolStripTextBox_J1.Text))
            {
                toolStripTextBox_J1.Text = tempJ1;
            }
            else if (toolStripTextBox_J1.Text == toolStripTextBox_J2.Text || toolStripTextBox_J1.Text == toolStripTextBox_J3.Text
                     || toolStripTextBox_J1.Text == toolStripTextBox_J4.Text)
            {
                toolStripTextBox_J1.Text = tempJ1;
                toolStripTextBox_J2.Text = tempJ2;
                toolStripTextBox_J3.Text = tempJ3;
                toolStripTextBox_J4.Text = tempJ4;
            }

            maPartie.listJoueurs[0].nomJoueur = toolStripTextBox_J1.Text;
            label_J1.Text = toolStripTextBox_J1.Text;
        }

        private void toolStripTextBox_J2_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(toolStripTextBox_J2.Text))
            {
                toolStripTextBox_J2.Text = tempJ2;
            }
            else if (toolStripTextBox_J1.Text == toolStripTextBox_J2.Text || toolStripTextBox_J2.Text == toolStripTextBox_J3.Text
                     || toolStripTextBox_J2.Text == toolStripTextBox_J4.Text)
            {
                toolStripTextBox_J1.Text = tempJ1;
                toolStripTextBox_J2.Text = tempJ2;
                toolStripTextBox_J3.Text = tempJ3;
                toolStripTextBox_J4.Text = tempJ4;
            }

            maPartie.listJoueurs[1].nomJoueur = toolStripTextBox_J2.Text;
            label_J2.Text = toolStripTextBox_J2.Text;
        }

        private void toolStripTextBox_J3_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(toolStripTextBox_J3.Text))
            {
                toolStripTextBox_J3.Text = tempJ3;
            }
            else if (toolStripTextBox_J3.Text == toolStripTextBox_J1.Text || toolStripTextBox_J3.Text == toolStripTextBox_J2.Text
                     || toolStripTextBox_J3.Text == toolStripTextBox_J4.Text)
            {
                toolStripTextBox_J1.Text = tempJ1;
                toolStripTextBox_J2.Text = tempJ2;
                toolStripTextBox_J3.Text = tempJ3;
                toolStripTextBox_J4.Text = tempJ4;
            }

            maPartie.listJoueurs[2].nomJoueur = toolStripTextBox_J3.Text;
            label_J3.Text = toolStripTextBox_J3.Text;
        }

        private void toolStripTextBox_J4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(toolStripTextBox_J4.Text))
            {
                toolStripTextBox_J4.Text = tempJ4;
            }
            else if (toolStripTextBox_J4.Text == toolStripTextBox_J1.Text || toolStripTextBox_J4.Text == toolStripTextBox_J2.Text
                     || toolStripTextBox_J4.Text == toolStripTextBox_J3.Text)
            {
                toolStripTextBox_J1.Text = tempJ1;
                toolStripTextBox_J2.Text = tempJ2;
                toolStripTextBox_J3.Text = tempJ3;
                toolStripTextBox_J4.Text = tempJ4;
            }

            maPartie.listJoueurs[3].nomJoueur = toolStripTextBox_J4.Text;
            label_J4.Text = toolStripTextBox_J4.Text;
        }

    }


}
