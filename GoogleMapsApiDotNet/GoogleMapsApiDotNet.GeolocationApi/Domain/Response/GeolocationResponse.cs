using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.GeolocationApi.Domain.Response
{
	public class GeolocationResponse
	{
		public Location Location { get; set; }
		public int Accuracy { get; set; }
	}
}
