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
	public partial class ConversionPage : ContentPage
	{
        private double valeur1;
        private double valeur2;
        private double valeurTemp;
        private List<ElementUnite> listeElement = new List<ElementUnite>();

		public ConversionPage ()
		{
			InitializeComponent ();
            init();
		}

        public void init()
        {
            listeElement.Add(new ElementUnite("Pied <-> Mètre", "Pieds", "Mètre", 1, 0.3048));
            listeElement.Add(new ElementUnite("Pouce <-> Cm", "Pouce", "Cm", 1, 2.54));
            listeElement.Add(new ElementUnite("Acre <-> Hectare", "Acre", "Hectare", 1, 0.4));
            listeElement.Add(new ElementUnite("Pied² <-> Mètre²", "Pieds²", "Mètre²", 100, 9.29));
            listeElement.Add(new ElementUnite("Once <-> Gramme", "Once", "Gramme", 1, 28.24));
            listeElement.Add(new ElementUnite("Livre <-> Gramme", "Livre", "Gramme", 1, 454));
            listeElement.Add(new ElementUnite("°C <-> °F", "°C", "°F", 20, 68));
            pickerMesure.ItemsSource = listeElement;
        }

        private void pickerMesure_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker mesure = sender as Picker;


            labelUnite1.Text = listeElement.ElementAt(mesure.SelectedIndex).Unite1.ToString();
            labelUnite2.Text = listeElement.ElementAt(mesure.SelectedIndex).Unite2.ToString();
            valeur1 =  listeElement.ElementAt(mesure.SelectedIndex).Valeur1;
            valeur2 = listeElement.ElementAt(mesure.SelectedIndex).Valeur2;
        }

        private void ChangeValue(object sender, EventArgs e)
        {
            try
            {
                double valeur = double.Parse(entryValue.Text);
                double valeurConvertie = valeur * valeur2 / valeur1;

                labelValue.Text = valeurConvertie.ToString();
            }
            catch
            {
            }
        }
    }
}