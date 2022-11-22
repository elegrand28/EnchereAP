using ApS2.VueModele;

namespace ApS2.Vue;

public partial class VuePageChoixEnchere : ContentPage
{
    PageChoixEnchereVuesModele vueModele;
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