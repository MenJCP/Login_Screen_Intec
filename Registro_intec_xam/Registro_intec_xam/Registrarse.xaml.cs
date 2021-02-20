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
    public partial class Registrarse : ContentPage
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private async void Bt_Finalizar_Clicked(object sender, EventArgs e)
        {
            Nuser user = new Nuser(Entry_Name.Text,Entry_Email.Text, Entry_Password2.Text, Entry_Passwordconfirm.Text);

            if (user.CheckNinfo())
            {
                await DisplayAlert("Registro Exitoso", "Ha sido agregado  " + Entry_Name.Text, "OK");
                await Navigation.PushAsync(new MyTabbedPage2());
            }
            else
            {
                await DisplayAlert("Error", "El Registro ha fallado los parametros Name, Email, Password y la confirmacion no pueden estar vacio", "OK");
            }

            if (Entry_Password2.Text != Entry_Passwordconfirm.Text)
            {
                await DisplayAlert("Error", "El Password debe ser el mismo a la confirmacion" , "OK");
            }
            
        }

       
    }
}