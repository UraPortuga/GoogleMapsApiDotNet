using System.Collections.Generic;

namespace GoogleMapsApiDotNet.PlacesApi.Domain
{
	public class ResultDetail
	{
		public string Scope { get; set; }
		public string Adr_address { get; set; }
		public string Formatted_address { get; set; }
		public string Formatted_phone_number { get; set; }
		public string Icon { get; set; }
		public string Id { get; set; }
		public string International_phone_number { get; set; }
		public string Name { get; set; }
		public string Place_id { get; set; }
		public double Rating { get; set; }
		public string Reference { get; set; }
		public string Url { get; set; }
		public int User_ratings_total { get; set; }
		public int Utc_offset { get; set; }
		public string Vicinity { get; set; }
		public string Website { get; set; }

		public List<AddressComponent> Address_components { get; set; } = new List<AddressComponent>();
		public Geometry Geometry { get; set; } = new Geometry();
		public OpeningHoursDetail Opening_hours { get; set; } = new OpeningHoursDetail();
		public List<Photo> Photos { get; set; } = new List<Photo>();
		public List<Review> Reviews { get; set; } = new List<Review>();
		public List<string> Types { get; set; } = new List<string>();
	}
}