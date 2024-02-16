using System;
using Xamarin.Essentials;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZXing.Net.Mobile.Uno;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml;

namespace AbstractScanner
{
    public static class Platform
    {
        public static Application Application { get; private set; }

        public static Window MainWindow { get; private set; }

        public static void Init(Application app, Window mainWindow)
        {
            Application = app;
            MainWindow = mainWindow;
        }
    }
}
