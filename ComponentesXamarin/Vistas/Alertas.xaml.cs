using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//esta libreria, services, es lo que hace es llamar a las paginas popup
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ComponentesXamarin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Alertas : ContentPage
    {
        public Alertas()
        {
            InitializeComponent();
        }

        private void btnAlertas_Clicked(object sender, EventArgs e)
        {
            //mostraremos una alerta, pero esta NO PERMITE PERZONALIZAR, de por si solas,
            //para eso debemos agregar un plugin, llamado (Rg.Plugins.Popup), debemos instalarlo desde los paquetes nuget
            //DisplayAlert("Titulo", "POL Q ELES BIEN TOXICA???", "OK");

            //llamamos a nuestra ventana emergente de tipo popup
            PopupNavigation.Instance.PushAsync(new AlertaN1());
        }
    }
}