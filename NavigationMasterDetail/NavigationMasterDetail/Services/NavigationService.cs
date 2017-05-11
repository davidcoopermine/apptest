using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavigationMasterDetail.Views;

namespace NavigationMasterDetail.Services
{
    public class NavigationService : INavigationService
    {
        private static MainPage m_RootPage = null;

        public static MainPage RootPage => m_RootPage ?? (m_RootPage = (App.Current.MainPage as MainPage));

        public async Task NavigateGoBackModal()
        {
            if (App.Current.MainPage.Navigation.ModalStack.Count > 1)
                await App.Current.MainPage.Navigation.PopModalAsync();
        }
     
        public async Task NavigateToLogon()
        {
            await Task.Run(() => App.Current.MainPage = new Login());
        }

        
    }

}
