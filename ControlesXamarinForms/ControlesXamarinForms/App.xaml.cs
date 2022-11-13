using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlesXamarinForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new ControlesPresentacion();
            //MainPage = new ControlesComandos();
            //MainPage = new ControlesSeleccion();
            MainPage = new ControlesEntrada();
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
