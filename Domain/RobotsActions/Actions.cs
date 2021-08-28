using Newtonsoft.Json;
using Regresser.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Regresser.Domain.RobotsActions
{
    [JsonConverter(typeof(BaseConverter))]
    public abstract class Actions
    {
    }
}
