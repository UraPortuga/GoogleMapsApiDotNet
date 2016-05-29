using System.Collections.Generic;

namespace GoogleMapsApiDotNet.ElevationApi.Domain.Request
{
	public partial class Elevation
	{
		public Elevation WithPath(string path)
		{
			Path = path;
			return this;
		}

		public Elevation WithSamples(string samples)
		{
			Samples = samples;
			return this;
		}

		public Elevation WithLocations(List<string> locations)
		{
			Locations = locations;
			return this;
		}
	}
}