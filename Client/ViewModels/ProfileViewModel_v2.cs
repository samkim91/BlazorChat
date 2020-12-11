using BlazorChat.Shared.Models;

namespace BlazorChat.ViewModels
{
    public class ProfileViewModel_v2
    {

        public long UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }
        public string Message { get; set; }

        public void UpdateProfile()
        {
            //User user = _ProfileViewModel_v2;
            //await HttpClient.PutAsJsonAsync("user/updateprofile/10", user);
            this.Message = this.FirstName + "'s Profile updated successfully -- faster";
        }

        public void GetProfile()
        {
            //User user = await HttpClient.GetFromJsonAsync<User>("user/getprofile/10");
            //_ProfileViewModel_v2 = user;
            this.Message = "Profile loaded successfully -- faster";
        }

        public static implicit operator ProfileViewModel_v2(User user)
        {
            return new ProfileViewModel_v2
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                EmailAddress = user.EmailAddress,
                UserId = user.UserId
            };
        }

        public static implicit operator User(ProfileViewModel_v2 ProfileViewModel_v2)
        {
            return new User
            {
                FirstName = ProfileViewModel_v2.FirstName,
                LastName = ProfileViewModel_v2.LastName,
                EmailAddress = ProfileViewModel_v2.EmailAddress,
                UserId = ProfileViewModel_v2.UserId
            };
        }
    }
}