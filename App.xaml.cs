using APre.Vues;

namespace APre;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new VueLogin();
	}
}
