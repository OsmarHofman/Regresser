using Newtonsoft.Json;
using Regresser.Domain.RobotsActions;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

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

        public Robot(Robot robot)
        {
            TestId = Guid.NewGuid();
            RobotName = robot.RobotName;
            actions = new List<Actions>();
            actions.AddRange(robot.actions);
        }

        public static async Task<string> SendActions(List<Robot> robots)
        {
            var json = JsonConvert.SerializeObject(robots,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var postResponse = await client.PostAsync("http://localhost:3001/actions", httpContent);

            var responseString = postResponse.Content.ReadAsStringAsync().Result;

            return responseString;
        }

        public override string ToString()
        {
            return $"[{RobotName}]: {actions.First()}";
        }
    }
}
