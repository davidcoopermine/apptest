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
        
            DateTime dt = DateTime.Now;
            ObjRamdomPass.DataExpira = dt.ToString("yy-MM-dd HH:mm:ss");
            ObjVolchers.Dias = 1;
        }

        private void DatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
        {

            // seta data
            ObjRamdomPass.DataExpira =  e.NewDate.ToString("yy-MM-dd HH:mm:ss");
            TimeSpan date = e.NewDate - DateTime.Now;

            int totalDias = date.Days;

            ObjVolchers.valor = totalDias.ToString();





        }
    }
}
