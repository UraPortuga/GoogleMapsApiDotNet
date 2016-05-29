namespace GoogleMapsApiDotNet.GeocodingApi.Domain.Resquest
{
	public partial class GeocodingReverse
	{
		public GeocodingReverse WithLocationType(string locationType)
		{
			LocationType = locationType;
			return this;
		}

		public GeocodingReverse WithLatLng(string latLng)
		{
			LatLng = latLng;
			return this;
		}

		public GeocodingReverse WithPlaceId(string placeId)
		{
			PlaceId = placeId;
			return this;
		}

		public GeocodingReverse WithResultType(string resultType)
		{
			ResultType = resultType;
			return this;
		}
	}
}