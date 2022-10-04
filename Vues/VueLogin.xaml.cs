namespace APre.Vues;

public partial class VueLogin : ContentPage
{
	LoginVuesModeles vueModele;
	public VueLogin()
	{
		InitializeComponent();
		BindingContext = vueModele = new LoginVuesModeles();
	}
}