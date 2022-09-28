using ComponentesXamarin.Modelo;
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
    public partial class MenuPrincipal : ContentPage
    {
        public IList<MComidas> Comidas { get; private set; }
        public MenuPrincipal()
        {
            InitializeComponent();
            Comidas = new List<MComidas>();
            //en la imagen, colocaremos o haremos referencia en este caso a ANDROID, las imagenes que tenemos en Resources/drawable, de ANDROID
            Comidas.Add(new MComidas { Nombre="Imagen Circular", Imagen= "https://www.hexacta.com/wp-content/uploads/2016/03/xamarin.jpg" });
            Comidas.Add(new MComidas { Nombre = "Alertas", Imagen = "alerta.png" });
            Comidas.Add(new MComidas { Nombre = "Sopa de Calamar", Imagen = "flechacorrecta.png" });
            Comidas.Add(new MComidas { Nombre = "Fechas", Imagen="calendario.png"});
            //aqui procederemos a enlzar los datos con el frontEnd
            //(BindingContext), de donde vamos a sacar los datos, en este caso (this), por que los datos estan aqui
            BindingContext = this;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //seleccionamos el item, y lo hacemos a MComidas
            MComidas seleccion = e.Item as MComidas;
            if (seleccion.Nombre == "Tarjetas")
            {
                //realizaremos una navegacion, a tarjetas
                Navigation.PushAsync(new Tarjetas());
            }
            if (seleccion.Nombre == "Alertas")
            {
                Navigation.PushAsync(new Alertas());
            }
            if (seleccion.Nombre == "Imagen Circular")
            {
                Navigation.PushAsync(new ImagenCircular());
            }
            if (seleccion.Nombre == "Fechas")
            {
                Navigation.PushAsync(new FechaHora());
            }
        }
    }
}