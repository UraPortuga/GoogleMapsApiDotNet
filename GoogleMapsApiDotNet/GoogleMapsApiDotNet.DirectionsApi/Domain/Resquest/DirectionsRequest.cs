using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.DirectionsApi.Domain.Resquest
{
	public class DirectionsRequest : BaseRequest
	{
		public string Origin { get; set; }
		public List<string> Destination { get; set; }
		public string Mode { get; set; }
		public List<string> Waypoints { get; set; }
		public string Alternatives { get; set; }
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