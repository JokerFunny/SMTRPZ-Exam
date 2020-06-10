using System;
using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// Model for group
    /// </summary>
    public class Group
    {
        /// <summary>
        /// Group Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Date and time where will be meeting
        /// </summary>
        public DateTimeOffset DateAndTime { get; set; }

        /// <summary>
        /// Invited users
        /// </summary>
        public List<User> Users { get; set; }
    }
}
