namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public partial class PlaceAutocomplete
	{
		public PlaceAutocomplete WithKeyword(string input)
		{
			Input = input;
			return this;
		}

		public PlaceAutocomplete WithLanguage(string language)
		{
			Language = language;
			return this;
		}

		public PlaceAutocomplete WithLocation(string location)
		{
			Location = location;
			return this;
		}

		public PlaceAutocomplete WithRadius(string radius)
		{
			Radius = radius;
			return this;
		}

		public PlaceAutocomplete WithTypes(string types)
		{
			Types = types;
			return this;
		}

		public PlaceAutocomplete WithComponents(string components)
		{
			Components = components;
			return this;
		}

		public PlaceAutocomplete WithOffset(string offset)
		{
			Offset = offset;
			return this;
		}
	}
}