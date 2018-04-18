using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CouteauSuisseCanadien.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TTCPage : ContentPage
	{
        const double TauxTPS = 5;
        const double TauxTVQ = 9.975;
        double TPS;
        double TVQ;

        public TTCPage ()
		{
			InitializeComponent ();
		}

        void entryPrixHTChanged()
        {
            double prixHT;
            double tauxPourboire = 0;
            double pourboire;
            if (double.TryParse(entryPrixHT.Text, out prixHT))
            {
                TPS = (prixHT * TauxTPS / 100);
                labelTPS.Text = TPS.ToString("f2");
                
                TVQ = prixHT * TauxTVQ / 100;
                labelTVQ.Text = TVQ.ToString("f2");

                labelPrixTTC.Text = (prixHT + TVQ + TPS).ToString("f2");

                
                if (!string.IsNullOrEmpty(entryTauxPourboire.Text) && double.TryParse(entryTauxPourboire.Text, out tauxPourboire))
                {
                    pourboire = prixHT * tauxPourboire / 100;
                    labelPourboire.Text = pourboire.ToString("f2");

                }
                

            }
        }

        void TauxPourboireChanged()
        {
            double tauxPourboire;
            double prixHT;
            if (!string.IsNullOrEmpty(entryPrixHT.Text) && !string.IsNullOrEmpty(entryTauxPourboire.Text) && double.TryParse(entryTauxPourboire.Text,out tauxPourboire) && double.TryParse(entryPrixHT.Text, out prixHT))
            {
                labelPourboire.Text = (prixHT * tauxPourboire / 100).ToString("f2");
            }
        }
    }
}