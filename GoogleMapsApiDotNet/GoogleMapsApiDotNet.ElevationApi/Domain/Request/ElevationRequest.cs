using System.Collections.Generic;
using GoogleMapsApiDotNet.Domain.Domain;

namespace GoogleMapsApiDotNet.ElevationApi.Domain.Request
{
	public class ElevationRequest :BaseRequest
	{
		public List<string> Locations { get; set; }
		public string Path { get; set; }
		public string Samples { get; set; }	
	}
}