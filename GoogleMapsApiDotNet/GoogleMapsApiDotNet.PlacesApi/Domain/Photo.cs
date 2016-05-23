using System.Collections.Generic;

namespace GoogleMapsApiDotNet.PlacesApi.Domain
{
	public class Photo
	{
		public int Height { get; set; }
		public List<string> Html_attributions { get; set; } = new List<string>();
		public string Photo_reference { get; set; }
		public int Width { get; set; }
	}
}