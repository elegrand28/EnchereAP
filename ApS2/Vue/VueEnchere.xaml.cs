using ApS2.Modele;
using ApS2.VueModele;
using System.Collections.ObjectModel;

namespace ApS2.Vue;

public partial class VueEnchere : ContentPage
{
	VueModeleEnchere vueModele;
    Enchere currentEnchere;

    public VueEnchere(Enchere laenchere)
	{
		InitializeComponent();
		
		BindingContext= vueModele = new VueModeleEnchere(laenchere);
	}
    private async void Bouton(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        currentEnchere = (Enchere)e.CurrentSelection.FirstOrDefault();
        string result = await DisplayPromptAsync("Enchère", "Donner votre prix");

        float Leresult = Convert.ToInt32(result);
        vueModele.PostEnchereClassique(Leresult, currentEnchere);
    }


}