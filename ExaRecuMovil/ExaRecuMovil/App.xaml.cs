using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExaRecuMovil
{
    public partial class App : Application
    {

        public static string UBICACIONDB;
        public App(string dblocal)
        {

            InitializeComponent();
            UBICACIONDB = dblocal;
            MainPage = new NavigationPage(new MainPage());

        }

        public App()
        {
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
