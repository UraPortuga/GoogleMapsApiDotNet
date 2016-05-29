using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public partial class PlacePhoto : Base
	{
		[JsonProperty("photoreference")]
		public string PhotoReference { get; set; }

		[JsonProperty("maxheight")]
		public string MaxHeight { get; set; }

		[JsonProperty("maxwidth")]
		public string MaxWidth { get; set; }
	}
}