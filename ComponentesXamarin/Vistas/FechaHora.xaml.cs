using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ComponentesXamarin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FechaHora : ContentPage
    {
        public FechaHora()
        {
            InitializeComponent();
        }

        private void dtpFecha_DateSelected(object sender, DateChangedEventArgs e)
        {
            //campturamos el valor, en tostring, le pasmaos el formato de fecha
            lblResultado.Text = dtpFecha.Date.ToString("MMM dd, yyyy");
        }

        private void tmpHora_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            //obtenemos la hora en la variable, en este caso colocamos el nombre del label del archivo XAML
            lblHora.Text = tmpHora.Time.ToString();
        }
    }
}