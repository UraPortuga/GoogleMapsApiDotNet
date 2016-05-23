using System.Collections.Generic;

namespace GoogleMapsApiDotNet.PlacesApi.Domain
{
	public class OpeningHours
	{
		public bool Open_now { get; set; }
		public List<object> Weekday_text { get; set; } = new List<object>();
	}
}