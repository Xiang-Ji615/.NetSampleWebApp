using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebTemplateDAO.User
{
    public interface IUserDao
    {
        Task addUser(User user);
    }
}
