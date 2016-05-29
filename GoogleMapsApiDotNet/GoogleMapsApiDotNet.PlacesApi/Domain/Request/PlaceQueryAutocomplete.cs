using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public partial class PlaceQueryAutocomplete : Base
	{
		[JsonProperty("input")]
		public string Input { get; set; }

		[JsonProperty("location")]
		public string Location { get; set; }

		[JsonProperty("offset")]
		public string Offset { get; set; }

		[JsonProperty("radius")]
		public string Radius { get; set; }

		[JsonProperty("language")]
		public string Language { get; set; }
	}
}