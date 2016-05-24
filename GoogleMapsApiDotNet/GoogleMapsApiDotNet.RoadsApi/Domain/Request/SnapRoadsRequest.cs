using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.RoadsApi.Domain.Request
{
	public class SnapRoadsRequest : BaseRequest
	{
		public List<string> Path { get; set; }
		public string Interpolate { get; set; }
	}
}