using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GoogleMapsApiDotNet.Domain.Domain
{
	public class Base : BaseRequest
	{
		[JsonProperty("key")]
		public string Key { get; set; }

		public string GetJson()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore});
		}

		public bool IsArray(JProperty pro)
		{
			return JTokenType.Array == pro.Type;
		}

		public StringBuilder SetBuilder(JProperty pro, StringBuilder builder)
		{
			builder.Append($"&{pro.Name.ToLower()}={pro.Value}");
			return builder;
		}

		public StringBuilder SetBuilderAsArray(JProperty pro, StringBuilder builder)
		{
			var array = (JArray) pro.Value;
			array.ToList()
				.ForEach(prop => { builder = IsArray(pro) ? SetBuilderAsArray(pro, builder) : SetBuilder(pro, builder); });
			return builder;
		}

		public override string ToString()
		{
			var builder = new StringBuilder();
			JObject.Parse(GetJson())
				.Properties()
				.ToList()
				.ForEach(pro => { builder = IsArray(pro) ? SetBuilderAsArray(pro, builder) : SetBuilder(pro, builder); });
			return builder.ToString();
		}

		public static T GetPropertyValue<T>(object o, string propertyName)
		{
			return (T) o.GetType().GetProperty(propertyName).GetValue(o, null);
		}
	}
}