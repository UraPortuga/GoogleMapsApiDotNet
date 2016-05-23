using System.Collections.Generic;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Response
{
	public class PlaceAutocompleteResponse
	{
		public List<Prediction> predictions { get; set; }
		public string status { get; set; }
	}
}