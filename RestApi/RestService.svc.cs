using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace RestApi
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestService : IRestService
    {

        private static List<string> array = new List<string>(new String[] { "Arrays", "Queues", "Stacks" });
        public List<string> GetAllTutorial()
        {
            int count = array.Count;
            List<string> TutorialList= new List<string> ();
            for (int i = 0; i < count; i++)
                TutorialList.Add(array[i]);
            return TutorialList;
        }
        public String GetAllTutorialbyId(string TutorialId)
        {
            int pid;
            Int32.TryParse(TutorialId, out pid);//Burada pid içine Tutorialid yi int veri tipinde aktarıyor.
            return array[pid];
        }
        public void AddTutorial(string str)
        {

            array.Add(str);
        }
        public void DeleteTutorial(string str)
        {
            int pid;
            Int32.TryParse(str, out pid);
            array.RemoveAt(pid);
        }

    }
}
