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
    public partial class ControlesSeleccion : ContentPage
    {
        public ControlesSeleccion()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblValor.Text = slider1.Value.ToString();
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            _rotatingLabel.Rotation = value;
            _displayLabel.Text = string.Format("The Stepper value is {0}", value);
        }
    }
}