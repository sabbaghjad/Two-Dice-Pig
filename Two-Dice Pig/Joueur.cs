namespace Two_Dice_Pig
{
    internal class Joueur
    {
        private static List<Joueur> listGagnant = new List<Joueur>();

        

        private string _nomJoueur;

        public string nomJoueur
        {
            get { return _nomJoueur; }
            set { _nomJoueur = value; }
        }

        private Color _colorJoueur;

        public Color colorJoueur
        {
            get { return _colorJoueur; }
            set { _colorJoueur = value; }
        }

        private int _score;

        public int score
        {
            get { return _score; }
            set { _score = value; }
        }

        private double _ratio;

        public double ratio
        {
            get { return _ratio; }
            set { _ratio = value; }
        }

        private int _nbTours;

        public int nbTour
        {
            get { return _nbTours; }
            set { _nbTours = value; }
        }

        public Joueur()
        {
            _nomJoueur = null;
            _colorJoueur = new Color();
            _score = 0;
            _ratio = 0.0;
            _nbTours = 1;
        }

        public Joueur(string nomJoueur, Color couleur, int score, double ratio, int nbTours)
        {
            _nomJoueur = nomJoueur;
            _colorJoueur = couleur;
            _score = score;
            _ratio = ratio;
            _nbTours = nbTours;
        }
    }
}
