using Model;
using System;
using System.Collections.Generic;

namespace BusinessLogicAbstractions
{
    /// <summary>
    /// Service interface for <see cref="User"/>
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Gets all Users from repo
        /// </summary>
        List<User> GetAll();

        /// <summary>
        /// Get user from repo by name
        /// </summary>
        /// <param name="firstName">Target FN</param>
        /// <param name="lastName">Target LN</param>
        /// <returns>Matched user or null</returns>
        User GetUserByName(string firstName, string lastName);

        /// <summary>
        /// Adds new user to repo
        /// </summary>
        /// <param name="newUser">New user</param>
        /// <returns>
        /// true - if successfully, 
        /// otherwise - false
        /// </returns>
        bool AddUser(User newUser);

        /// <summary>
        /// Updates user
        /// </summary>
        /// <param name="newUser">Target changed user with same Id</param>
        /// <returns>
        /// true - if successfully, 
        /// otherwise - false
        /// </returns>
        bool UpdateUser(User newUser);

        /// <summary>
        /// Dalete user by <paramref name="id"/>
        /// </summary>
        /// <param name="id">Target Id</param>
        /// <returns>
        /// true - if successfully, 
        /// otherwise - false
        /// </returns>
        bool DeleteUser(Guid id);
    }
}
