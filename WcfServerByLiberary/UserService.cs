using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WcfServerByLiberary
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class UserService : IUserService
    {
        public User GetUser(string id)
        {
            return new User() { Age=11,ID=1,Name="张三"};
        }

        public User AddUser(User u)
        {
            return new User() { Age = 12, ID = 1, Name = "张三2" };
        }

        public User ChangeUser(string id)
        {
            return new User() { Age = 13, ID = 1, Name = "张三3" };
        }

        public User RemoveUser()
        {
            Check();//鉴权
            return new User() { Age = 14, ID = 1, Name = "张三4" };
        }

        /// <summary>
        /// 检查权限
        /// </summary>
        /// <returns></returns>
        public bool Check()
        {
            var ctx = WebOperationContext.Current;
            var auth = ctx.IncomingRequest.Headers[System.Net.HttpRequestHeader.Authorization];
            if (string.IsNullOrWhiteSpace(auth)||auth!="aaa/123")
            {
                ctx.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.MethodNotAllowed;
                return false;
            }
            return true;
        }
    }
}
