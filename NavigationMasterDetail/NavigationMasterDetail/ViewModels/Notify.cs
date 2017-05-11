using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NavigationMasterDetail.Services;
using Xamarin.Forms;

namespace NavigationMasterDetail.ViewModels
{
    public abstract class NotifyBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public IMessageService MessageService { get; private set; }

        public void Notificar([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public NotifyBase()
        {
            this.MessageService = DependencyService.Get<IMessageService>();
           
        }
        public int FormPadding { get { return 30; } }
        public Task Init { get; set; }
    }
}
