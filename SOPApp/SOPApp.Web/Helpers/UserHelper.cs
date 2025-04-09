using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SOPApp.Shared.DTO;
using SOPApp.Shared.Entities;
using SOPApp.Web.Data;

namespace SOPApp.Web.Helpers
{
    public class UserHelper: IUserHelper
    {
        private readonly DataContext dataContext;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public UserHelper(
            DataContext dataContext,
            UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            this.dataContext = dataContext;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await userManager.CreateAsync(user, password);
        }

        public async Task AddUserToRoleAsync(User user, string roleName)
        {
            await userManager.AddToRoleAsync(user, roleName);
        }

        public Task<User> GetUserAsync(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<SignInResult> LoginAsync(LoginDTO login)
        {
            return await signInManager.PasswordSignInAsync(login.Email, login.Password, false, false);
        }

        public async Task LogoutAsync()
        {
            await signInManager.SignOutAsync();
        }
    }
}
