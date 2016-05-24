using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.ElevationApi.Domain
{
	public class Result
	{
		public double Elevation { get; set; }
		public Location Location { get; set; }
		public double Resolution { get; set; }
	}
}