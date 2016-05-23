using System.Collections.Generic;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Response
{
	public class PlaceTextSearchResponse
	{
		public List<object> Html_attributions { get; set; }
		public string Next_page_token { get; set; }
		public List<Result> Results { get; set; }
		public string Status { get; set; }
	}
}