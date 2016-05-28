using System.Collections.Generic;

namespace GoogleMapsApiDotNet.GeocodingApi.Domain
{
	public class Result
	{
		public List<AddressComponent> Address_components { get; set; }
		public bool Partial_match { get; set; }
		public string Formatted_address { get; set; }
		public Geometry Geometry { get; set; }
		public string Place_id { get; set; }
		public List<string> Types { get; set; }
	}
}