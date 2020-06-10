using Model.Enums;
using System;
using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// User model
    /// </summary>
    public class User
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// User genre
        /// </summary>
        public Genre Genre { get; set; }

        /// <summary>
        /// Interested in users from age
        /// </summary>
        public int InterestedFromAge { get; set; }

        /// <summary>
        /// Interested in users to age
        /// </summary>
        public int InterestedToAge { get; set; }

        /// <summary>
        /// Users interests
        /// </summary>
        public List<string> Interests { get; set; }

        /// <summary>
        /// Prefered time for user
        /// </summary>
        public PreferedTime PreferedTime { get; set; }
    }
}
