using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NavigationMasterDetail;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NavigationMasterDetail.Services;
using NavigationMasterDetail.Views;
// [assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace NavigationMasterDetail {

    public partial class App : Application {


        public App() {
            InitializeComponent();

         
     

            DependencyService.Register<Services.IMessageService, Services.MessageService>();
            DependencyService.Register<Services.INavigationService, Services.NavigationService>();


            MainPage = new NavigationMasterDetail.Views.Login();

            

        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}
