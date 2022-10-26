using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JoseS1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login1());//habilita la navegacion
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
