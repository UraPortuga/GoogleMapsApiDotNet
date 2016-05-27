using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public class PlaceDelete : Base
	{
		[JsonProperty("place_id")]
		public string PlaceId { get; set; }

	}
}