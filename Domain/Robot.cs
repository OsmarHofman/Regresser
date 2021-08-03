using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Regresser
{
    public class Robot
    {
        public Guid TestId { get; set; }

        public string RobotName { get; set; }

        public List<Actions> actions { get; set; }

        private static readonly HttpClient client = new HttpClient();

        public async Task<HttpResponseMessage> SendActions()
        {
            var values = new List<Robot>
            {
                new Robot
                {
                    TestId = Guid.NewGuid(),
                    RobotName = "userbolt",
                    actions = new List<Actions>
                    {
                       new Actions
                       {
                           type = "timeout",
                           timeout = 4000
                       }
                    }
                }
            };

            var json = JsonConvert.SerializeObject(values);

            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("http://localhost:3001/actions",httpContent);

            Console.WriteLine(response);

            return response;
        }
    }
}
