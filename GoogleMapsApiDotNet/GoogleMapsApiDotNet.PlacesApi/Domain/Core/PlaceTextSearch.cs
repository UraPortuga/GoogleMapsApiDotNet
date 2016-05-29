namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public partial class PlaceTextSearch
	{
		public PlaceTextSearch WithKeyword(string query)
		{
			Query = query;
			return this;
		}

		public PlaceTextSearch WithLanguage(string language)
		{
			Language = language;
			return this;
		}

		public PlaceTextSearch WithLocation(string location)
		{
			Location = location;
			return this;
		}

		public PlaceTextSearch WithMaxPrice(string maxPrice)
		{
			MaxPrice = maxPrice;
			return this;
		}

		public PlaceTextSearch WithMinPrice(string minPrice)
		{
			MinPrice = minPrice;
			return this;
		}

		public PlaceTextSearch WithOpenNow(string openNow)
		{
			OpenNow = openNow;
			return this;
		}

		public PlaceTextSearch WithPagetoken(string pagetoken)
		{
			Pagetoken = pagetoken;
			return this;
		}

		public PlaceTextSearch WithRadius(string radius)
		{
			Radius = radius;
			return this;
		}

		public PlaceTextSearch WithTypes(string types)
		{
			Types = types;
			return this;
		}

		public PlaceTextSearch WithZagatSelectedy(string zagatSelected)
		{
			ZagatSelected = zagatSelected;
			return this;
		}
	}
}