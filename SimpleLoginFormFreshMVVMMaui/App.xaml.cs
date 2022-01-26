using FreshMvvm.Maui;

namespace SimpleLoginFormFreshMVVMMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var mainPage = FreshPageModelResolver.ResolvePageModel<LoginPageModel>();
		MainPage = new FreshNavigationContainer(mainPage);
	}
}
