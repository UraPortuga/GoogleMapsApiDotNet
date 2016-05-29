using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.RoadsApi.Domain.Request
{
	public partial class SnapRoads : Base
	{
		[JsonProperty("path")]
		private List<string> Path { get; set; }

		[JsonProperty("interpolate")]
		private string Interpolate { get; set; }
	}
}