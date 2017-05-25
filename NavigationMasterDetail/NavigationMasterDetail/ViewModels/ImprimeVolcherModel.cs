using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationMasterDetail.ViewModels
{
    class ImprimeVolcherModel : NotifyBase
    {
        private string _user;


        public string User
        {
            get { return _user; }
            set
            {
                _user = value;
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

        private string _valor;

        public string Valor
        {
            get { return _valor; }
            set
            {
                _valor = value;
                ObjVolchers.valor = value;
                Notificar();
            }

        }

        public ImprimeVolcherModel()
        {

            User = ObjRamdomPass.UserRandom;
            Pass = ObjRamdomPass.PassRandom;
            DataExpira = ObjRamdomPass.DataExpira;
            Valor = ObjVolchers.valor;


        }

        public Command ImprimirVolcher
        {
            get
            {
                return new Command(() =>
                {
                    MsgImprimirVolchers();
                    //  User = "teste";


                });
            }
        }

        private async void MsgImprimirVolchers()
        {
            await this.MessageService.DisplayMessageAsync("Nenhuma impressora encontrada");
        }


        private string _expira;

        public string DataExpira
        {
            get { return _expira; }
            set
            {
                _expira = value;
                Notificar();
            }

        }

    }
}
