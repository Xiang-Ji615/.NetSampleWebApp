using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebTemplateDAO.User
{
    public class UserDaoImp : IUserDao
    {
        public async Task addUser(User user)
        {
            using(var ctx = new UserContext())
            {
                //User user1 = new User() { Username = "JJ", Password = "Pass1" };
                //ctx.Entry(user).State = EntityState.Modified;

                ctx.Users.Add(user);
                int x = await (ctx.SaveChangesAsync());
            }
        }
    }
}
