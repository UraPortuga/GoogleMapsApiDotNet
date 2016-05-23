using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.DistanceMatrixApi.Domain
{
	public class Element
	{
		public Distance Distance { get; set; }
		public Duration Duration { get; set; }
		public string Status { get; set; }
	}
}
