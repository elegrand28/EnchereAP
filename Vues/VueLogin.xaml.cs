using APre.Modeles;
using APre.Services;
using APre.VuesModeles;
namespace APre.Vues;

public partial class VueLogin : ContentPage
{
    LoginVueModele vueModele;
	
	public VueLogin()
	{
		InitializeComponent();
		BindingContext = vueModele = new LoginVueModele();
	}

	public async void ButtonLogin(object sender, EventArgs args)
	{
		
		var leUsername = Username.Text;
		var lePassword = Password.Text;

		if (Username.Text != null & Password.Text != null)
		{
			User leUser = await vueModele.GetUserByUsernameAndPass(leUsername, lePassword);
			if (leUser != null)
			{
				User.UtilisateurConnecté = leUser;
                await Navigation.PushModalAsync(new MainPage());

            } else
			{
				Username.Text = "impossible de se connecter";
			}
        }

		

		
		else 
		{
            Username.PlaceholderColor = Colors.Red;
			Password.PlaceholderColor = Colors.Red;
			

        }

        
		
		
	}

	
}