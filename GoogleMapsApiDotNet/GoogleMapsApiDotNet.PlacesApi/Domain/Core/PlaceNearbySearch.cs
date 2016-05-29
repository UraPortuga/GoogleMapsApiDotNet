namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public partial class PlaceNearbySearch
	{
		public PlaceNearbySearch WithKeyword(string keyword)
		{
			Keyword = keyword;
			return this;
		}

		public PlaceNearbySearch WithLanguage(string language)
		{
			Language = language;
			return this;
		}

		public PlaceNearbySearch WithLocation(string location)
		{
			Location = location;
			return this;
		}

		public PlaceNearbySearch WithMaxPrice(string maxPrice)
		{
			MaxPrice = maxPrice;
			return this;
		}

		public PlaceNearbySearch WithMinPrice(string minPrice)
		{
			MinPrice = minPrice;
			return this;
		}

		public PlaceNearbySearch WithName(string name)
		{
			Name = name;
			return this;
		}

		public PlaceNearbySearch WithOpenNow(string openNow)
		{
			OpenNow = openNow;
			return this;
		}

		public PlaceNearbySearch WithPagetoken(string pagetoken)
		{
			Pagetoken = pagetoken;
			return this;
		}

		public PlaceNearbySearch WithRadius(string radius)
		{
			Radius = radius;
			return this;
		}

		public PlaceNearbySearch WithRankby(string rankby)
		{
			Rankby = rankby;
			return this;
		}

		public PlaceNearbySearch WithTypes(string types)
		{
			Types = types;
			return this;
		}

		public PlaceNearbySearch WithZagatSelectedy(string zagatSelected)
		{
			ZagatSelected = zagatSelected;
			return this;
		}
	}
}