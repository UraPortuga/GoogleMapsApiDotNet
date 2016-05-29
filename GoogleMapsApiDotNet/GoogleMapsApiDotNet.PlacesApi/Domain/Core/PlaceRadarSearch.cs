namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public partial class PlaceRadarSearch
	{
		public PlaceRadarSearch WithKeyword(string keyword)
		{
			Keyword = keyword;
			return this;
		}

		public PlaceRadarSearch WithLocation(string location)
		{
			Location = location;
			return this;
		}

		public PlaceRadarSearch WithMaxPrice(string maxPrice)
		{
			MaxPrice = maxPrice;
			return this;
		}

		public PlaceRadarSearch WithMinPrice(string minPrice)
		{
			MinPrice = minPrice;
			return this;
		}

		public PlaceRadarSearch WithName(string name)
		{
			Name = name;
			return this;
		}

		public PlaceRadarSearch WithOpenNow(string openNow)
		{
			OpenNow = openNow;
			return this;
		}

		public PlaceRadarSearch WithPagetoken(string pagetoken)
		{
			Pagetoken = pagetoken;
			return this;
		}

		public PlaceRadarSearch WithRadius(string radius)
		{
			Radius = radius;
			return this;
		}

		public PlaceRadarSearch WithTypes(string types)
		{
			Types = types;
			return this;
		}

		public PlaceRadarSearch WithZagatSelectedy(string zagatSelected)
		{
			ZagatSelected = zagatSelected;
			return this;
		}
	}
}