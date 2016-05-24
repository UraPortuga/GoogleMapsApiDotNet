using System.Collections.Generic;

namespace GoogleMapsApiDotNet.DirectionsApi.Domain.Response
{
	public class DirectionsResponse
	{
		public List<GeocodedWaypoint> Geocoded_waypoints { get; set; }
		public List<Route> Routes { get; set; }
		public string Status { get; set; }
	}
}