using System.Collections.Generic;

namespace GoogleMapsApiDotNet.DistanceMatrixApi.Domain.Response
{
	public class DistanceMatrixResponse
	{
		public List<string> Destination_addresses { get; set; }
		public List<string> Origin_addresses { get; set; }
		public List<Row> Rows { get; set; }
		public string Status { get; set; }
	}
}