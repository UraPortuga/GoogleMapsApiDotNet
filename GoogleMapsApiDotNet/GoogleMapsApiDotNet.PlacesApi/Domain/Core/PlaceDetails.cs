namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public partial class PlaceDetails
	{
		public PlaceDetails WithExtensions(string extensions)
		{
			Extensions = extensions;
			return this;
		}

		public PlaceDetails WithLanguage(string language)
		{
			Language = language;
			return this;
		}

		public PlaceDetails WithPlaceId(string placeId)
		{
			PlaceId = placeId;
			return this;
		}

		public PlaceDetails WithReference(string reference)
		{
			Reference = reference;
			return this;
		}
	}
}