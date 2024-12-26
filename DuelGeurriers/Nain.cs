using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DuelGeurriers.Guerrier;


namespace DuelGeurriers
{
    internal class Nain : Guerrier
    {
        // attribut :
        private bool _armureLourde;


        // constructeur 
        public Nain (string nom, int pointDeVie, int nbAttaque, bool armureLourde): base(nom, pointDeVie, nbAttaque)
        {
            armureLourde = true;
        }

        // accésseur 
        public bool armureLourde { get { return _armureLourde; } set { _armureLourde = value; } }

        //methode 
        public override void  SubirDegat()
        {
            Random deLancer = new Random();
            //if(armureLourde != false)
            {
                int degatSubit = deLancer.Next(1, 7);
                PointDeVie = PointDeVie - (degatSubit/2);
                AfficherInfos();
            }
                
            
           }

    }
}
