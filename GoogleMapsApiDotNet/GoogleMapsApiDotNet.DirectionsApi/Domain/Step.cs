using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.DirectionsApi.Domain
{
	public class Step
	{
		public Distance Distance { get; set; }
		public Duration Duration { get; set; }
		public Location End_location { get; set; }
		public string Html_instructions { get; set; }
		public Polyline Polyline { get; set; }
		public Location Start_location { get; set; }
		public string Travel_mode { get; set; }
		public string Maneuver { get; set; }
	}
}