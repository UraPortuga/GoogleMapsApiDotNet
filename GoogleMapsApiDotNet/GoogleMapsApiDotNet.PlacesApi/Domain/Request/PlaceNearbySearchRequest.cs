using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public class PlaceNearbySearchRequest : BaseRequest
	{
		public string Location { get; set; }
		public string Radius { get; set; }
		public string Rankby { get; set; }
		public string Keyword { get; set; }
		public string Language { get; set; }
		public string MinPrice { get; set; }
		public string MaxPrice { get; set; }
		public string Name { get; set; }
		public string OpenNow { get; set; }
		public string Types { get; set; }
		public string Pagetoken { get; set; }
		public string ZagatSelected { get; set; }
	}
}