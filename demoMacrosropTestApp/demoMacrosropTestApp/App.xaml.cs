using demoMacrosropTestApp.Bootsrap;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demoMacrosropTestApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            LoadTypes();
        }

        private void LoadTypes()
        {
            var bootstrapper = new Bootstrapper(this);
            bootstrapper.Run();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
