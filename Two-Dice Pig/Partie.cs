namespace Two_Dice_Pig
{
    internal class Partie
    {
        private static List<Partie> _listPartie = new List<Partie>();
        private static int _nextId = 1;


        public static List<Partie> listPartie
        {
            get { return _listPartie; }
        }

        private int _idPartie;
        public int idPartie
        {
            get { return _idPartie; }
            set { _idPartie = value; }
        }

        private int _nombreJoueurs;

        public int nombreJoueurs
        {
            get { return _nombreJoueurs; }
            set { _nombreJoueurs = value; }
        }

        private List<Joueur> _listJoueurs;

        public List<Joueur> listJoueurs
        {
            get { return _listJoueurs; }
            set { _listJoueurs = value; }
        }

        private int _pointsPourGagner;

        public int pointsPourGagner
        {
            get { return _pointsPourGagner; }
            set { _pointsPourGagner = value; }
        }

        private int _tours;

        public int tours
        {
            get { return _tours; }
            set { _tours = value; }
        }

        
        public Partie()
        {
            _idPartie = _nextId++;
            _nombreJoueurs = 0;
            _listJoueurs = new List<Joueur>();
            _pointsPourGagner = 0;
            _tours = 1;
        }

        public Partie(int nombreJoueurs, List<Joueur> listjoueurs, int pointsPourGagner, int tours)
        { 
            _idPartie = _nextId++ ;
            _nombreJoueurs = nombreJoueurs;
            _listJoueurs = listjoueurs;
            _pointsPourGagner = pointsPourGagner;
            _tours = tours;
        }

        public static void ajoutPartie(Partie partie)
        {
            _listPartie.Add(partie);
        }


    }
}
