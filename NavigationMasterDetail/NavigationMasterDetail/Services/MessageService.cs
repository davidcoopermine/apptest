using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationMasterDetail.Services
{
    public class MessageService : IMessageService
    {
        public async Task DisplayMessageAsync(string title, string message)
        {
            await Task.Run(() => Device.BeginInvokeOnMainThread(async () =>
            {
                await App.Current.MainPage.DisplayAlert(title, message, "Ok");
            }));
        }

        public async Task<bool> DisplayQuestionAsync(string title, string message)
        {
            return await App.Current.MainPage.DisplayAlert(title, message, "Sim", "Não");
        }

        public Task<bool> DisplayQuestionAsync(string message)
        {
            return this.DisplayQuestionAsync("SuperFi", message);
        }

        public async Task DisplayMessageAsync(string message)
        {
            await this.DisplayMessageAsync("SuperFi", message);
        }
    }
}