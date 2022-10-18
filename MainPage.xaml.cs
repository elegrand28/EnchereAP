using APre.Modeles;

namespace APre;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Utilisateur {User.UtilisateurConnecté.Pseudo} a cliqué {count} time";
		else
			CounterBtn.Text = $"Utilisateur {User.UtilisateurConnecté.Pseudo} a cliqué {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

