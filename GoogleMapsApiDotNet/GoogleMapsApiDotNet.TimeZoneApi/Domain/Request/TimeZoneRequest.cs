using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.TimeZoneApi.Domain.Request
{
	public class TimeZoneRequest : BaseRequest
	{
		public string Location { get; set; }
		public string Timestamp { get; set; }
		public string Language { get; set; }
	}
}