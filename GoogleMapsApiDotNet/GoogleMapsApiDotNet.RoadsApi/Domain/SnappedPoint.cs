using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.RoadsApi.Domain.Response
{
	public class SnappedPoint
	{
		public Location Location { get; set; }
		public int OriginalIndex { get; set; }
		public string PlaceId { get; set; }
	}
}
