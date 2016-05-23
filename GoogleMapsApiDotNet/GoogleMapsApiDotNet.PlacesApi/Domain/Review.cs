using System.Collections.Generic;

namespace GoogleMapsApiDotNet.PlacesApi.Domain
{
	public class Review
	{
		public List<Aspect> Aspects { get; set; } = new List<Aspect>();
		public string Author_name { get; set; }
		public string Author_url { get; set; }
		public string Language { get; set; }
		public string Profile_photo_url { get; set; }
		public int Rating { get; set; }
		public string Text { get; set; }
		public int Time { get; set; }
	}
}