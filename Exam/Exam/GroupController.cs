using BusinessLogicAbstractions;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;

namespace Exam
{
    /// <summary>
    /// Controller for <see cref="User"/>
    /// </summary>
    public class GroupController
    {
        private readonly IGroupService _rGroupService;

        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="groupService"><see cref="IGroupService"/></param>
        public GroupController(IGroupService groupService)
        {
            _rGroupService = groupService ?? throw new ArgumentNullException(nameof(groupService));
        }

        public IActionResult AddGroup(Group newGroup)
        {
            throw new NotImplementedException();
        }

        public IActionResult AddUser(Guid groupId, User user)
        {
            throw new NotImplementedException();
        }

        public IActionResult ChangeGroupForUser(Guid newGroupId, Guid oldGroupId, Guid userId)
        {
            throw new NotImplementedException();
        }

        public IActionResult DeleteGroup(Guid id)
        {
            throw new NotImplementedException();
        }

        public IActionResult GetAll()
        {
            throw new NotImplementedException();
        }

        public IActionResult UpdateGroup(Group newGroup)
        {
            throw new NotImplementedException();
        }
    }
}
