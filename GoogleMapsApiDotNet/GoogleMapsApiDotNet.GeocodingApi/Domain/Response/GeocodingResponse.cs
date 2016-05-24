using System.Collections.Generic;

namespace GoogleMapsApiDotNet.GeocodingApi.Domain.Response
{
	public class GeocodingResponse
	{
		public List<Result> Results { get; set; }
		public string Status { get; set; }
	}
}