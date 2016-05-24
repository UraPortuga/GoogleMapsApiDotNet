using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.ElevationApi.Domain.Request
{
	public class Elevation : BaseRequest
	{
		[JsonProperty("locations")]
		public List<string> Locations { get; set; }

		[JsonProperty("path")]
		public string Path { get; set; }

		[JsonProperty("samples")]
		public string Samples { get; set; }
	}
}