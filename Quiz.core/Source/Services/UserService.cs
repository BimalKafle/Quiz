using Microsoft.AspNetCore.Identity;
using Quiz.core.Source.Dto.User;
using Quiz.core.Source.Entity;
using Quiz.core.Source.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Services
{
    public class UserService : UserServiceInterface
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(UserManager<ApplicationUser> userManager
           )
        {
            _userManager = userManager;

        }
        public async Task Create(UserDto dto)
        {
            await ValidateUser(dto);
            var user = new ApplicationUser()
            {
                FullName = dto.FullName,
                UserName = dto.UserName,
                Email = dto.Email

            };
            var isSuceeded = await _userManager.CreateAsync(user, dto.Password);
            if (!isSuceeded.Succeeded) throw new UserException(isSuceeded.Errors.First().Description);
            await _userManager.AddToRoleAsync(user, ApplicationUser.RoleUser);
        }
        private async Task ValidateUser(UserDto dto)
        {
            var userWithSameEmail = await _userManager.FindByEmailAsync(dto.Email).ConfigureAwait(false);
            if (userWithSameEmail != null) throw new UserWithSameEmailAlreadyExistException();
            var userWithSameUserName = await _userManager.FindByNameAsync(dto.UserName).ConfigureAwait(false);
            if (userWithSameUserName != null) throw new DuplicateUserNameException();
        }
    }
}
