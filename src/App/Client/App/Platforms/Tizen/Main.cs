﻿using System;

using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Functionland.FxBlox.Client.App
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiAppBuilder().CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}