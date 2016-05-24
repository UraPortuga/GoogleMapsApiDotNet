using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.TimeZoneApi.Domain.Request
{
	public class TimeZone : BaseRequest
	{
		[JsonProperty("location")]
		public string Location { get; set; }

		[JsonProperty("timestamp")]
		public string Timestamp { get; set; }

		[JsonProperty("language")]
		public string Language { get; set; }
	}
}