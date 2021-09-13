using JWTAuth.Contexts;
using JWTAuth.Models;
using JWTAuth.Settings;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuth.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly JWT _jwt;

        public UserService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IOptions<JWT> jwt, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _jwt = jwt.Value;
        }
    }
}
