using System.Collections.Generic;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Response
{
	public class PlaceRadarSearchResponse
	{
		public List<object> Html_attributions { get; set; }
		public List<Result> Results { get; set; }
		public string Status { get; set; }
	}
}