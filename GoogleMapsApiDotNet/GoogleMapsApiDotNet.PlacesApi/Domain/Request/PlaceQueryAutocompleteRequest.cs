using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public class PlaceQueryAutocompleteRequest : BaseRequest
	{
		public string Input { get; set; }
		public string Location { get; set; }
		public string Offset { get; set; }
		public string Radius { get; set; }
		public string Language { get; set; }
	}
}