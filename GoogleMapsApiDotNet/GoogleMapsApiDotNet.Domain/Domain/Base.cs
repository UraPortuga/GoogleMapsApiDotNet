using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.Domain.Domain
{
	public class Base : BaseRequest
	{
		[JsonProperty("key")]
		public string Key { get; set; }

		internal string GetJson()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
		}

		public override string ToString()
		{
			return GetJson();
		}
	}
}