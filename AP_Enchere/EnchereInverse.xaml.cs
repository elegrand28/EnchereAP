namespace AP_Enchere;

public partial class EnchereInverse : ContentPage
{
	public EnchereInverse()
	{
		InitializeComponent();
	}
    async void ClickRetour(object sender, EventArgs args)
    {
        await Navigation.PushModalAsync(new MainPage());

    }
}