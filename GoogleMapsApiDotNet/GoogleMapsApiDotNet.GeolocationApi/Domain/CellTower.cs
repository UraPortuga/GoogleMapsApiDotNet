namespace GoogleMapsApiDotNet.GeolocationApi.Domain
{
	public class CellTower
	{
		public int CellId { get; set; }
		public int LocationAreaCode { get; set; }
		public int MobileCountryCode { get; set; }
		public int MobileNetworkCode { get; set; }
		public int Age { get; set; }
		public int SignalStrength { get; set; }
		public int TimingAdvance { get; set; }
	}
}