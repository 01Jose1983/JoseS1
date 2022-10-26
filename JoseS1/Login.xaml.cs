using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JoseS1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Clicked(object sender, EventArgs e)
            
        {
            await Navigation.PushAsync(new RegistroCalificaciones(txtUsuario.Text));
            string usuario = "estudiante2022";
            string contrasena= "uisrael2022";

            string tUsuario = txtUsuario.Text;
            string tContrasena = txtContraseña.Text;
            if(usuario == tUsuario && contrasena ==tContrasena)
            {
                DisplayAlert("Alerta", "USUARIO CORRECTO", "Cerrar");
                Navigation.PushAsync(new RegistroCalificaciones(usuario));
            }
            else
            {
                DisplayAlert("Alerta", "USUARIO NO EXISTE", "Cerrar");
            }
        }
    }
}