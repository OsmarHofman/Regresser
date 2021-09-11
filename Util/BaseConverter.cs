using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Regresser.Domain.RobotsActions;
using System;
using System.Text;

namespace Regresser.Util
{
    public class BaseConverter : JsonConverter
    {
        static JsonSerializerSettings SpecifiedSubclassConversion = new JsonSerializerSettings() { ContractResolver = new BaseSpecifiedConcreteClassConverter() };

        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Actions));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {

            JObject jo = JObject.Load(reader);

            if (HasKeys(jo, "UrlWs", "Shipments"))
                return JsonConvert.DeserializeObject<JarvisActions>(jo.ToString(), SpecifiedSubclassConversion);

            if (HasKeys(jo, "UrlWs", "Nfes"))
                return JsonConvert.DeserializeObject<GigibaActions>(jo.ToString(), SpecifiedSubclassConversion);

            if (HasKeys(jo, "UrlWs", "Ctes") || HasKeys(jo, "UrlWs", "Ctes", "ComplementaryCtes"))
                return JsonConvert.DeserializeObject<BinoActions>(jo.ToString(), SpecifiedSubclassConversion);

            if (HasKeys(jo, "Type", "Timeout"))
                return JsonConvert.DeserializeObject<UserBoltActions>(jo.ToString(), SpecifiedSubclassConversion);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in jo.Children())
            {
                stringBuilder.Append(item.Path.ToString() + ";");
            }

            throw new NotImplementedException($"Erro ao tentar converter os dados lidos para a estrutura de algum dos robôs com seguintes actions: {stringBuilder}\n\n OBS.: Não esqueça de colocar as chaves sempre com camelcase e iniciando em maiuscula, com exceção ao actions (Ex.: Ctes, Shipments, actions,etc).");
        }

        private bool HasKeys(JObject jo, params string[] keys)
        {
            int keysFoundCount = 0;

            foreach (var key in keys)
            {
                if (jo.ContainsKey(key) || jo.ContainsKey(key.ToLower())) keysFoundCount++;
            }

            return keysFoundCount == keys.Length;
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException(); // won't be called because CanWrite returns false
        }
    }

    public class BaseSpecifiedConcreteClassConverter : DefaultContractResolver
    {
        protected override JsonConverter ResolveContractConverter(Type objectType)
        {
            if (typeof(Actions).IsAssignableFrom(objectType) && !objectType.IsAbstract)
                return null; // pretend TableSortRuleConvert is not specified (thus avoiding a stack overflow)

            return base.ResolveContractConverter(objectType);
        }
    }
}
