using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;

namespace RestApi
{
    [ServiceContract]
    public interface IRestService
    {

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,

              BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetAll")]
       
        List<string> GetAllTutorial();

        [WebInvoke(Method = "Post", ResponseFormat = WebMessageFormat.Json,

             BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetAllId")]
        [OperationContract]
         String GetAllTutorialbyId(string TutorialId);
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Add")]
        [OperationContract]
        void AddTutorial(string str);

        [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Delete") ]
        void DeleteTutorial(string str);

    }
}