using System.Collections.Generic;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Response
{
	public class PlaceQueryAutocomplete
	{
		public List<PredictionQuery> Predictions { get; set; }
		public string Status { get; set; }
	}
}