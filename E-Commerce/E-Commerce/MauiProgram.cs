﻿using CommunityToolkit.Maui;
using Interfaces;
using Microsoft.Extensions.Logging;
using Pages;
using Services;
using ViewModels;

namespace E_Commerce
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
                    fonts.AddFont("Ubuntu-Regular.ttf", "UbuntuRegular");
                    fonts.AddFont("Ubuntu-Bold.ttf", "UbuntuBold");
                }).UseMauiCommunityToolkit();
            //builder.Services.AddScoped<IPlatformHttpMessageHandler>();
            //            builder.Services.AddSingleton<IPlatformHttpMessageHandler>(sp =>
            //            {
            //#if ANDROID
            //			return new Platforms.Android.AndroidHttpMessageHandler();
            //#elif IOS
            //			return new Platforms.iOS.IosHttpMessageHandler();
            //#endif
            //                return null;
            //            });

            builder.Services.AddHttpClient(Constants.AppConstants.HttpClientName, httpClient =>
            {
                var baseAddress = DeviceInfo.Platform == DevicePlatform.Android
                                ? "https://10.0.2.2:12345"
                                : "https://localhost:12345";
                httpClient.BaseAddress = new Uri(baseAddress);
            });
            //.ConfigureHttpMessageHandlerBuilder(configBuilder =>
            //{
            //    var platformHttpMessageHandler = configBuilder.Services.GetRequiredService<IPlatformHttpMessageHandler>();
            //    configBuilder.PrimaryHandler = platformHttpMessageHandler.GetHttpMessageHandler();
            //});

            builder.Services.AddSingleton<CategoryService>();
            builder.Services.AddSingleton<HomePageViewModel>();
            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddTransient<OffersService>();
            builder.Services.AddTransient<ProductsService>();
            builder.Services.AddSingleton<CartViewModel>();
            builder.Services.AddTransient<CartPage>();
            builder.Services.AddTransient<CategoriesPage>();
            builder.Services.AddTransientWithShellRoute<CategoryProductsPage,CategoryProductsViewModel>(nameof(CategoryProductsPage));
#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
