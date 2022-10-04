namespace AP_Enchere;

public partial class EnchereSurprise : ContentPage
{
	public EnchereSurprise()
	{
		InitializeComponent();
	}
    async void ClickRetour(object sender, EventArgs args)
    {
        await Navigation.PushModalAsync(new MainPage());

    }
}