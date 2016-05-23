using System.Collections.Generic;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Response
{
	public class PlaceDetailsResponse
	{
		public List<object> Html_attributions { get; set; }
		public ResultDetail Result { get; set; }
		public string Status { get; set; }
	}
}