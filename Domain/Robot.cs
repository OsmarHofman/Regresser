using Newtonsoft.Json;
using Regresser.Domain.RobotsActions;
using Regresser.Domain.Shipper;
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

        public Robot() { }

        public Robot(string robotName, List<Actions> actions)
        {
            TestId = Guid.NewGuid();
            RobotName = robotName;
            this.actions = actions;
        }

        public static async Task<HttpResponseMessage> SendActions(List<Robot> robots)
        {
            var json = JsonConvert.SerializeObject(robots,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("http://localhost:3001/actions", httpContent);

            Console.WriteLine(response);

            return response;
        }
    }
}
