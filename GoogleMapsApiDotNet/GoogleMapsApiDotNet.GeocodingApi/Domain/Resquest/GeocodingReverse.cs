using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.GeocodingApi.Domain.Resquest
{
	public partial class GeocodingReverse : Base
	{
		[JsonProperty("latlng")]
		private string LatLng { get; set; }

		[JsonProperty("place_id")]
		private string PlaceId { get; set; }

		[JsonProperty("result_type")]
		private string ResultType { get; set; }

		[JsonProperty("location_type")]
		private string LocationType { get; set; }
	}
}