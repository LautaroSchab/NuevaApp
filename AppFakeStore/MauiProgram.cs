﻿using AppFakeStore.Services;
using AppFakeStore.ViewModels;
using AppFakeStore.Views;
using Microsoft.Extensions.Logging;

namespace AppFakeStore
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
                    fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialDesignIcons");
                    fonts.AddFont("Lato-Bold.ttf", "bold");
                    fonts.AddFont("Lato-Regular.ttf", "medium");
                    fonts.AddFont("Font Awesome 6 Free-Solid-900.otf", "AwesomeSolid");
                });

            builder.Services.AddSingleton<IProductoService, ProductoService>();

            builder.Services.AddTransient<ProductoListaViewModel>();
            builder.Services.AddTransient<ProductoListaPage>();

            builder.Services.AddSingleton<IUsuarioService, UsuarioService>();
            builder.Services.AddTransient<UsuarioListaViewModel>();
            builder.Services.AddTransient<UsuarioListaPage>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
