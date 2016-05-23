using System.Collections.Generic;

namespace GoogleMapsApiDotNet.PlacesApi.Domain
{
	public class PredictionQuery
	{
		public string Description { get; set; }
		public List<MatchedSubstring> Matched_substrings { get; set; } = new List<MatchedSubstring>();
		public List<Term> Terms { get; set; } = new List<Term>();
	}
}