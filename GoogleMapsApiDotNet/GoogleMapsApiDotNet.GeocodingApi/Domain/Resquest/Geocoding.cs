using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.GeocodingApi.Domain.Resquest
{
	public partial class Geocoding : Base
	{
		[JsonProperty("address")]
		private string Address { get; set; }

		[JsonProperty("components")]
		private string Components { get; set; }

		[JsonProperty("bounds")]
		private List<string> Bounds { get; set; }

		[JsonProperty("language")]
		private string Language { get; set; }

		[JsonProperty("region")]
		private string Region { get; set; }
	}
}