using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DuelGeurriers
{
    internal class Guerrier
    {

        //attribut: 
        private string _nom;
        private int _pointDeVie;
        private int _nbAttaque;


        //accèsseurs

        public string Nom { get { return _nom; } set { _nom = value; } }
        public int PointDeVie { get { return _pointDeVie; } set { _pointDeVie = value; } }

        public int NbAttaque { get { return _nbAttaque; } set { _nbAttaque = value; } }



        //constructeur 

        public Guerrier(string nom, int pointDeVie, int nbAttaque)
        {
            _nom = nom;
            _pointDeVie = pointDeVie;
            _nbAttaque = nbAttaque;



        }

        //methode 

        public void AfficherInfos()
        {
            Console.WriteLine($"Nom : {_nom} ; Pv =({PointDeVie}) ; nombres d'attaques = {NbAttaque}");
        }

        public virtual void Attaquer()
        {
            Random deLancer = new Random();
            int degatSubit = deLancer.Next(1, 7);
            Console.WriteLine($"L'attaque occasionne  {degatSubit} degat");
            AfficherInfos();

        }

        public virtual void SubirDegat()
        {


            Random deLancer = new Random();
            int degatSubit = deLancer.Next(1, 7);
            PointDeVie = PointDeVie - degatSubit;
            Console.WriteLine($"L'attaque a occasionne - {degatSubit}  sur l'adverssaire il lui reste {PointDeVie}");
            AfficherInfos();

        }


    }
}
