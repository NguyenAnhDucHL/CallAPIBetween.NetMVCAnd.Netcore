using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebA.Proxies;

namespace WebA.Controllers
{
    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class ValuesController : ApiController
    {

        [HttpGet]
        // GET api/values/5
        [Route("api/TestDuc()")]
        public string TestDuc()
        {
            var connection = new CommerceClient();
            People people = new People();
            people.Name = "Helloworld";
            people.Age = 18;
            var content = JsonConvert.SerializeObject(people);
            var commerceResults = connection.InvokeHttpClientPut("api/Demo()", content);

            People people1 = new People();
            people1.Name = "Demomomomom";
            people1.Age = 100;
            var content1 = JsonConvert.SerializeObject(people1);
            var commerceResults2 = connection.InvokeHttpClientPost("api/DemoDemo()", content1);

            People people2 = new People();
            people2.Name = "Demomomomom";
            people2.Age = 100;
            var content2 = JsonConvert.SerializeObject(people2);
            var commerceResults3 = connection.InvokeHttpClientGet("api/DemoGet()", content2);


            People people3 = new People();
            people3.Name = "DemoDeleteDemoDeleteDemoDelete";
            people3.Age = 2222;
            var content3 = JsonConvert.SerializeObject(people3);
            var commerceResults4 = connection.InvokeHttpClientDelete("api/DemoDelete()", content3);

            return (commerceResults + commerceResults2 + commerceResults3 + commerceResults4);
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
