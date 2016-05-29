using System.Collections.Generic;

namespace GoogleMapsApiDotNet.GeocodingApi.Domain.Resquest
{
	public partial class Geocoding
	{
		public Geocoding WithAddress(string address)
		{
			Address = address;
			return this;
		}

		public Geocoding WithComponents(string components)
		{
			Components = components;
			return this;
		}

		public Geocoding WithLanguage(string language)
		{
			Language = language;
			return this;
		}

		public Geocoding WithBounds(List<string> bounds)
		{
			Bounds = bounds;
			return this;
		}

		public Geocoding WithRegion(string region)
		{
			Region = region;
			return this;
		}
	}
}