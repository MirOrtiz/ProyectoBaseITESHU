namespace MovilApp
{
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
                    fonts.AddFont("ArianaVioleta-dz2K.ttf", "ArianaVioletadz2K");
                    fonts.AddFont("Chunk Five Print.otf", "ChunkFivePrint");
                    fonts.AddFont("ShortBaby-Mg2w.ttf", "ShortBaby-Mg2w");
                });

            return builder.Build();
        }
    }
}