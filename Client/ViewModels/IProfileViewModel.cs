using System.Threading.Tasks;
using BlazorChat.Shared.Models;

namespace BlazorChat.ViewModels
{
    public interface IProfileViewModel
    {

        public long UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }
        public string Message { get; set; }

        public Task UpdateProfile();

        public Task GetProfile();
    }
}