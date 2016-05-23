using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public class PlaceAddRequest
	{
		public Location Location { get; set; }
		public int Accuracy { get; set; }
		public string Name { get; set; }
		public string Phone_number { get; set; }
		public string Address { get; set; }
		public List<string> Types { get; set; }
		public string Website { get; set; }
		public string Language { get; set; }
	}
}