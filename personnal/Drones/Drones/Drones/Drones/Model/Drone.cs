using Drones.Helpers;

namespace Drones.Model
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    {
        private int _x;                                // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien
        private int _charge = 1000;                     // La charge actuelle de la batterie
        private string _name;                           // Un nom


        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }
        public int Charge { get { return _charge; } set { _charge = value; } }
        public string Name { get { return _name; } set { _name = value; } }

        public Drone(int x, int y, int charge, string name)
        {
            _x = x;
            _y = y;
            _charge = charge;
            _name = name;
        }


        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            _x += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            _y += RandomHelpers.random.Next(-2, 3);     // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            _charge--;                                  // Il a dépensé de l'énergie
        }

        public bool Evacuate(Rectangle zone)
        {
            throw new NotImplementedException();
        }

        public void FreeFlight()
        {
            throw new NotImplementedException();
        }

        public EvacuationState GetEvacuationState()
        {
            throw new NotImplementedException();
        }
    }
}
