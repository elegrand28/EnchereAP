using AP_Enchere.VueModele;
using AP_Enchere;

namespace AP_Enchere.Vue;

public partial class encheretypeclassique : ContentPage
{
    encheretypeclassiquevuemodele vueModele;
    public encheretypeclassique()
    {
        InitializeComponent();
        BindingContext = vueModele = new encheretypeclassiquevuemodele();

    }
    async void ClickRetour(object sender, EventArgs args)
    {
        await Navigation.PushModalAsync(new MainPage());

    }
}