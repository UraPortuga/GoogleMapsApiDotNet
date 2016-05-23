using System.Collections.Generic;

namespace GoogleMapsApiDotNet.DirectionsApi.Domain
{
	public class Route
	{
		public Bounds Bounds { get; set; }
		public string Copyrights { get; set; }
		public List<Leg> Legs { get; set; }
		public Polyline Overview_Polyline { get; set; }
		public string Summary { get; set; }
		public List<string> Warnings { get; set; }
		public List<object> Waypoint_order { get; set; }
	}
}
