using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.RoadsApi.Domain.Request
{
	public class SnapRoads : BaseRequest
	{
		[JsonProperty("path")]
		public List<string> Path { get; set; }

		[JsonProperty("interpolate")]
		public string Interpolate { get; set; }
	}
}