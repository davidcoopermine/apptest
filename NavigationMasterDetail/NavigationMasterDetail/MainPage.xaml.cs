using NavigationMasterDetail.MenuItems;
using NavigationMasterDetail.Views;
using NavigationMasterDetail.Services;
using NavigationMasterDetail.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationMasterDetail {

    public partial class MainPage : MasterDetailPage   {

        public List<MasterPageItem> menuList { get; set; }

        public MainPage() {

            InitializeComponent();

            menuList = new List<MasterPageItem>();

            // Creating our pages for menu navigation
            // Here you can define title for item, 
            // icon on the left side, and page that you want to open after selection
            var page1 = new MasterPageItem() { Title = "Criar Volcher", Icon = "itemIcon1.png", TargetType = typeof(CriarVolcher) };
            var page2 = new MasterPageItem() { Title = "Volchers - Todos", Icon = "itemIcon2.png", TargetType = typeof(ListarVolchers) };
            var page3 = new MasterPageItem() { Title = "Meus Volchers - Em Aberto", Icon = "itemIcon3.png", TargetType = typeof(ListarVolchersCredenciadosAbertos) };
            var page4 = new MasterPageItem() { Title = "Meus Volchers - Todos", Icon = "itemIcon4.png", TargetType = typeof(ListarVolchersCredenciadosFechados) };
            var page5 = new MasterPageItem() { Title = "Credenciados", Icon = "itemIcon1.png", TargetType = typeof(ListarAdmins) };
       

            // Adding menu items to menuList
            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);
            menuList.Add(page5);

            if (ObjLogin.adm == false) { menuList.Remove(page2); menuList.Remove(page5); }
            

            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;

            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(TestPage3)));

            IsPresented = true;

        }

        // Event for Menu Item selection, here we are going to handle navigation based
        // on user selection in menu ListView
        private async void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e) {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            ObjLogin.logado = true;


            if (page.Name.ToString() == "Login")
            {

                //   // abrir pagina login
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Login)));
                IsPresented = false;
            }
            else
            {

             

                Detail = new NavigationPage((Page)Activator.CreateInstance(page));
                IsPresented = false;


            }

        }
    }
}
