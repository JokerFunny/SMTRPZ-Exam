using BusinessLogicAbstractions;
using DataAccessAbstractions;
using Model;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    /// <summary>
    /// Service for work with <see cref="User"/>
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IUserRepository _rUserRepository;

        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="userRepository"><see cref="IUserRepository"/></param>
        public UserService(IUserRepository userRepository)
        {
            _rUserRepository = userRepository
                ?? throw new ArgumentNullException(nameof(userRepository));
        }

        /// <summary>
        /// <see cref="IUserService.AddUser(User)"/>
        /// </summary>
        public bool AddUser(User newUser)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see cref="IUserService.DeleteUser(Guid)"/>
        /// </summary>
        public bool DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see cref="IUserService.GetAll"/>
        /// </summary>
        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see cref="IUserService.GetUserByName(string, string)"/>
        /// </summary>
        public User GetUserByName(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see cref="IUserService.UpdateUser(User)"/>
        /// </summary>
        public bool UpdateUser(User newUser)
        {
            throw new NotImplementedException();
        }
    }
}
