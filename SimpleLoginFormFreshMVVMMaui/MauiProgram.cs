using FreshMvvm.Maui.Extensions;

namespace SimpleLoginFormFreshMVVMMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddTransient<LoginPage>();
		builder.Services.AddTransient<LoginPageModel>();

		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<MainPageModel>();

		builder.Services.UseFreshMvvm();

		return builder.Build();
	}
}
