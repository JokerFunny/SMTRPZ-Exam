using DataAccessAbstractions;
using Model;
using System;
using System.Collections.Generic;

namespace DataAccess.Repositories
{
    /// <summary>
    /// Repository for work with <see cref="Group"/>
    /// </summary>
    public class GroupRepository : IGroupRepository
    {
        private readonly DatingAppContext _rDatingAppContext;

        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="datingAppContext"><see cref="DatingAppContext"/></param>
        public GroupRepository(DatingAppContext datingAppContext)
        {
            _rDatingAppContext = datingAppContext
                ?? throw new ArgumentNullException(nameof(datingAppContext));
        }

        /// <summary>
        /// <see cref="IGroupRepository.AddGroup(Group)"/>
        /// </summary>
        public bool AddGroup(Group newGroup)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see cref="IGroupRepository.AddUser(Guid, User)"/>
        /// </summary>
        public bool AddUser(Guid groupId, User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see cref="IGroupRepository.DeleteGroup(Guid)"/>
        /// </summary>
        public bool DeleteGroup(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see cref="IGroupRepository.GetAll"/>
        /// </summary>
        public List<Group> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see cref="IGroupRepository.UpdateGroup(Group)"/>
        /// </summary>
        public bool UpdateGroup(Group newGroup)
        {
            throw new NotImplementedException();
        }
    }
}
