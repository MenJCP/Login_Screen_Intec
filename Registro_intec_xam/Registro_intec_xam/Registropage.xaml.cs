using Registro_intec_xam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Registro_intec_xam
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registropage : ContentPage
    {
        public Registropage()
        {
            InitializeComponent();
        }

        private async void Bt_Login_Clicked(object sender, EventArgs e)
        {
            User user = new User(Entry_Email.Text, Entry_Password.Text);
            if(user.CheckInfo())
            {
                await DisplayAlert("Login Exitoso", "Bienvenido " + Entry_Email.Text, "OK");
                await Navigation.PushAsync(new MyTabbedPage2());
            }
            else
            {
                await DisplayAlert("Error", "El Login ha fallado: Email o Password vacio", "OK", "Cancelar");
            }
        }

       private async void Bt_Registro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registrarse());
        }
    }
}