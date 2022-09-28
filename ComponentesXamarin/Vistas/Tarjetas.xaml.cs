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
    public partial class Tarjetas : ContentPage
    {
        public Tarjetas()
        {
            InitializeComponent();
        }

        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            //solo colocamos de esta forma, por que reconoce o vuelve a la pagina anterior desde donde se llego a la nueva ventana
            Navigation.PopAsync();
        }
    }
}