using Backend.DataflowBlazorApp.Helpers;
using Shared.DataflowBlazorApp.Enum;
using Shared.DataflowBlazorApp.Models;
using System.Runtime.CompilerServices;

namespace Backend.DataflowBlazorApp.Data
{
    public class SeedDb(AppDbContext context, IUserHelper useHelper)
    {
        private readonly AppDbContext _context = context;
        private readonly IUserHelper _useHelper = useHelper;

        public async Task SeedAsync() 
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
            await CheckRolesAsync();
        }
        private async Task CheckCountriesAsync() 
        {
            if (!_context.Countries.Any()) 
            {
                _context.Countries.Add(new Country { Name = "Colombia" });
                _context.Countries.Add(new Country { Name = "Estados Unidos" });
            }
            await _context.SaveChangesAsync();
        }

        private async Task CheckRolesAsync() 
        {
            await _useHelper.CheckRoleAsync(UserType.Admin.ToString());
            await _useHelper.CheckRoleAsync(UserType.User.ToString());

            await CheckUserAsync("1010", "Juan", "Zuluaga", "zulu@yopmailcom", "321 4060", "Calle luna calle sol",UserType.Admin);

        }

        private async Task<User> CheckUserAsync(string document, string firstName, string lastName, string email, string phone,string address , UserType userType) 
        {
            var user = await _useHelper.GetUserAsync(email);
            user ??= new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = email,
                    PhoneNumber = phone,
                    Address = address,
                    Document = document,
                    UserType = userType
                };
            await _useHelper.AddUserAsync(user, "123456");
            await _useHelper.AddUserToRoleAsync(user, userType.ToString());
            return user;
        }

    }
}
