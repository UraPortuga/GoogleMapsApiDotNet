using System.Collections.Generic;

namespace GoogleMapsApiDotNet.PlacesApi.Domain
{
	public class Prediction
	{
		public string Description { get; set; }
		public string Id { get; set; }
		public string Place_id { get; set; }
		public string Reference { get; set; }

		public List<MatchedSubstring> Matched_substrings { get; set; } = new List<MatchedSubstring>();
		public List<Term> Terms { get; set; } = new List<Term>();
		public List<string> Types { get; set; } = new List<string>();
	}
}