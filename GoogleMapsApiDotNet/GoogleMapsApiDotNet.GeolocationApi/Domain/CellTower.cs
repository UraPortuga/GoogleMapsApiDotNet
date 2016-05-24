using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.GeolocationApi.Domain
{
	public class CellTower
	{
		[JsonProperty("cellId")]
		public int CellId { get; set; }

		[JsonProperty("locationAreaCode")]
		public int LocationAreaCode { get; set; }

		[JsonProperty("mobileCountryCode")]
		public int MobileCountryCode { get; set; }

		[JsonProperty("mobileNetworkCode")]
		public int MobileNetworkCode { get; set; }

		[JsonProperty("age")]
		public int Age { get; set; }

		[JsonProperty("signalStrength")]
		public int SignalStrength { get; set; }

		[JsonProperty("timingAdvance")]
		public int TimingAdvance { get; set; }
	}
}