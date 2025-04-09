using Microsoft.AspNetCore.Identity;
using SOPApp.Shared.DTO;
using SOPApp.Shared.Entities;

namespace SOPApp.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserAsync(string email);
        Task<IdentityResult> AddUserAsync(User user, string password);
        Task<SignInResult> LoginAsync(LoginDTO login);
        Task LogoutAsync();
    }
}
