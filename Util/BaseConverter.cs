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

            if (HasKeys(jo, "URL_WS_OTM", "Shipments"))
                return JsonConvert.DeserializeObject<JarvisActions>(jo.ToString(), SpecifiedSubclassConversion);

            if (HasKeys(jo, "type", "timeout"))
                return JsonConvert.DeserializeObject<UserBoltActions>(jo.ToString(), SpecifiedSubclassConversion);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in jo.Children())
            {
                stringBuilder.Append(item.Path.ToString() + ";");
            }

            throw new NotImplementedException($"Erro ao tentar converter os dados lidos para a estrutura de algum dos robôs com seguintes actions: {stringBuilder}");
        }

        private bool HasKeys(JObject jo, params string[] keys)
        {
            int keysFoundCount = 0;

            foreach (var key in keys)
            {
                if (jo.ContainsKey(key)) keysFoundCount++;
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
