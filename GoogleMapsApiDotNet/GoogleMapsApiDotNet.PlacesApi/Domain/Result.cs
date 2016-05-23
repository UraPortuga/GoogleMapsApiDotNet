using System.Collections.Generic;

namespace GoogleMapsApiDotNet.PlacesApi.Domain
{
	public class Result
	{
		public Geometry Geometry { get; set; }
		public string Icon { get; set; }
		public string Id { get; set; }
		public string Name { get; set; }
		public OpeningHours Opening_hours { get; set; }
		public List<Photo> Photos { get; set; } = new List<Photo>();
		public string Place_id { get; set; }
		public string Reference { get; set; }
		public string Scope { get; set; }
		public List<string> Types { get; set; } = new List<string>();
		public string Vicinity { get; set; }
		public double? Rating { get; set; }
	}
}