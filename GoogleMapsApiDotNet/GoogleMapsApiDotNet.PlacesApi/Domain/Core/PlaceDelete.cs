namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public partial class PlaceDelete
	{
		public PlaceDelete WithPlaceId(string placeId)
		{
			PlaceId = placeId;
			return this;
		}
	}
}