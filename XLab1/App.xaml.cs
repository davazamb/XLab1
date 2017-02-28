using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDiplomado.Participants.Startup;

namespace XLab1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : ContentPage
    {
        public App()
        {
            InitializeComponent();
            Startup startup = new Startup("David Zambrano", "david.zambrano10@gmail.com", 1, 1);
            startup.Init();
        }
    }
}
