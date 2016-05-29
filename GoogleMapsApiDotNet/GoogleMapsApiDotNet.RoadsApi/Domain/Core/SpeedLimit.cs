using System.Collections.Generic;

namespace GoogleMapsApiDotNet.RoadsApi.Domain.Request
{
	public partial class SpeedLimit
	{
		public SpeedLimit WithPath(List<string> path)
		{
			Path = path;
			return this;
		}

		public SpeedLimit WithPlaceId(List<string> placeId)
		{
			PlaceId = placeId.ToArray();
			return this;
		}

		public SpeedLimit WithUnits(string units)
		{
			Units = units;
			return this;
		}
	}
}