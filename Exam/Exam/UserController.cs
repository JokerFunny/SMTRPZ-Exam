using BusinessLogicAbstractions;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;

namespace Exam
{
    /// <summary>
    /// Controller for <see cref="User"/>
    /// </summary>
    public class UserController
    {
        private readonly IUserService _rUserService;

        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="userService"><see cref="IUserService"/></param>
        public UserController(IUserService userService)
        {
            _rUserService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        public IActionResult AddUser(User newUser)
        {
            throw new NotImplementedException();
        }

        public IActionResult DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public IActionResult GetAll()
        {
            throw new NotImplementedException();
        }

        public IActionResult GetUserByName(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public IActionResult UpdateUser(User newUser)
        {
            throw new NotImplementedException();
        }
    }
}
