using System.Collections.Generic;

namespace GoogleMapsApiDotNet.PlacesApi.Domain
{
	public class OpeningHoursDetail
	{
		public bool Open_now { get; set; }
		public List<Period> Periods { get; set; } = new List<Period>();
		public List<string> Weekday_text { get; set; } = new List<string>();
	}
}