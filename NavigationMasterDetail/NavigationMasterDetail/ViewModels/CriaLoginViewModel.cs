using NavigationMasterDetail.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationMasterDetail.ViewModels
{
    class CriaLoginViewModel : NotifyBase
    {

        public Command CadastraAdmin
        {
            get
            {
                return new Command(() =>
                {
                    AddAdmin();
                
                });
            }
        }

        public string Usuario { get; set; }
        public string Senha { get; set; }

        private async void AddAdmin()
        {


            try
            {
                var client = new HttpClient();

                client.DefaultRequestHeaders.Add("X-Dreamfactory-API-Key", "cab805ee70892e586048ebf9fa6fa738c1cc101f089c85412cc7a59c618306da");

                client.BaseAddress = new Uri("http://138.121.164.9");


           
                var content = new StringContent("{\"resource\":[{\"user\":\"" + Usuario + "\",\"pass\":\"" + Senha + "\",\"adm\":\"" + 0 + "\",\"baixa\":\"" + 0 + "\"}]}", Encoding.UTF8, "application/json");

                string teste = "{\"resource\":[{\"user\":\"" + Usuario + "\",\"pass\":\"" + Senha + "\"}]}";

                var resp = await client.PostAsync("api/v2/novacloud/_table/N_volchers_Adm", content);

                

                if (resp.IsSuccessStatusCode)
                {


                    var respStr = await resp.Content.ReadAsStringAsync();

                    //   vai pra tela te confirmacao
                    await this.MessageService.DisplayMessageAsync("Cadastrado!");
                    await Task.Run(() => Device.BeginInvokeOnMainThread(() => App.Current.MainPage = new ListarAdmins()));


                }
                else
                {
                    // erro
                    await this.MessageService.DisplayMessageAsync(resp.ToString());
                }



            }
            catch (Exception ex)
            {
                await this.MessageService.DisplayMessageAsync(ex.ToString());
                //eroo


            }
        }
    }
}
