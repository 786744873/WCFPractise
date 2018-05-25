using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WcfServerByLiberaryAjax
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class UserService : IUserService
    {
        public User GetUser(string id)
        {
            return new User { Age = 11, ID = 1, Name = "zhangsan" };
        }


        public User ChangeUser(string id, string name, string age)
        {
            return new User { Age = 13, ID = 3, Name = "zhangsan3" };
        }

        public User RemoveUser()
        {
            return new User { Age = 14, ID = 4, Name = "zhangsan4" };
        }
    }
}
