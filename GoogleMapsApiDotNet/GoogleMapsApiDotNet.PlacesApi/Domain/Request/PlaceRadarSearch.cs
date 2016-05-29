using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public partial class PlaceRadarSearch : Base
	{
		[JsonProperty("location")]
		public string Location { get; set; }

		[JsonProperty("radius")]
		public string Radius { get; set; }

		[JsonProperty("keyword")]
		public string Keyword { get; set; }

		[JsonProperty("minprice")]
		public string MinPrice { get; set; }

		[JsonProperty("maxprice")]
		public string MaxPrice { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("opennow")]
		public string OpenNow { get; set; }

		[JsonProperty("types")]
		public string Types { get; set; }

		[JsonProperty("pagetoken")]
		public string Pagetoken { get; set; }

		[JsonProperty("zagatselected")]
		public string ZagatSelected { get; set; }
	}
}