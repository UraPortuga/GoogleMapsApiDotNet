using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.RoadsApi.Domain.Request
{
	public class SpeedLimitRequest : BaseRequest
	{
		public List<string> Path { get; set; }
		public string[] PlaceId { get; set; }
		public string Units { get; set; }
	}
}