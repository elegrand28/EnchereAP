using APre.VuesModeles;

namespace APre.Vues;

public partial class VuePageChoixEnchere : ContentPage

	
{
	PageChoixEnchereVueModele vueModele;
	public VuePageChoixEnchere()
	{
		InitializeComponent();
	}

    async void OnClick(object sender, EventArgs args)
    {
        await Navigation.PushModalAsync(new VueEnchereClassique());

    }
    async void OnClick2(object sender, EventArgs args)
    {
        await Navigation.PushModalAsync(new VueEnchereInverse());

    }
    async void OnClick3(object sender, EventArgs args)
    {
        await Navigation.PushModalAsync(new VueEnchereSurprise());

    }
}