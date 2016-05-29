namespace GoogleMapsApiDotNet.TimeZoneApi.Domain.Request
{
	public partial class TimeZone
	{
		public TimeZone WithLanguage(string language)
		{
			Language = language;
			return this;
		}

		public TimeZone WithLocation(string location)
		{
			Location = location;
			return this;
		}

		public TimeZone WithTimestamp(string timestamp)
		{
			Timestamp = timestamp;
			return this;
		}
	}
}