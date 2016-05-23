namespace GoogleMapsApiDotNet.TimeZoneApi.Domain.Response
{
	public class TimeZoneResponse
	{
		public int DstOffset { get; set; }
		public int RawOffset { get; set; }
		public string Status { get; set; }
		public string TimeZoneId { get; set; }
		public string TimeZoneName { get; set; }
	}
}
