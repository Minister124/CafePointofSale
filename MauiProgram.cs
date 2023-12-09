using MudBlazor.Services;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Microsoft.Extensions.Logging;
using Cafe_Falaicha.Data.Services;

namespace Cafe_Falaicha
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            CoffeeAddInsService.InitializeAndSaveDefaultData();
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddMudServices();
            builder.Services
                            .AddBlazorise(options =>
                            {
                                options.Immediate = true;
                            })
                            .AddBootstrapProviders()
                            .AddFontAwesomeIcons();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}
