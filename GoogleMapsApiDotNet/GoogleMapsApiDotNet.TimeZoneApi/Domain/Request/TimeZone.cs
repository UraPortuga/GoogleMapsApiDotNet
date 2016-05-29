using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.TimeZoneApi.Domain.Request
{
	public partial class TimeZone : Base
	{
		[JsonProperty("location")]
		private string Location { get; set; }

		[JsonProperty("timestamp")]
		private string Timestamp { get; set; }

		[JsonProperty("language")]
		private string Language { get; set; }
	}
}