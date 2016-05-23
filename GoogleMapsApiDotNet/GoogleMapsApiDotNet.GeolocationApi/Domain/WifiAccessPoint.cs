namespace GoogleMapsApiDotNet.GeolocationApi.Domain
{
	public class WifiAccessPoint
	{
		public string MacAddress { get; set; }
		public int SignalStrength { get; set; }
		public int Age { get; set; }
		public int Channel { get; set; }
		public int SignalToNoiseRatio { get; set; }
	}
}