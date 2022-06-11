using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class sampleController : ApiController
    {
        static List<string> strings = new List<string> { "Data 1", "Data 2", "Data 3", "Data 4" };

        public IEnumerable<string>Get()
        {
            return strings;
        }
        public string Get(int id)
        {
            return strings[id];
        }
    }
}
