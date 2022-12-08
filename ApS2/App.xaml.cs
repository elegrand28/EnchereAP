using ApS2.Vue;

namespace ApS2;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new VueLogin();
	}
}
