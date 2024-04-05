using Backend.DataflowBlazorApp.Data;
using Microsoft.AspNetCore.Identity;
using Shared.DataflowBlazorApp.Models;

namespace Backend.DataflowBlazorApp.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _useManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserHelper(AppDbContext context, UserManager<User> useManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _useManager = useManager;
            _roleManager = roleManager;
        }

        public Task<IdentityResult> AddUserAsync(User user, string password)
        {
            throw new NotImplementedException();
        }

        public Task AddUserToRoleAsync(User user, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task CheckRoleAsync(string rolename)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUserInRoleAsync(User user, string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
