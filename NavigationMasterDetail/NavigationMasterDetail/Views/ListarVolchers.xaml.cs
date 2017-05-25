using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavigationMasterDetail;

using Xamarin.Forms;

namespace NavigationMasterDetail.Views
{
    public partial class ListarVolchers : ContentPage
    {
        public ListarVolchers()
        {

            InitializeComponent();
            this.BindingContext = new ViewModels.ListarVolchersViewModel();
           

        }

        public void OnMore(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);

            if (ObjLogin.adm == false)
            {
                DisplayAlert("Alerta!", "Você não tem permissao para apagar esse registro", "Continuar...");
            }
            else
            {
                DisplayAlert("Criar funcao que apaga", ObjLogin.login.ToString(), "OK");
            }
        



        }

     public void OnTogged(object sender, Xamarin.Forms.ToggledEventArgs e)
        {


            if (ObjLogin.adm == true)
            {
                DisplayAlert("Alerta!", "Você não tem permissao alterar esse status", "Continuar...");
            }
            else
            {
                DisplayAlert("Criar funcao que altera status", ObjLogin.login.ToString(), "OK");
            }


        }
    }
}
