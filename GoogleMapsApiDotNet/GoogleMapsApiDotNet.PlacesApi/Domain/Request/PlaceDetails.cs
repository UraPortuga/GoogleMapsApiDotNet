using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public class PlaceDetails : Base
	{
		public string PlaceId { get; set; }
		public string Reference { get; set; }
		public string Extensions { get; set; }
		public string Language { get; set; }
	}
}