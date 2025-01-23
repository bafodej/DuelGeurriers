using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DuelGeurriers.Guerrier;

namespace DuelGeurriers
{
    internal class Elfe : Guerrier
    {
        public Elfe(string nom, int pointDeVie, int nbAttaque) : base(nom, pointDeVie, nbAttaque)
        {
            
        }

        public override void Attaquer()
        {
            Random deLancer = new Random();
            int degatSubit = deLancer.Next(0, 7) + 1;
            AfficherInfos();
            


        }
    }
}
