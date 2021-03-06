﻿using Newtonsoft.Json;
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
    class ListarVolchersViewModel : NotifyBase
    {


        public ListarVolchersViewModel()
        {
            this.CarregaListaVolchers();

            

        }

        private string _quantidadevolcher;

        public string QuantidadeVolcher
        {
            get { return _quantidadevolcher; }
            set
            {
                _quantidadevolcher = value;
                Notificar();
            }

        }

        private string _owner;

        public string Owner
        {
            get { return _owner; }
            set
            {
                _owner = value;
                Notificar();
            }

        }

        private string _statuspagamento;

        public string StatusPagamento
        {
            get { return _statuspagamento; }
            set
            {
                _statuspagamento = value;
                Notificar();
            }

        }

        public bool _ativo;

        public bool Ativo
        {
            get { return _ativo; }
            set
            {
                _ativo = value;
                Notificar();
            }
       
        }

        public bool _es;

        public bool EstadoDoSwitch
        {
            get { return _es; }
            set
            {
                _es = value;
                Notificar();
            }

        }


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

        private ObservableCollection<Models.Volchers.Resource> m_volchers;
        public ObservableCollection<Models.Volchers.Resource> OB_volchers
        {
            get { return m_volchers; }
            set
            {
                m_volchers = value;
                this.Notificar();
            }
        }

        public List<Models.Volchers> lvolcher { get; set; }

        public Command BuscarVolchers
        {
            get
            {
                return new Command(() =>
                {
                    CarregaListaVolchers();


                });
            }
        }


     
        private async void CarregaListaVolchers()

        {


            try
            {
                var client = new HttpClient();

                client.DefaultRequestHeaders.Add("X-Dreamfactory-API-Key", "cab805ee70892e586048ebf9fa6fa738c1cc101f089c85412cc7a59c618306da");

                client.BaseAddress = new Uri("http://138.121.164.9");

                var resp = await client.GetAsync("api/v2/novacloud/_table/vw_Volchers");

                
                if (resp.IsSuccessStatusCode)
                {


                    var respStr = await resp.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject <Models.Volchers.RootObject>(respStr);

                    if (ObjLogin.adm == true) { EstadoDoSwitch = true; } else { EstadoDoSwitch = false; }

                    Lista = data.resource as IEnumerable;                             

                    QuantidadeVolcher = data.resource.Count.ToString();

                    

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
