using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.DirectionsApi.Domain
{
	public class Bounds
	{
		public Location Northeast { get; set; }
		public Location Southwest { get; set; }
	}
}
