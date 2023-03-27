using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace DynamicResources
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void UpdateAppColors(Color backgroundColor, Color foregroundColor)
        {
            this.Resources["AppBackgroundColor"] = new SolidColorBrush(backgroundColor);
            this.Resources["AppForegroundColor"] = new SolidColorBrush(foregroundColor);
        }

    }
}
