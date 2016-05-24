using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.Domain.Domain
{
	public class BaseRequest
	{
		[JsonProperty("key")]
		public string Key { get; set; }
	}
}