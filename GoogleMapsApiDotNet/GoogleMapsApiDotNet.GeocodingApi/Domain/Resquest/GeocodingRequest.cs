using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.GeocodingApi.Domain.Resquest
{
	public class GeocodingRequest : BaseRequest
	{
		public string Address { get; set; }
		public string Components { get; set; }
		public List<string> Bounds { get; set; }
		public string Language { get; set; }
		public string Region { get; set; }
		public string LatLng { get; set; }
		public string PlaceId { get; set; }
		public string ResultType { get; set; }
		public string LocationType { get; set; }
	}
}