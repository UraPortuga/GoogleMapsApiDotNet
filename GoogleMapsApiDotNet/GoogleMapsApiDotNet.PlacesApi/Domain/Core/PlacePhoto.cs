namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public partial class PlacePhoto
	{
		public PlacePhoto WithExtensions(string photoReference)
		{
			PhotoReference = photoReference;
			return this;
		}

		public PlacePhoto WithMaxHeight(string maxHeight)
		{
			MaxHeight = maxHeight;
			return this;
		}

		public PlacePhoto WithMaxWidth(string maxWidth)
		{
			MaxWidth = maxWidth;
			return this;
		}
	}
}