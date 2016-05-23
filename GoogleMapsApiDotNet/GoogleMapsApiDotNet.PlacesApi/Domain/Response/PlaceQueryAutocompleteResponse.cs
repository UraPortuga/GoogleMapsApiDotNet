using System.Collections.Generic;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Response
{
	public class PlaceQueryAutocompleteResponse
	{
		public List<PredictionQuery> Predictions { get; set; }
		public string Status { get; set; }
	}
}