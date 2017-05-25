using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationMasterDetail.ViewModels
{
    class ListarAdminViewModel : NotifyBase
    {

        private IEnumerable _lista;

        public IEnumerable Lista
        {
            get { return _lista; }
            set
            {
                _lista = value;
                Notificar();
            }

        }


        public ListarAdminViewModel()
        {
            this.CarregaListaAdmin();
        }

        public Command Cadastrar
        {
            get
            {
                return new Command(() =>
                {

                    CarregaListaAdms();

                });
            }
        }


        private async void CarregaListaAdms()
        {
            await Task.Run(() => Device.BeginInvokeOnMainThread(() => App.Current.MainPage = new Views.CriaLogin()));
        }


        private async void CarregaListaAdmin()
        {


            try
            {
                var client = new HttpClient();

                client.DefaultRequestHeaders.Add("X-Dreamfactory-API-Key", "cab805ee70892e586048ebf9fa6fa738c1cc101f089c85412cc7a59c618306da");

                client.BaseAddress = new Uri("http://138.121.164.9");

                var resp = await client.GetAsync("api/v2/novacloud/_table/Vw_Lista_Owner_Volchers");


                if (resp.IsSuccessStatusCode)
                {


                    var respStr = await resp.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject<Models.OwnerAdmin.RootObject>(respStr);
                    
                    Lista = data.resource as IEnumerable;

                 


                }
                else
                {


                };


            }
            catch (Exception ex)
            {

                await this.MessageService.DisplayMessageAsync(ex.ToString());

            }


        }

    }
}
