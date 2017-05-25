using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NavigationMasterDetail.Views {
    public partial class ListarAdmins : ContentPage {
        public ListarAdmins() {
            InitializeComponent();
            this.BindingContext = new ViewModels.ListarAdminViewModel();



        }


        public void OnMore(object sender, EventArgs e)
        {
      //      var mi = ((MenuItem)sender);
     //       DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);

            if (ObjLogin.adm == false)
            {
    //            DisplayAlert("Alerta!", "Você não tem permissao para apagar esse registro", "Continuar...");
            }
            else
            {
    //            DisplayAlert("Criar funcao que apaga", ObjLogin.login.ToString(), "OK");
            }




        }


    }
}
