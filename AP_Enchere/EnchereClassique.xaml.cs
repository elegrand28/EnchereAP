namespace AP_Enchere;

public partial class EnchereClassique : ContentPage
{
	public EnchereClassique()
	{
		InitializeComponent();
	}

    async void ClickRetour(object sender, EventArgs args)
    {
        await Navigation.PushModalAsync(new MainPage());

    }
}