using ApS2.Modele;
using ApS2.VueModele;

namespace ApS2.Vue;

public partial class VueEnchereEnCours : ContentPage
{
    PageChoixEnchereVuesModele vuesModele;
   
	public VueEnchereEnCours()
	{
		InitializeComponent();
        BindingContext = vuesModele =new PageChoixEnchereVuesModele();
	}
   
}