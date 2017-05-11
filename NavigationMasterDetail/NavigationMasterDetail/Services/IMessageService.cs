using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationMasterDetail.Services
{
    public interface IMessageService
    {
        Task DisplayMessageAsync(string message);
        Task DisplayMessageAsync(string title, string message);
        Task<bool> DisplayQuestionAsync(string title, string message);
        Task<bool> DisplayQuestionAsync(string message);
    }
}