using ApS2.VueModele;
using ApS2.Services;
using ApS2.Modele;

namespace ApS2.Vue;

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
                await Navigation.PushModalAsync(new VuePageChoixEnchere());

            }
            else
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