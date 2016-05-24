using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.RoadsApi.Domain.Request
{
	public class SpeedLimit : BaseRequest
	{
		[JsonProperty("path")]
		public List<string> Path { get; set; }

		[JsonProperty("placeId")]
		public string[] PlaceId { get; set; }

		[JsonProperty("units")]
		public string Units { get; set; }
	}
}