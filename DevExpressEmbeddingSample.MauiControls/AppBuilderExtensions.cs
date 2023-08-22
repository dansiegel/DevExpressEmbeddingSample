namespace DevExpressEmbeddingSample;

public static class AppBuilderExtensions
{
	public static MauiAppBuilder UseMauiControls(this MauiAppBuilder builder) =>
		builder
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("DevExpressEmbeddingSample/Assets/Fonts/OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("DevExpressEmbeddingSample/Assets/Fonts/OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
}