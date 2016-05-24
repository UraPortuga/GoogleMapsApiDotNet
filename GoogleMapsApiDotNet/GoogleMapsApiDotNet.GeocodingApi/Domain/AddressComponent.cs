using System.Collections.Generic;

namespace GoogleMapsApiDotNet.GeocodingApi.Domain
{
	public class AddressComponent
	{
		public string Long_name { get; set; }
		public string Short_name { get; set; }
		public List<string> Types { get; set; }
	}
}