using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.RoadsApi.Domain.Request
{
	public partial class SpeedLimit : Base
	{
		[JsonProperty("path")]
		private List<string> Path { get; set; }

		[JsonProperty("placeId")]
		private string[] PlaceId { get; set; }

		[JsonProperty("units")]
		private string Units { get; set; }
	}
}