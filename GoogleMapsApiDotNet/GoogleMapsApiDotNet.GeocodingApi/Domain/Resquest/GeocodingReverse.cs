using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.GeocodingApi.Domain.Resquest
{
	public class GeocodingReverse : Base
	{
		[JsonProperty("latlng")]
		public string LatLng { get; set; }

		[JsonProperty("place_id")]
		public string PlaceId { get; set; }

		[JsonProperty("result_type")]
		public string ResultType { get; set; }

		[JsonProperty("location_type")]
		public string LocationType { get; set; }
	}
}