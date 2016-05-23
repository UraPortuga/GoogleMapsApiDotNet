using System.Collections.Generic;

namespace GoogleMapsApiDotNet.ElevationApi.Domain.Response
{
	public class ElevationResponse
	{
		public List<Result> Results { get; set; }
		public string Status { get; set; }
	}
}
