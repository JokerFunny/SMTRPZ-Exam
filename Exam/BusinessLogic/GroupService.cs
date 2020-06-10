using BusinessLogicAbstractions;
using DataAccessAbstractions;
using Model;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    /// <summary>
    /// Service for work with <see cref="Group"/>
    /// </summary>
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository _rGroupRepository;

        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="groupRepository"><see cref="IGroupRepository"/></param>
        public GroupService(IGroupRepository groupRepository)
        {
            _rGroupRepository = groupRepository
                ?? throw new ArgumentNullException(nameof(groupRepository));
        }

        /// <summary>
        /// <see cref="IGroupService.AddGroup(Group)"/>
        /// </summary>
        public bool AddGroup(Group newGroup)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see cref="IGroupService.AddUser(Guid, User)"/>
        /// </summary>
        public bool AddUser(Guid groupId, User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see cref="IGroupService.ChangeGroupForUser(Guid, Guid, Guid)"/>
        /// </summary>
        public bool ChangeGroupForUser(Guid newGroupId, Guid oldGroupId, Guid userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see cref="IGroupService.DeleteGroup(Guid)"/>
        /// </summary>
        public bool DeleteGroup(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see cref="IGroupService.GetAll"/>
        /// </summary>
        public List<Group> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see cref="IGroupService.UpdateGroup(Group)"/>
        /// </summary>
        public bool UpdateGroup(Group newGroup)
        {
            throw new NotImplementedException();
        }
    }
}
