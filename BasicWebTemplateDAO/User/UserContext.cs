using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebTemplateDAO.User
{
    public class UserContext: DbContext
    {
        private DbSet<User> users;

        public DbSet<User> Users { get => users; set => users = value; }

        public UserContext() : base("LocalDB")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
