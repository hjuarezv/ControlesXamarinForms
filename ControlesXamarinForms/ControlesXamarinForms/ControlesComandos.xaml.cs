using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlesXamarinForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlesComandos : ContentPage
    {
        public ControlesComandos()
        {
            InitializeComponent();
        }

        private void obtenerValorPI(object sender, EventArgs e)
        {
            var valorPI = Math.PI;
            lblPI.Text = valorPI.ToString();
        }

        private void btnRaizCuadrada_Clicked(object sender, EventArgs e)
        {
            lblRaiz2.Text = Math.Sqrt(2).ToString();
        }

        private void btnVerificar_Clicked(object sender, EventArgs e)
        {
            int Puntaje = 0;

            if (chkP1.IsChecked)
                Puntaje++;
            if (chkP2.IsChecked)
                Puntaje++;

            DisplayAlert("Resultado", "Tienes " + Puntaje.ToString() + " Puntos", "OK");
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            DisplayAlert("Buscando", "....", "OK");
        }

        private void SwipeItem_Invoked(object sender, EventArgs e)
        {

        }

        private void SwipeItem_Invoked_1(object sender, EventArgs e)
        {

        }
    }
}