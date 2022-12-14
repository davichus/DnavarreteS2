using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnavarreteS2
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

     

       private void btnIniciar_Clicked(System.Object sender, System.EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            bool ingresar = inisiarSesion(usuario, contrasena);
            if (ingresar)
            {
                Navigation.PushAsync(new Calificaciones(usuario));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario/Contraseña Incorrectos", "Cerrar");
            }
        }

        public bool inisiarSesion(string usuario, string contrasena)
        {
            bool inicio = true;
            string user = "estudiante2022";
            string pass = "uisrael2022";
            if (user == usuario && pass == contrasena)
            {
                inicio = true;
            }
            else
            {
                inicio = false;
            }
            return inicio;
        }

    }
}

