using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace acorreaS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operaciones : ContentPage
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void btnSaludo_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DisplayAlert("Mensaje de Bienvenida", "Bienvenido a la Universidad Israel " + nombre, "Cerrar ");

        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
   
                double Deber1 = Convert.ToDouble(txtDeber1.Text) * 0.30;
                double Examen1 = Convert.ToDouble(txtExamen1.Text) * 0.20;
                double Deber2 = Convert.ToDouble(txtDeber2.Text) * 0.30;
                double Examen2 = Convert.ToDouble(txtExamen2.Text) * 0.20;
                double suma = Deber1 + Examen1;
                txtNotaParcial1.Text = suma.ToString();
                double Suma = Deber2 + Examen2;
                txtNotaParcial2.Text = suma.ToString();
                double sumar = Deber1 + Deber2 + Examen1 + Examen2;
                txtNotaFinal.Text = sumar.ToString();            
        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            txtDeber1.Text = "";
            txtExamen1.Text = "";
            txtDeber2.Text = "";
            txtExamen2.Text = "";
            txtNotaFinal.Text = "";
            txtNotaParcial1.Text = "";
            txtNotaParcial2.Text = "";
            txtMensaje.Text = "";

        }

        private void btnEvaluar_Clicked(object sender, EventArgs e)
        {
            double notaFinal = Double.Parse(txtNotaFinal.Text);
            string nombre = txtMensaje.Text;

            if (notaFinal >= 7)
            {
                nombre = "APROBADO";
            }
            else if (notaFinal >= 5 && notaFinal <= 6.9)
            {
                nombre = "Complementario";
            }
            else
            {
                nombre = "REPROBADO";
            }

            txtMensaje.Text = nombre;
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            
            string Deber1 = txtDeber1.Text;
            string Examen1 = txtExamen1.Text;
            string Deber2 = txtDeber2.Text;
            string Examen2 = txtExamen2.Text;
            string NotaParcial1 = txtNotaParcial1.Text;
            string NotaParcial2 = txtNotaParcial2.Text;
            string Notafinal = txtNotaFinal.Text;
            string Mensaje = txtMensaje.Text;
            Navigation.PushAsync(new Registro(Deber1, Examen1, Deber2, Examen2, NotaParcial1, NotaParcial2, Notafinal, Mensaje ));
        }

   
    }
}
