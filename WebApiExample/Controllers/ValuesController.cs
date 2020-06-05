using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiExample.Models;

namespace WebApiExample.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public PuantajInfo[] Get()
        {
         GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            DateTime start = DateTime.Parse("2019-5-1");
            DateTime end = DateTime.Parse("2019-6-1");

            PuantajInfo[] dat = new PuantajInfo[] { };
            PuantajInfo[] puant = new PuantajInfo[]{
                new PuantajInfo{
                PuantajName= "ll",
                PuantajData = 5,
                Start= "dcsdcsd"
        },     new PuantajInfo{
                PuantajName= "mmm",
                PuantajData = 6,
                  Start= "dcsdcsd"
        },     new PuantajInfo{
                PuantajName= "nnn",
                PuantajData = 10,
                 Start= "dcsdcsd"
        },     new PuantajInfo{
                PuantajName= "kkk",
                PuantajData = 11,
                 Start= "tyhty"
        }
    };
            if (end > start)
            {

            }

            return puant;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
