using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleAPI
{
    [Route("[controller]")]
     public class ValuesController : Controller
    {
        // GET: api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "Sangeeta", "Kavita" };
        }

        // GET: api/values/5
        public string Get(int id)
        {
            return "Sangeeta";
        }
       
    }
}