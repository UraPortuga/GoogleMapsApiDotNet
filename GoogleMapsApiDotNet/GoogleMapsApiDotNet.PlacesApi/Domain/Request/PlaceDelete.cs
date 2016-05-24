using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public class PlaceDelete
	{
		[JsonProperty("place_id")]
		public string PlaceId { get; set; }
	}
}