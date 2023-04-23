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
    public partial class Registro : ContentPage
    {
        public Registro(string Deber1, string Examen1, string Deber2, string Examen2, string NotaParcial1, string NotaParcial2, string NotaFinal, string Mensaje)
        {
            InitializeComponent();
            lblDeber1.Text = Deber1;
            lblExamen1.Text = Examen1;
            lblDeber2.Text = Deber2;
            lblExamen2.Text = Examen2;
            lblNotaParcial1.Text = NotaParcial1;
            lblNotaparcial2.Text = NotaParcial2;
            lblNotaFinal.Text = NotaFinal;
            lblMensaje.Text = Mensaje;
            //txtDeber1.Text = Deber1;
            //txtExamen1.Text = Examen1;
            //txtDeber2.Text = Deber2;
            //txtExamen2.Text= Examen2;
            //txtNotaParcial1.Text = NotaParcial1;
            //txtNotaParcial2.Text = NotaParcial2;
            //txtNotaFinal.Text = NotaFinal;
            //txtMensaje.Text = Mensaje;
        }
    }
}