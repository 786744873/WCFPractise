using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace UserNameHttps
{
    public class Service : Iservice
    {
        public string Say()
        {
            return "Hello";
        }

        /// <summary>
        /// 验证类(必须放在Service里)
        /// </summary>
        public class CustomUserNamePasswordValidator : System.IdentityModel.Selectors.UserNamePasswordValidator
        {
            public override void Validate(string userName, string password)
            {
                if (userName == null || password == null)
                    throw new NotImplementedException();
                else if (!(userName == "aaa" && password == "aaa"))
                {
                    throw new FaultException("username or password is wrong");
                }
            }
        }
    }
}
