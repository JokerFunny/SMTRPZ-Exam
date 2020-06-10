using Model;
using System;
using System.Collections.Generic;

namespace BusinessLogicAbstractions
{
    /// <summary>
    /// Service interface for <see cref="Group"/>
    /// </summary>
    public interface IGroupService
    {
        /// <summary>
        /// Gets all Groups from repo
        /// </summary>
        List<Group> GetAll();

        /// <summary>
        /// Adds new group
        /// </summary>
        /// <param name="newGroup">New group</param>
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

        /// <summary>
        /// Change group from old to new for target user
        /// </summary>
        /// <param name="newGroupId">New group id</param>
        /// <param name="oldGroupId">Old group id</param>
        /// <param name="userId">Target user id</param>
        /// <returns>
        /// true - if successfully, 
        /// otherwise - false
        /// </returns>
        bool ChangeGroupForUser(Guid newGroupId, Guid oldGroupId, Guid userId);
    }
}
