using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;



namespace GoogleMapsApiDotNet.GeocodingApi.Domain.Resquest
{
	public class Geocoding : Base
	{
		[JsonProperty("address")]
		public string Address { get; set; }

		[JsonProperty("components")]
		public string Components { get; set; }
		
		[JsonProperty("bounds")]
		public List<string> Bounds { get; set; }

		[JsonProperty("language")]
		public string Language { get; set; }

		[JsonProperty("region")]
		public string Region { get; set; }

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