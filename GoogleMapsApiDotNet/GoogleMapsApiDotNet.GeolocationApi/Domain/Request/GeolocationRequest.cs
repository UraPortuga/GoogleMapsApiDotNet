using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.GeolocationApi.Domain.Request
{
	public class GeolocationRequest :BaseRequest
	{
		public int HomeMobileCountryCode { get; set; }
		public int HomeMobileNetworkCode { get; set; }
		public string RadioType { get; set; }
		public string Carrier { get; set; }
		public string ConsiderIp { get; set; }
		public List<CellTower> CellTowers { get; set; }
		public List<WifiAccessPoint> WifiAccessPoints { get; set; }
	}
}