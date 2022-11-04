namespace Lab6Starter;

/**
 * 
 * Name: Calvin L, Rudy L
 * Date: 11/02/2022
 * Description: Main class to initialize program
 * Bugs: None found
 * Reflection:
 * 
 */


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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}

