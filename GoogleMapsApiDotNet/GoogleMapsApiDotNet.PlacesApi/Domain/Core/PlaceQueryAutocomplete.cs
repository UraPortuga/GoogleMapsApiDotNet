namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public partial class PlaceQueryAutocomplete
	{
		public PlaceQueryAutocomplete WithKeyword(string input)
		{
			Input = input;
			return this;
		}

		public PlaceQueryAutocomplete WithLanguage(string language)
		{
			Language = language;
			return this;
		}

		public PlaceQueryAutocomplete WithLocation(string location)
		{
			Location = location;
			return this;
		}

		public PlaceQueryAutocomplete WithRadius(string radius)
		{
			Radius = radius;
			return this;
		}

		public PlaceQueryAutocomplete WithOffset(string offset)
		{
			Offset = offset;
			return this;
		}
	}
}