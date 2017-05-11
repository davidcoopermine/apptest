﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationMasterDetail.ViewModels
{
    class CriaVolcherViewModel : NotifyBase
    {

        private string _user;

        public string User
        {
            get { return _user; }
            set
            {
                _user= value;
                ObjRamdomPass.UserRandom = value;
                Notificar();
            }

        }


        private string _pass;

        public string Pass
        {
            get { return _pass; }
            set
            {
                _pass = value;
                ObjRamdomPass.PassRandom = value;
                Notificar();
            }

        }

        private DateTime _PropertyMaximumDate;

        public DateTime PropertyMaximumDate
        {
            get { return _PropertyMaximumDate; }
            set
            {
                _PropertyMaximumDate = value;
                Notificar();
            }

        }

        private DateTime _PropertyMinimumDate;

        public DateTime PropertyMinimumDate
        {
            get { return _PropertyMinimumDate; }
            set
            {
                _PropertyMinimumDate = value;
                Notificar();
            }

        }

        public Command CadastraVolcher
        {
            get
            {
                return new Command(() =>
                {
                   AddVolchers();
                  //  User = "teste";

                });
            }
        }

        private async void AddVolchers()
        {


            try
            {
                var client = new HttpClient();

                client.DefaultRequestHeaders.Add("X-Dreamfactory-API-Key", "cab805ee70892e586048ebf9fa6fa738c1cc101f089c85412cc7a59c618306da");

                client.BaseAddress = new Uri("http://138.121.164.9");
                     

                var content = new StringContent("{\"resource\":[{\"login\":\""+ ObjRamdomPass.UserRandom + "\",\"pass\":\"" + ObjRamdomPass.PassRandom + "\"}]}", Encoding.UTF8, "application/json");

                var resp = await client.PostAsync("api/v2/novacloud/_table/N_volchers", content);

              

                if (resp.IsSuccessStatusCode)
                {


                    var respStr = await resp.Content.ReadAsStringAsync();

                 //   vai pra tela te confirmacao



                      } else
                {
                    // erro
                    User = resp.ToString();
                }



            }
            catch (Exception ex)
            {

                //eroo
                User = "erro";

            }
        }


        public CriaVolcherViewModel()
        {




            PropertyMaximumDate = DateTime.Now.AddMonths(1);
            PropertyMinimumDate = DateTime.Now;

            Random rnd = new Random();
            string valor = string.Empty;

            for (int i = 0; i < 8; i++)
            {
                if (rnd.Next(0, 2) == 1) // Caso seja 1, sorteia letras  
                {
                    valor += Convert.ToChar(rnd.Next(65, 91));
                }
                else
                {
                    valor += Convert.ToChar(rnd.Next(48, 58));
                }

            }

            User = valor.ToString();

            valor = string.Empty;

            for (int i = 0; i < 8; i++)
            {
                if (rnd.Next(0, 2) == 1) // Caso seja 1, sorteia letras  
                {
                    valor += Convert.ToChar(rnd.Next(65, 91));
                }
                else
                {
                    valor += Convert.ToChar(rnd.Next(48, 58));
                }

            }



            Pass = valor.ToString();

        }        



    }
}
