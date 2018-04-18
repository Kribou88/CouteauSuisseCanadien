using System;
using System.Collections.Generic;
using System.Text;

namespace CouteauSuisseCanadien
{
    public class ElementUnite
    {
        private string intitulePiker;
        private string unite1;
        private string unite2;
        private double valeur1;
        private double valeur2;

        public string IntitulePiker { get => intitulePiker; set => intitulePiker = value; }
        public string Unite1 { get => unite1; set => unite1 = value; }
        public string Unite2 { get => unite2; set => unite2 = value; }
        public double Valeur1 { get => valeur1; set => valeur1 = value; }
        public double Valeur2 { get => valeur2; set => valeur2 = value; }

        public ElementUnite(string intitule , string unite1, string unite2, double valeur1, double valeur2)
        {
            this.intitulePiker = intitule;
            this.unite1 = unite1;
            this.unite2 = unite2;
            this.valeur1 = valeur1;
            this.valeur2 = valeur2;
        }
    }
}
