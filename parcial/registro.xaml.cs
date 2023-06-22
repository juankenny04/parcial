using System;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace parcial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        string usuario;
        public Page2(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "USUARIO CONECTADO " + usuario;
            this.usuario = usuario;
        }


        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3(usuario));

        }

        private void btnPagoMensual_Clicked(object sender, EventArgs e)
        {

        }
    }
}