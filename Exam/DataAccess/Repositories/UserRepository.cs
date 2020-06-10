using DataAccessAbstractions;
using Model;
using System;
using System.Collections.Generic;

namespace DataAccess.Repositories
{
    /// <summary>
    /// Repository for work with <see cref="User"/>
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private readonly DatingAppContext _rDatingAppContext;

        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="datingAppContext"><see cref="DatingAppContext"/></param>
        public UserRepository(DatingAppContext datingAppContext)
        {
            _rDatingAppContext = datingAppContext 
                ?? throw new ArgumentNullException(nameof(datingAppContext));
        }

        /// <summary>
        /// <see cref="IUserRepository.AddUser(User)"/>
        /// </summary>
        public bool AddUser(User newUser)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see cref="IUserRepository.DeleteUser(Guid)"/>
        /// </summary>
        public bool DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see cref="IUserRepository.GetAll"/>
        /// </summary>
        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see cref="IUserRepository.GetUserByName(string, string)"/>
        /// </summary>
        public User GetUserByName(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see cref="IUserRepository.UpdateUser(User)"/>
        /// </summary>
        public bool UpdateUser(User newUser)
        {
            throw new NotImplementedException();
        }
    }
}
