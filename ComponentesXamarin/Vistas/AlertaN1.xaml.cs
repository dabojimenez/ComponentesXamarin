using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//usamos la libreria services, par ala navegacion
using Rg.Plugins.Popup.Services;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ComponentesXamarin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    // cambiamos ademas el (ContentPage), a (PopupPage), usando el (using Rg.Plugins.Popup.Pages;)
    public partial class AlertaN1 : PopupPage
    {
        public AlertaN1()
        {
            InitializeComponent();
        }

        private void btnOk_Clicked(object sender, EventArgs e)
        {
            //regresamos
            PopupNavigation.Instance.PopAsync();
        }
    }
}