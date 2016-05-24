using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;
using Newtonsoft.Json;

namespace GoogleMapsApiDotNet.GeolocationApi.Domain.Request
{
	public class Geolocation : BaseRequest
	{
		[JsonProperty("homeMobileCountryCode")]
		public int HomeMobileCountryCode { get; set; }
		
		[JsonProperty("homeMobileNetworkCode")]
		public int HomeMobileNetworkCode { get; set; }

		[JsonProperty("radioType")]
		public string RadioType { get; set; }

		[JsonProperty("carrier")]
		public string Carrier { get; set; }

		[JsonProperty("considerIp")]
		public string ConsiderIp { get; set; }

		[JsonProperty("cellTowers")]
		public List<CellTower> CellTowers { get; set; }

		[JsonProperty("wifiAccessPoints")]
		public List<WifiAccessPoint> WifiAccessPoints { get; set; }
	}
}