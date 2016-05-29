using System.Collections.Generic;

namespace GoogleMapsApiDotNet.RoadsApi.Domain.Request
{
	public partial class SnapRoads
	{
		public SnapRoads WithInterpolate(string interpolate)
		{
			Interpolate = interpolate;
			return this;
		}

		public SnapRoads WithPath(List<string> path)
		{
			Path = path;
			return this;
		}
	}
}