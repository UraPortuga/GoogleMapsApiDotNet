using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public class PlacePhotoRequest :BaseRequest
	{
		public string PhotoReference { get; set; }
		public string MaxHeight { get; set; }
		public string MaxWidth { get; set; }
	}
}