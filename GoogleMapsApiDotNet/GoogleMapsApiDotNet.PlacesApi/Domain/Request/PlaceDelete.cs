using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public partial class PlaceDelete : Base
	{
		[JsonProperty("place_id")]
		public string PlaceId { get; set; }
	}
}