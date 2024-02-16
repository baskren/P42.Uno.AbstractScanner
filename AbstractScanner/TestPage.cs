using System;
using Microsoft.UI;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Media;

namespace AbstractScanner
{
    [Bindable]
    public partial class TestPage : Page
    {
        public TestPage()
        {
            Content = new TextBlock
            {
                Text = "TEST PAGE",
                HorizontalAlignment = Microsoft.UI.Xaml.HorizontalAlignment.Center,
                VerticalAlignment = Microsoft.UI.Xaml.VerticalAlignment.Center
            };

            Background = new SolidColorBrush(Colors.Pink);
        }
    }
}