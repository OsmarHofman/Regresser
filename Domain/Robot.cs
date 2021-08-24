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

        public Robot () { }

        public Robot(string robotName, List<Actions> actions)
        {
            TestId = Guid.NewGuid();
            RobotName = robotName;
            this.actions = actions;
        }

        public async Task<HttpResponseMessage> SendActions()
        {
            var jarvis = new Robot
            {
                TestId = Guid.NewGuid(),
                RobotName = "jarvis",
                actions = new List<Actions>
                {
                    new JarvisActions
                    {
                        URL_WS_OTM = "http://191.239.245.232:1048/tmsExchangeMessage/TMSExchangeMessage.asmx",
                        Shipments = new List<Shipment>
                        {
                            new Shipment
                            {
                                ShipmentDomainName = "EMBDEV",
                                ShipmentXid = "EMBARQUE-1",
                                TravelStatus = "PLANEJADO",
                                EmissionStatus = "PRE_EMISSAO_ENVIADA",
                                XidCarrier = "Carrier",
                                XidSourceLocation = "Source",
                                XidDestinationLocation = "Destination",
                                XidTakerLocation = "Taker",
                                AddedTax = "N",
                                TaxIncluded = "N",
                                ShipmentCosts = new List<ShipmentCost>
                                {
                                    new ShipmentCost
                                    {
                                        CostType = "B",
                                        Value = 900.00f,
                                        AllocateCost = true,
                                    }
                                },
                                Releases = new List<Release>
                                {
                                    new Release
                                    {
                                        ReleaseDomainName = "EMBDEV",
                                        ReleaseXid = "ORDEM-1"
                                    }
                                }

                            }
                        }
                    }
                }
            };

            var userbolt = new Robot
            {
                TestId = Guid.NewGuid(),
                RobotName = "userbolt",
                actions = new List<Actions>
                {
                    new UserBoltActions
                    {
                        type = "timeout",
                        timeout = 4000
                    }
                }
            };

            var robots = new List<Robot>
            {
                jarvis, userbolt
            };

            var json = JsonConvert.SerializeObject(robots);

            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("http://localhost:3001/actions", httpContent);

            Console.WriteLine(response);

            return response;
        }
    }
}
