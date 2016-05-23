using GoogleMapsApiDotNet.Domain.Domain;
using System.Collections.Generic;

namespace GoogleMapsApiDotNet.DirectionsApi.Domain
{
	public class Leg
	{
		public Distance Distance { get; set; }
		public Duration Duration { get; set; }
		public string End_address { get; set; }
		public Location End_location { get; set; }
		public string Start_address { get; set; }
		public Location Start_location { get; set; }
		public List<Step> Steps { get; set; }
		public List<object> Traffic_speed_entry { get; set; }
		public List<object> Via_waypoint { get; set; }
	}

}
