using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.ElevationApi.Domain.Request
{
	public partial class Elevation : Base
	{
		[JsonProperty("locations")]
		private List<string> Locations { get; set; }

		[JsonProperty("path")]
		private string Path { get; set; }

		[JsonProperty("samples")]
		private string Samples { get; set; }
	}
}