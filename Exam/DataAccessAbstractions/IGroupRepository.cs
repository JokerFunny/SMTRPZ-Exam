using Model;
using System;
using System.Collections.Generic;

namespace DataAccessAbstractions
{
    public interface IGroupRepository
    {
        /// <summary>
        /// Gets all Groups
        /// </summary>
        List<Group> GetAll();

        /// <summary>
        /// Adds new Group
        /// </summary>
        /// <param name="newGroup">New Group</param>
        /// <returns>
        /// true - if successfully, 
        /// otherwise - false
        /// </returns>
        bool AddGroup(Group newGroup);

        /// <summary>
        /// Updates group
        /// </summary>
        /// <param name="newGroup">Target changed group with same Id</param>
        /// <returns>
        /// true - if successfully, 
        /// otherwise - false
        /// </returns>
        bool UpdateGroup(Group newGroup);

        /// <summary>
        /// Dalete group by <paramref name="id"/>
        /// </summary>
        /// <param name="id">Target Id</param>
        /// <returns>
        /// true - if successfully, 
        /// otherwise - false
        /// </returns>
        bool DeleteGroup(Guid id);

        /// <summary>
        /// Add user to target group
        /// </summary>
        /// <param name="groupId">Target group id</param>
        /// <param name="user">Target user</param>
        /// <returns>
        /// true - if successfully, 
        /// otherwise - false
        /// </returns>
        bool AddUser(Guid groupId, User user);
    }
}
