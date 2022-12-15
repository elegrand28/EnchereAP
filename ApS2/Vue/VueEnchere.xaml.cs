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
   


}