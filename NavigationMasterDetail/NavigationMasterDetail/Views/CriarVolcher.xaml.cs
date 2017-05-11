using NavigationMasterDetail.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NavigationMasterDetail.Views
{
    public partial class CriarVolcher : ContentPage
    {

   
        public CriarVolcher()
        {


            InitializeComponent();
            this.BindingContext = new ViewModels.CriaVolcherViewModel();


        }

        private void DatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
        {

            // seta data
            ObjRamdomPass.DataExpira =  e.NewDate.ToString("yy-MM-dd");
                        

        }
    }
}
