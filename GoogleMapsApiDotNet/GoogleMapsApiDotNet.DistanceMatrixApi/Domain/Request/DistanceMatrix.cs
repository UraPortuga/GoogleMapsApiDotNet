using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.DistanceMatrixApi.Domain.Request
{
	public partial class DistanceMatrix : Base
	{
		[JsonProperty("origins")]
		public List<string> Origins { get; set; } = new List<string>();

		[JsonProperty("destinations")]
		public List<string> Destination { get; set; } = new List<string>();

		[JsonProperty("mode")]
		public string Mode { get; set; }

		[JsonProperty("avoid")]
		public string Avoid { get; set; }

		[JsonProperty("language")]
		public string Language { get; set; }

		[JsonProperty("units")]
		public string Units { get; set; }

		[JsonProperty("region")]
		public string Region { get; set; }

		[JsonProperty("arrival_time")]
		public string ArrivalTime { get; set; }

		[JsonProperty("departure_time")]
		public string DepartureTime { get; set; }

		[JsonProperty("traffic_model")]
		public string TrafficModel { get; set; }

		[JsonProperty("transit_mode")]
		public string TransitMode { get; set; }

		[JsonProperty("transit_routing_preference")]
		public string TransitRoutingPreference { get; set; }
	}
}