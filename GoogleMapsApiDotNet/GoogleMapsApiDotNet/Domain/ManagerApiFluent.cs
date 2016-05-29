using System.Threading.Tasks;
using GoogleMapsApiDotNet.DirectionsApi.Domain.Response;
using GoogleMapsApiDotNet.DirectionsApi.Domain.Resquest;
using GoogleMapsApiDotNet.DistanceMatrixApi.Domain.Request;
using GoogleMapsApiDotNet.DistanceMatrixApi.Domain.Response;
using GoogleMapsApiDotNet.ElevationApi.Domain.Request;
using GoogleMapsApiDotNet.ElevationApi.Domain.Response;
using GoogleMapsApiDotNet.GeocodingApi.Domain.Response;
using GoogleMapsApiDotNet.GeocodingApi.Domain.Resquest;
using GoogleMapsApiDotNet.GeolocationApi.Domain.Request;
using GoogleMapsApiDotNet.GeolocationApi.Domain.Response;
using GoogleMapsApiDotNet.PlacesApi.Domain.Request;
using GoogleMapsApiDotNet.PlacesApi.Domain.Response;
using GoogleMapsApiDotNet.RoadsApi.Domain.Request;
using GoogleMapsApiDotNet.RoadsApi.Domain.Response;
using GoogleMapsApiDotNet.TimeZoneApi.Domain.Request;
using GoogleMapsApiDotNet.TimeZoneApi.Domain.Response;
using static System.Configuration.ConfigurationSettings;

namespace GoogleMapsApiDotNet.Domain
{
	public static class ManagerApiFluent
	{
		private static string Key => AppSettings["Key"];

		#region Elevation Request

		public static Elevation GetElevation() => new Elevation {Key = Key};

		public static async Task<ElevationResponse> GetAsync(this Elevation request)
			=> await request.GetAsync<ElevationResponse>(request.ToString());

		#endregion

		#region TimeZone Request

		public static TimeZone GetTimeZone() => new TimeZone {Key = Key};

		public static async Task<TimeZoneResponse> GetAsync(this TimeZone request)
			=> await request.GetAsync<TimeZoneResponse>(request.ToString());

		#endregion

		#region Roads Request

		#region Snap To Roads Request

		public static SnapRoads GetSnapRoads() => new SnapRoads {Key = Key};

		public static async Task<SnapRoadsResponse> GetAsync(this SnapRoads request)
			=> await request.GetAsync<SnapRoadsResponse>(request.ToString());

		#endregion

		#region Speed Limit Request 

		public static SpeedLimit GetSpeedLimit() => new SpeedLimit {Key = Key};

		public static async Task<SpeedLimitResponse> GetAsync(this SpeedLimit request)
			=> await request.GetAsync<SpeedLimitResponse>(request.ToString());

		#endregion

		#endregion

		#region Directions Request

		public static Directions GetDirections() => new Directions {Key = Key};

		public static async Task<DirectionsResponse> GetAsync(this Directions request)
			=> await request.GetAsync<DirectionsResponse>(request.ToString());

		#endregion

		#region Distance Matrix Request

		public static DistanceMatrix GetDistanceMatrix() => new DistanceMatrix {Key = Key};

		public static async Task<DistanceMatrixResponse> GetAsync(this DistanceMatrix request)
			=> await request.GetAsync<DistanceMatrixResponse>(request.ToString());

		#endregion

		#region Geocoding Request

		public static Geocoding GetGeocoding() => new Geocoding {Key = Key};

		public static async Task<GeocodingResponse> GetAsync(this Geocoding request)
			=> await request.GetAsync<GeocodingResponse>(request.ToString());

		public static GeocodingReverse GetGeocodingReverse() => new GeocodingReverse {Key = Key};

		public static async Task<GeocodingResponse> GetAsync(this GeocodingReverse request)
			=> await request.GetAsync<GeocodingResponse>(request.ToString());

		#endregion

		#region Geolocation Request

		public static Geolocation GetGeolocation() => new Geolocation {Key = Key};

		public static async Task<GeolocationResponse> PostAsync(this Geolocation request)
			=> await request.PostAsync<GeolocationResponse>(request.GetJson());

		#endregion

		#region Places Request

		#region Place Nearby Search

		public static PlaceNearbySearch GetPlaceNearbySearch() => new PlaceNearbySearch {Key = Key};

		public static async Task<PlaceNearbySearchResponse> GetAsync(this PlaceNearbySearch request)
			=> await request.GetAsync<PlaceNearbySearchResponse>(request.ToString());

		#endregion

		#region Place Text Search

		public static PlaceTextSearch GetPlaceTextSearch() => new PlaceTextSearch {Key = Key};


		public static async Task<PlaceTextSearchResponse> GetAsync(this PlaceTextSearch request)
			=> await request.GetAsync<PlaceTextSearchResponse>(request.ToString());

		#endregion

		#region Place Radar Search

		public static PlaceRadarSearch GetPlaceRadarSearch() => new PlaceRadarSearch {Key = Key};

		public static async Task<PlaceRadarSearchResponse> GetAsync(this PlaceRadarSearch request)
			=> await request.GetAsync<PlaceRadarSearchResponse>(request.ToString());

		#endregion

		#region Place Autocomplete 

		public static PlaceAutocomplete GetPlaceAutocomplete() => new PlaceAutocomplete {Key = Key};

		public static async Task<PlaceAutocompleteResponse> GetAsync(this PlaceAutocomplete request)
			=> await request.GetAsync<PlaceAutocompleteResponse>(request.ToString());

		#endregion

		#region Place Query Autocomplete

		public static PlaceQueryAutocomplete GetPlaceQueryAutocomplete() => new PlaceQueryAutocomplete {Key = Key};

		public static async Task<PlaceQueryAutocompleteResponse> GetAsync(this PlaceQueryAutocomplete request)
			=> await request.GetAsync<PlaceQueryAutocompleteResponse>(request.ToString());

		#endregion

		#region Place Details

		public static PlaceDetails GetPlaceDetails() => new PlaceDetails {Key = Key};

		public static async Task<PlaceDetailsResponse> GetAsync(this PlaceDetails request)
			=> await request.GetAsync<PlaceDetailsResponse>(request.ToString());

		#endregion

		#region Place Add

		public static PlaceAdd GetPlaceAdd() => new PlaceAdd();

		public static async Task<PlaceAddResponse> PostAsync(this PlaceAdd request)
			=> await request.PostAsync<PlaceAddResponse>(request.GetJson());

		#endregion

		#region Place Delete

		public static PlaceDelete GetPlaceDelete() => new PlaceDelete();

		public static async Task<PlaceDeleteResponse> PostAsync(this PlaceDelete request)
			=> await request.PostAsync<PlaceDeleteResponse>(request.GetJson());

		#endregion

		#region Place Photo

		public static PlacePhoto GetPlacePhoto() => new PlacePhoto {Key = Key};

		public static async Task<PlacePhotoResponse> GetAsync(this PlacePhoto request)
			=> await request.GetAsync<PlacePhotoResponse>(request.ToString());

		#endregion

		#endregion
	}
}