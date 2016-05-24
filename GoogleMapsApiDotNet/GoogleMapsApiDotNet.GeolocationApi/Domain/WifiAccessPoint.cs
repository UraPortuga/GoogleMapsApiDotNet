using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.GeolocationApi.Domain
{
	public class WifiAccessPoint
	{
		[JsonProperty("macAddress")]
		public string MacAddress { get; set; }

		[JsonProperty("signalStrength")]
		public int SignalStrength { get; set; }

		[JsonProperty("age")]
		public int Age { get; set; }

		[JsonProperty("channel")]
		public int Channel { get; set; }

		[JsonProperty("signalToNoiseRatio")]
		public int SignalToNoiseRatio { get; set; }
	}
}