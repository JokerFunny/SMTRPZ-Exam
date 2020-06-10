using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccess
{
    /// <summary>
    /// Context for Datting App
    /// </summary>
    public class DatingAppContext : DbContext
    {
        /// <summary>
        /// Users <see cref="DbSet{TEntity}"/>
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Groups <see cref="DbSet{TEntity}"/>
        /// </summary>
        public DbSet<Group> Groups { get; set; }

        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="options"><see cref="DbContextOptions{TContext}"/></param>
        public DatingAppContext(DbContextOptions<DatingAppContext> options)
            : base(options)
        { }
    }
}
