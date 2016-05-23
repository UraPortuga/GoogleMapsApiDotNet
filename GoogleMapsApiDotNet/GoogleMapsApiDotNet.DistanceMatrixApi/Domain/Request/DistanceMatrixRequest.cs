using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.DistanceMatrixApi.Domain.Request
{
	public class DistanceMatrixRequest : BaseRequest
	{
		public List<string> Origin { get; set; } = new List<string>();
		public List<string> Destination { get; set; } = new List<string>();
		public string Mode { get; set; }
		public string Avoid { get; set; }
		public string Language { get; set; }
		public string Units { get; set; }
		public string Region { get; set; }
		public string ArrivalTime { get; set; }
		public string DepartureTime { get; set; }
		public string TrafficModel { get; set; }
		public string TransitMode { get; set; }
		public string TransitRoutingPreference { get; set; }
	}
}
