using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;

namespace WcfServerByLiberary
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        [WebInvoke(UriTemplate="Task/{id}", Method = "GET",RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json)]
        User GetUser(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "Task/add", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        User AddUser(User u);

        [OperationContract]
        [WebInvoke(UriTemplate = "Task/up", Method = "PUT", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        User ChangeUser(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "Task/del", Method = "DELETE", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        User RemoveUser();
    }
}
