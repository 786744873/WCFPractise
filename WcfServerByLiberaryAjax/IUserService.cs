using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;

namespace WcfServerByLiberaryAjax
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        [WebGet(UriTemplate = "GetUser/{id}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        User GetUser(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "Task/update", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        User ChangeUser(string id, string name, string age);


        [OperationContract]
        [WebInvoke(UriTemplate = "Task/del", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        User RemoveUser();
    }
}
