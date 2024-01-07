using Microsoft.Extensions.Logging;
using PrescriptionCalculator.Core;
using PrescriptionCalculator.Core.Interfaces;

namespace PrescriptionCalculator
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .RegisterCores()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        static MauiAppBuilder RegisterCores(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<IMedicineCore, MedicineCore>();

            return mauiAppBuilder;
        }
    }
}
