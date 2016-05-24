using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.GeocodingApi.Domain
{
	public class Geometry
	{
		public Location Location { get; set; }
		public string Location_type { get; set; }
		public Viewport Viewport { get; set; }
		public Bounds Bounds { get; set; }
	}
}