using Newtonsoft.Json;
using Regresser.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Regresser.Domain.RobotsActions
{
    [JsonConverter(typeof(BaseConverter))]
    public abstract class Actions
    {
        public virtual TreeNode ToStringAsTreeNodes()
        {
            throw new NotImplementedException("Dados carregados, porém não foi feito tratamento para visualização!");
        }
    }
}
