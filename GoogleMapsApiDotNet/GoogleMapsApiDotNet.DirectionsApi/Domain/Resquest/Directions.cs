using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.DirectionsApi.Domain.Resquest
{
	public partial class Directions : Base
	{
		[JsonProperty("origin")]
		private string Origin { get; set; }

		[JsonProperty("destination")]
		private List<string> Destination { get; set; } = new List<string>();

		[JsonProperty("mode")]
		private string Mode { get; set; }

		[JsonProperty("waypoints")]
		private List<string> Waypoints { get; set; } = new List<string>();

		[JsonProperty("alternatives")]
		private string Alternatives { get; set; }

		[JsonProperty("avoid")]
		private string Avoid { get; set; }

		[JsonProperty("language")]
		private string Language { get; set; }

		[JsonProperty("units")]
		private string Units { get; set; }

		[JsonProperty("region")]
		private string Region { get; set; }

		[JsonProperty("arrival_time")]
		private string ArrivalTime { get; set; }

		[JsonProperty("departure_time")]
		private string DepartureTime { get; set; }

		[JsonProperty("traffic_model")]
		private string TrafficModel { get; set; }

		[JsonProperty("transit_mode")]
		private string TransitMode { get; set; }

		[JsonProperty("transit_routing_preference")]
		private string TransitRoutingPreference { get; set; }
	}
}