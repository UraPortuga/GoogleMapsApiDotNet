using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.Domain.Domain
{
	public class Location
	{
		[JsonProperty("lat")]
		public double Latitude { get; set; }

		[JsonProperty("lng")]
		public double Longitude { get; set; }
	}
}