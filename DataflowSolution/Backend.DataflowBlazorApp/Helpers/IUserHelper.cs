using Microsoft.AspNetCore.Identity;
using Shared.DataflowBlazorApp.Models;

namespace Backend.DataflowBlazorApp.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserAsync(string email);
        Task<IdentityResult> AddUserAsync(User user, string password);
        Task CheckRoleAsync(string rolename);
        Task AddUserToRoleAsync(User user, string roleName);
        Task<bool> IsUserInRoleAsync(User user, string roleName);
    }
}
