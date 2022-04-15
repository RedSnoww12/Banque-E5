using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Modele
{
    class CompteEpargne : Compte
    {

        private double taux;

        public CompteEpargne(int n, Client c, double unTaux) : base(n, c)
        {
            Taux = unTaux;

        }

        public void setTaux(double value)
        {


            if (value > 0)
            {
                this.Taux = value;

            }

            else
            {
                throw (new Exception("Interdit"));

            }

        }

        public override void debiter(double mont)
        {
            if (solde - mont < 0)
            {
                throw (new Exception("Débit interdit"));
            }
            else
            {
                solde = solde - mont;
            }
        }

        public override string Description
        {
            get => base.Description + " taux : " + Taux;
        }
        public double Taux { get => taux; set => taux = value; }
    }
}
