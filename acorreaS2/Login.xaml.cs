using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace acorreaS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraeña = txtContraseña.Text;
            if (usuario == "estudiante2023" && contraeña == "uisrael2023")
            {
                Navigation.PushAsync(new Operaciones());
            }
            else
            {
                DisplayAlert("ALERTA", "Usuario/Contraseña Incorrectos", "Cerrar");
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
        }

        private void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}