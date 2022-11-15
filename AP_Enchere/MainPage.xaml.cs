using AP_Enchere.Vue;


namespace AP_Enchere;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    async void OnClick(object sender, EventArgs args)
    {
        await Navigation.PushModalAsync(new encheretypeclassique());

    }
    async void OnClick2(object sender, EventArgs args)
    {
        await Navigation.PushModalAsync(new EnchereInverse());

    }
    async void OnClick3(object sender, EventArgs args)
    {
        await Navigation.PushModalAsync(new EnchereSurprise());

    }
}

