using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using NavigationMasterDetail.Views;

namespace NavigationMasterDetail.ViewModels
{

    public class LoginViewModel : NotifyBase
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        private string _mensamge;
        private string _quantidade;
        private int _loginid;



        public LoginViewModel()
        {

        }



        public string Mensagem
        {
            get { return _mensamge; }
            set
            {
                _mensamge = value;
                Notificar();
            }

        }



        public int LoginID
        {
            get { return _loginid; }
            set
            {
                _loginid = value;
                Notificar();
            }

        }


        public Command Logar
        {
            get
            {
                return new Command(() =>
                {
                    Iniciar();


                });
            }
        }



       


        private async void Iniciar()
        {


            try
            {

                var client = new HttpClient();

                client.DefaultRequestHeaders.Add("X-Dreamfactory-API-Key", "cab805ee70892e586048ebf9fa6fa738c1cc101f089c85412cc7a59c618306da");

                client.BaseAddress = new Uri("http://138.121.164.9");

                var resp = await client.GetAsync("api/v2/novacloud/_table/N_volchers_Adm?filter=(radius_pass%3D" + Senha + ")%20and%20(user%3D" + Usuario + ")&limit=1");

                if (resp.IsSuccessStatusCode)
                {


                    var respStr = await resp.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject<Admusers.RootObject>(respStr);

                    _quantidade = data.resource.Count.ToString();

                    if (_quantidade == "1")
                    {
                        Mensagem = "Autorizado" ;
                        ObjLogin.login_id = data.resource[0].id;
                        ObjLogin.logado = true;
                        await Task.Run(() => Device.BeginInvokeOnMainThread(() => App.Current.MainPage = new MainPage()));
                    }
                    else
                    {
                        Mensagem = "Usuário/Senha Inválidos";
                        ObjLogin.logado = false;
                    };



                }
                else
                {
                    _quantidade = "0";
                    Mensagem = "Erro";
                    ObjLogin.logado = false;

                };


            }
            catch (Exception ex)
            {
                _quantidade = "0";
                Mensagem = ex.ToString();
                ObjLogin.logado = false;

            }


        }
        

    }
}
