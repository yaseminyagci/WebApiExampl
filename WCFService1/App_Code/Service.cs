using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
[ServiceContract(Namespace = "")]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class Service :IService
{
    private static List<string> array = new List<string>(new String[] { "Arrays", "Queues", "Stacks" });
    [WebGet(UriTemplate = "/Tutorial")]
    public String GetAllTutorial()
    {
        int count = array.Count;
        String TutorialList = "";
        for (int i = 0; i < count; i++)
            TutorialList = TutorialList + array[i] + ",";
        return TutorialList;
    }
    [WebGet(UriTemplate = "/Tutorial/{Tutorialid}")]
    public String GetAllTutorialbyId(string TutorialId)
    {
        int pid;
        Int32.TryParse(TutorialId, out pid);//Burada pid içine Tutorialid yi int veri tipinde aktarıyor.
        return array[pid];
    }
    [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
        UriTemplate = ("/Tutorial"), ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]

    public void AddTutorial(string str)
    {

        array.Add(str);
    }
    [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json,
               UriTemplate = ("/Tutorial"), ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
    public void DeleteTutorial(string str)
    {
        int pid;
        Int32.TryParse(str, out pid);
        array.RemoveAt(pid);
    }
}
