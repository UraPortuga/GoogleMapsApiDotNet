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
	}
}