using System.Collections.Generic;

namespace GoogleMapsApiDotNet.GeolocationApi.Domain.Request
{
	public partial class Geolocation
	{
		public Geolocation WithCarrier(string carrier)
		{
			Carrier = carrier;
			return this;
		}

		public Geolocation WithConsiderIp(string considerIp)
		{
			ConsiderIp = considerIp;
			return this;
		}

		public Geolocation WithHomeMobileCountryCode(int homeMobileCountryCode)
		{
			HomeMobileCountryCode = homeMobileCountryCode;
			return this;
		}

		public Geolocation WithHomeMobileNetworkCode(int homeMobileNetworkCode)
		{
			HomeMobileNetworkCode = homeMobileNetworkCode;
			return this;
		}

		public Geolocation WithRadioType(string radioType)
		{
			RadioType = radioType;
			return this;
		}

		public Geolocation WithCellTowers(List<CellTower> cellTowers)
		{
			CellTowers = cellTowers;
			return this;
		}

		public Geolocation WithWifiAccessPoints(List<WifiAccessPoint> wifiAccessPoints)
		{
			WifiAccessPoints = wifiAccessPoints;
			return this;
		}
	}
}