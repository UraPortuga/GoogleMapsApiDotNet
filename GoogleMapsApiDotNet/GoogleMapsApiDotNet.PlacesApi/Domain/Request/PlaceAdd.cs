using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public class PlaceAdd
	{
		[JsonProperty("location")]
		public Location Location { get; set; }

		[JsonProperty("accuracy")]
		public int Accuracy { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("phone_number")]
		public string PhoneNumber { get; set; }
		
		[JsonProperty("address")]
		public string Address { get; set; }
		
		[JsonProperty("types")]
		public List<string> Types { get; set; }
		
		[JsonProperty("website")]
		public string Website { get; set; }
		
		[JsonProperty("language")]
		public string Language { get; set; }
	}
}