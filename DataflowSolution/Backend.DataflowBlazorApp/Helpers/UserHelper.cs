using Backend.DataflowBlazorApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shared.DataflowBlazorApp.Models;

namespace Backend.DataflowBlazorApp.Helpers
{
    public class UserHelper(AppDbContext context, UserManager<User> useManager, RoleManager<IdentityRole> roleManager) : IUserHelper
    {
        private readonly AppDbContext _context = context;
        private readonly UserManager<User> _useManager = useManager;
        private readonly RoleManager<IdentityRole> _roleManager = roleManager;

        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await _useManager.CreateAsync(user, password);
        }

        public async Task AddUserToRoleAsync(User user, string roleName)
        {
            await _useManager.AddToRoleAsync(user, roleName);
        }

        public async Task CheckRoleAsync(string roleName)
        {
            bool roleExists = await _roleManager.RoleExistsAsync(roleName);
            if (!roleExists) 
            {
                await _roleManager.CreateAsync(new IdentityRole
                {
                    Name = roleName
                });
            }
        }

        public async Task<User> GetUserAsync(string email)
        {
            var query = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
            return query!;
        }

        public async Task<bool> IsUserInRoleAsync(User user, string roleName)
        {
            return await _useManager.IsInRoleAsync(user, roleName);
        }
    }
}
