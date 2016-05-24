using System.Collections.Generic;
using GoogleMapsApiDotNet.DirectionsApi.Domain.Resquest;
using GoogleMapsApiDotNet.DistanceMatrixApi.Domain.Request;
using GoogleMapsApiDotNet.ElevationApi.Domain.Request;
using GoogleMapsApiDotNet.GeocodingApi.Domain.Resquest;
using GoogleMapsApiDotNet.GeolocationApi.Domain;
using GoogleMapsApiDotNet.GeolocationApi.Domain.Request;
using GoogleMapsApiDotNet.PlacesApi.Domain.Request;
using GoogleMapsApiDotNet.RoadsApi.Domain.Request;
using GoogleMapsApiDotNet.TimeZoneApi.Domain.Request;
using static System.Configuration.ConfigurationSettings;

namespace GoogleMapsApiDotNet.Domain
{
	public static class ManagerApiFluent
	{
		private static string Key => AppSettings["Key"];

		#region Elevation Request

		public static ElevationRequest GetElevation() => new ElevationRequest { Key = Key };

		public static ElevationRequest WithPath(this ElevationRequest request, string path)
		{
			request.Path = path;
			return request;
		}

		public static ElevationRequest WithSamples(this ElevationRequest request, string samples)
		{
			request.Samples = samples;
			return request;
		}

		public static ElevationRequest WithLocations(this ElevationRequest request, List<string> locations)
		{
			request.Locations = locations;
			return request;
		}

		#endregion

		#region TimeZone Request

		public static TimeZoneRequest GetTimeZone() => new TimeZoneRequest { Key = Key };

		public static TimeZoneRequest WithLanguage(this TimeZoneRequest request, string language)
		{
			request.Language = language;
			return request;
		}

		public static TimeZoneRequest WithLocation(this TimeZoneRequest request, string location)
		{
			request.Location = location;
			return request;
		}

		public static TimeZoneRequest WithTimestamp(this TimeZoneRequest request, string timestamp)
		{
			request.Timestamp = timestamp;
			return request;
		}

		#endregion

		#region Roads Request

		#region Snap To Roads Request

		public static SnapRoadsRequest GetSnapRoads() => new SnapRoadsRequest { Key = Key };

		public static SnapRoadsRequest WithInterpolate(this SnapRoadsRequest request, string interpolate)
		{
			request.Interpolate = interpolate;
			return request;
		}

		public static SnapRoadsRequest WithPath(this SnapRoadsRequest request, List<string> path)
		{
			request.Path = path;
			return request;
		}

		#endregion

		#region Speed Limit Request 

		public static SpeedLimitRequest GetSpeedLimit() => new SpeedLimitRequest { Key = Key };

		public static SpeedLimitRequest WithPath(this SpeedLimitRequest request, List<string> path)
		{
			request.Path = path;
			return request;
		}

		public static SpeedLimitRequest WithPlaceId(this SpeedLimitRequest request, List<string> placeId)
		{
			request.PlaceId = placeId.ToArray();
			return request;
		}

		public static SpeedLimitRequest WithUnits(this SpeedLimitRequest request, string units)
		{
			request.Units = units;
			return request;
		}

		#endregion

		#endregion

		#region Directions Request

		public static DirectionsRequest GetDirections() => new DirectionsRequest { Key = Key };

		public static DirectionsRequest WithAlternatives(this DirectionsRequest request, string alternatives)
		{
			request.Alternatives = alternatives;
			return request;
		}

		public static DirectionsRequest WithArrivalTime(this DirectionsRequest request, string arrivalTime)
		{
			request.ArrivalTime = arrivalTime;
			return request;
		}

		public static DirectionsRequest WithUnits(this DirectionsRequest request, string units)
		{
			request.Units = units;
			return request;
		}

		public static DirectionsRequest WithAvoid(this DirectionsRequest request, string avoid)
		{
			request.Avoid = avoid;
			return request;
		}

		public static DirectionsRequest WithDepartureTime(this DirectionsRequest request, string departureTime)
		{
			request.DepartureTime = departureTime;
			return request;
		}

		public static DirectionsRequest WithDestination(this DirectionsRequest request, List<string> destinations)
		{
			request.Destination = destinations;
			return request;
		}

		public static DirectionsRequest WithLanguage(this DirectionsRequest request, string language)
		{
			request.Language = language;
			return request;
		}

		public static DirectionsRequest WithMode(this DirectionsRequest request, string mode)
		{
			request.Mode = mode;
			return request;
		}

		public static DirectionsRequest WithOrigin(this DirectionsRequest request, string origin)
		{
			request.Origin = origin;
			return request;
		}

		public static DirectionsRequest WithRegion(this DirectionsRequest request, string region)
		{
			request.Region = region;
			return request;
		}

		public static DirectionsRequest WithTrafficModel(this DirectionsRequest request, string trafficModel)
		{
			request.TrafficModel = trafficModel;
			return request;
		}

		public static DirectionsRequest WithTransitMode(this DirectionsRequest request, string transitMode)
		{
			request.TransitMode = transitMode;
			return request;
		}

		public static DirectionsRequest WithTransitRoutingPreference(this DirectionsRequest request,
			string transitRoutingPreference)
		{
			request.TransitRoutingPreference = transitRoutingPreference;
			return request;
		}

		public static DirectionsRequest WithWaypoints(this DirectionsRequest request, List<string> waypoints)
		{
			request.Waypoints = waypoints;
			return request;
		}

		#endregion

		#region Distance Matrix Request

		public static DistanceMatrixRequest GetDistanceMatrix() => new DistanceMatrixRequest { Key = Key };

		public static DistanceMatrixRequest WithArrivalTime(this DistanceMatrixRequest request, string arrivalTime)
		{
			request.ArrivalTime = arrivalTime;
			return request;
		}

		public static DistanceMatrixRequest WithUnits(this DistanceMatrixRequest request, string units)
		{
			request.Units = units;
			return request;
		}

		public static DistanceMatrixRequest WithAvoid(this DistanceMatrixRequest request, string avoid)
		{
			request.Avoid = avoid;
			return request;
		}

		public static DistanceMatrixRequest WithDepartureTime(this DistanceMatrixRequest request, string departureTime)
		{
			request.DepartureTime = departureTime;
			return request;
		}

		public static DistanceMatrixRequest WithDestination(this DistanceMatrixRequest request, List<string> destinations)
		{
			request.Destination = destinations;
			return request;
		}

		public static DistanceMatrixRequest WithLanguage(this DistanceMatrixRequest request, string language)
		{
			request.Language = language;
			return request;
		}

		public static DistanceMatrixRequest WithMode(this DistanceMatrixRequest request, string mode)
		{
			request.Mode = mode;
			return request;
		}

		public static DistanceMatrixRequest WithOrigin(this DistanceMatrixRequest request, List<string> origin)
		{
			request.Origin = origin;
			return request;
		}

		public static DistanceMatrixRequest WithRegion(this DistanceMatrixRequest request, string region)
		{
			request.Region = region;
			return request;
		}

		public static DistanceMatrixRequest WithTrafficModel(this DistanceMatrixRequest request, string trafficModel)
		{
			request.TrafficModel = trafficModel;
			return request;
		}

		public static DistanceMatrixRequest WithTransitMode(this DistanceMatrixRequest request, string transitMode)
		{
			request.TransitMode = transitMode;
			return request;
		}

		public static DistanceMatrixRequest WithTransitRoutingPreference(this DistanceMatrixRequest request,
			string transitRoutingPreference)
		{
			request.TransitRoutingPreference = transitRoutingPreference;
			return request;
		}

		#endregion

		#region Geocoding Request

		public static GeocodingRequest GetGeocoding() => new GeocodingRequest { Key = Key };

		public static GeocodingRequest WithAddress(this GeocodingRequest request, string address)
		{
			request.Address = address;
			return request;
		}

		public static GeocodingRequest WithComponents(this GeocodingRequest request, string components)
		{
			request.Components = components;
			return request;
		}

		public static GeocodingRequest WithLatLng(this GeocodingRequest request, string latLng)
		{
			request.LatLng = latLng;
			return request;
		}

		public static GeocodingRequest WithPlaceId(this GeocodingRequest request, string placeId)
		{
			request.PlaceId = placeId;
			return request;
		}

		public static GeocodingRequest WithLanguage(this GeocodingRequest request, string language)
		{
			request.Language = language;
			return request;
		}

		public static GeocodingRequest WithResultType(this GeocodingRequest request, string resultType)
		{
			request.ResultType = resultType;
			return request;
		}

		public static GeocodingRequest WithBounds(this GeocodingRequest request, List<string> bounds)
		{
			request.Bounds = bounds;
			return request;
		}

		public static GeocodingRequest WithRegion(this GeocodingRequest request, string region)
		{
			request.Region = region;
			return request;
		}

		public static GeocodingRequest WithLocationType(this GeocodingRequest request, string locationType)
		{
			request.LocationType = locationType;
			return request;
		}

		#endregion

		#region Geolocation Request

		public static GeolocationRequest GetGeolocation() => new GeolocationRequest { Key = Key };

		public static GeolocationRequest WithCarrier(this GeolocationRequest request, string carrier)
		{
			request.Carrier = carrier;
			return request;
		}

		public static GeolocationRequest WithConsiderIp(this GeolocationRequest request, string considerIp)
		{
			request.ConsiderIp = considerIp;
			return request;
		}

		public static GeolocationRequest WithHomeMobileCountryCode(this GeolocationRequest request, int homeMobileCountryCode)
		{
			request.HomeMobileCountryCode = homeMobileCountryCode;
			return request;
		}

		public static GeolocationRequest WithHomeMobileNetworkCode(this GeolocationRequest request, int homeMobileNetworkCode)
		{
			request.HomeMobileNetworkCode = homeMobileNetworkCode;
			return request;
		}

		public static GeolocationRequest WithRadioType(this GeolocationRequest request, string radioType)
		{
			request.RadioType = radioType;
			return request;
		}

		public static GeolocationRequest WithCellTowers(this GeolocationRequest request, List<CellTower> cellTowers)
		{
			request.CellTowers = cellTowers;
			return request;
		}

		public static GeolocationRequest WithWifiAccessPoints(this GeolocationRequest request,
			List<WifiAccessPoint> wifiAccessPoints)
		{
			request.WifiAccessPoints = wifiAccessPoints;
			return request;
		}

		#endregion

		#region Places Request

		#region Place Nearby Search

		public static PlaceNearbySearchRequest GetPlaceNearbySearch() => new PlaceNearbySearchRequest { Key = Key };

		public static PlaceNearbySearchRequest WithKeyword(this PlaceNearbySearchRequest request, string keyword)
		{
			request.Keyword = keyword;
			return request;
		}

		public static PlaceNearbySearchRequest WithLanguage(this PlaceNearbySearchRequest request, string language)
		{
			request.Language = language;
			return request;
		}

		public static PlaceNearbySearchRequest WithLocation(this PlaceNearbySearchRequest request, string location)
		{
			request.Location = location;
			return request;
		}

		public static PlaceNearbySearchRequest WithMaxPrice(this PlaceNearbySearchRequest request, string maxPrice)
		{
			request.MaxPrice = maxPrice;
			return request;
		}

		public static PlaceNearbySearchRequest WithMinPrice(this PlaceNearbySearchRequest request, string minPrice)
		{
			request.MinPrice = minPrice;
			return request;
		}

		public static PlaceNearbySearchRequest WithName(this PlaceNearbySearchRequest request, string name)
		{
			request.Name = name;
			return request;
		}

		public static PlaceNearbySearchRequest WithOpenNow(this PlaceNearbySearchRequest request, string openNow)
		{
			request.OpenNow = openNow;
			return request;
		}

		public static PlaceNearbySearchRequest WithPagetoken(this PlaceNearbySearchRequest request, string pagetoken)
		{
			request.Pagetoken = pagetoken;
			return request;
		}

		public static PlaceNearbySearchRequest WithRadius(this PlaceNearbySearchRequest request, string radius)
		{
			request.Radius = radius;
			return request;
		}

		public static PlaceNearbySearchRequest WithRankby(this PlaceNearbySearchRequest request, string rankby)
		{
			request.Rankby = rankby;
			return request;
		}

		public static PlaceNearbySearchRequest WithTypes(this PlaceNearbySearchRequest request, string types)
		{
			request.Types = types;
			return request;
		}

		public static PlaceNearbySearchRequest WithZagatSelectedy(this PlaceNearbySearchRequest request, string zagatSelected)
		{
			request.ZagatSelected = zagatSelected;
			return request;
		}

		#endregion

		#region Place Text Search

		public static PlaceTextSearchRequest GetPlaceTextSearch() => new PlaceTextSearchRequest { Key = Key };

		public static PlaceTextSearchRequest WithKeyword(this PlaceTextSearchRequest request, string query)
		{
			request.Query = query;
			return request;
		}

		public static PlaceTextSearchRequest WithLanguage(this PlaceTextSearchRequest request, string language)
		{
			request.Language = language;
			return request;
		}

		public static PlaceTextSearchRequest WithLocation(this PlaceTextSearchRequest request, string location)
		{
			request.Location = location;
			return request;
		}

		public static PlaceTextSearchRequest WithMaxPrice(this PlaceTextSearchRequest request, string maxPrice)
		{
			request.MaxPrice = maxPrice;
			return request;
		}

		public static PlaceTextSearchRequest WithMinPrice(this PlaceTextSearchRequest request, string minPrice)
		{
			request.MinPrice = minPrice;
			return request;
		}

		public static PlaceTextSearchRequest WithOpenNow(this PlaceTextSearchRequest request, string openNow)
		{
			request.OpenNow = openNow;
			return request;
		}

		public static PlaceTextSearchRequest WithPagetoken(this PlaceTextSearchRequest request, string pagetoken)
		{
			request.Pagetoken = pagetoken;
			return request;
		}

		public static PlaceTextSearchRequest WithRadius(this PlaceTextSearchRequest request, string radius)
		{
			request.Radius = radius;
			return request;
		}

		public static PlaceTextSearchRequest WithTypes(this PlaceTextSearchRequest request, string types)
		{
			request.Types = types;
			return request;
		}

		public static PlaceTextSearchRequest WithZagatSelectedy(this PlaceTextSearchRequest request, string zagatSelected)
		{
			request.ZagatSelected = zagatSelected;
			return request;
		}

		#endregion

		#region Place Radar Search

		public static PlaceRadarSearchRequest GetPlaceRadarSearch() => new PlaceRadarSearchRequest { Key = Key };

		public static PlaceRadarSearchRequest WithKeyword(this PlaceRadarSearchRequest request, string keyword)
		{
			request.Keyword = keyword;
			return request;
		}

		public static PlaceRadarSearchRequest WithLocation(this PlaceRadarSearchRequest request, string location)
		{
			request.Location = location;
			return request;
		}

		public static PlaceRadarSearchRequest WithMaxPrice(this PlaceRadarSearchRequest request, string maxPrice)
		{
			request.MaxPrice = maxPrice;
			return request;
		}

		public static PlaceRadarSearchRequest WithMinPrice(this PlaceRadarSearchRequest request, string minPrice)
		{
			request.MinPrice = minPrice;
			return request;
		}

		public static PlaceRadarSearchRequest WithName(this PlaceRadarSearchRequest request, string name)
		{
			request.Name = name;
			return request;
		}

		public static PlaceRadarSearchRequest WithOpenNow(this PlaceRadarSearchRequest request, string openNow)
		{
			request.OpenNow = openNow;
			return request;
		}

		public static PlaceRadarSearchRequest WithPagetoken(this PlaceRadarSearchRequest request, string pagetoken)
		{
			request.Pagetoken = pagetoken;
			return request;
		}

		public static PlaceRadarSearchRequest WithRadius(this PlaceRadarSearchRequest request, string radius)
		{
			request.Radius = radius;
			return request;
		}

		public static PlaceRadarSearchRequest WithTypes(this PlaceRadarSearchRequest request, string types)
		{
			request.Types = types;
			return request;
		}

		public static PlaceRadarSearchRequest WithZagatSelectedy(this PlaceRadarSearchRequest request, string zagatSelected)
		{
			request.ZagatSelected = zagatSelected;
			return request;
		}

		#endregion

		#region Place Autocomplete 

		public static PlaceAutocompleteRequest GetPlaceAutocomplete() => new PlaceAutocompleteRequest { Key = Key };

		public static PlaceAutocompleteRequest WithKeyword(this PlaceAutocompleteRequest request, string input)
		{
			request.Input = input;
			return request;
		}

		public static PlaceAutocompleteRequest WithLanguage(this PlaceAutocompleteRequest request, string language)
		{
			request.Language = language;
			return request;
		}

		public static PlaceAutocompleteRequest WithLocation(this PlaceAutocompleteRequest request, string location)
		{
			request.Location = location;
			return request;
		}

		public static PlaceAutocompleteRequest WithRadius(this PlaceAutocompleteRequest request, string radius)
		{
			request.Radius = radius;
			return request;
		}

		public static PlaceAutocompleteRequest WithTypes(this PlaceAutocompleteRequest request, string types)
		{
			request.Types = types;
			return request;
		}

		public static PlaceAutocompleteRequest WithComponents(this PlaceAutocompleteRequest request, string components)
		{
			request.Components = components;
			return request;
		}

		public static PlaceAutocompleteRequest WithOffset(this PlaceAutocompleteRequest request, string offset)
		{
			request.Offset = offset;
			return request;
		}

		#endregion

		#region Place Query Autocomplete

		public static PlaceQueryAutocompleteRequest GetPlaceQueryAutocomplete() => new PlaceQueryAutocompleteRequest { Key = Key };

		public static PlaceQueryAutocompleteRequest WithKeyword(this PlaceQueryAutocompleteRequest request, string input)
		{
			request.Input = input;
			return request;
		}

		public static PlaceQueryAutocompleteRequest WithLanguage(this PlaceQueryAutocompleteRequest request, string language)
		{
			request.Language = language;
			return request;
		}

		public static PlaceQueryAutocompleteRequest WithLocation(this PlaceQueryAutocompleteRequest request, string location)
		{
			request.Location = location;
			return request;
		}

		public static PlaceQueryAutocompleteRequest WithRadius(this PlaceQueryAutocompleteRequest request, string radius)
		{
			request.Radius = radius;
			return request;
		}

		public static PlaceQueryAutocompleteRequest WithOffset(this PlaceQueryAutocompleteRequest request, string offset)
		{
			request.Offset = offset;
			return request;
		}

		#endregion

		#region Place Details

		public static PlaceDetailsRequest GetPlaceDetails() => new PlaceDetailsRequest { Key = Key };

		public static PlaceDetailsRequest WithExtensions(this PlaceDetailsRequest request, string extensions)
		{
			request.Extensions = extensions;
			return request;
		}

		public static PlaceDetailsRequest WithLanguage(this PlaceDetailsRequest request, string language)
		{
			request.Language = language;
			return request;
		}

		public static PlaceDetailsRequest WithPlaceId(this PlaceDetailsRequest request, string placeId)
		{
			request.PlaceId = placeId;
			return request;
		}

		public static PlaceDetailsRequest WithReference(this PlaceDetailsRequest request, string reference)
		{
			request.Reference = reference;
			return request;
		}

		#endregion

		#region Place Add

		public static PlaceAddRequest GetPlaceAdd() => new PlaceAddRequest();

		public static PlaceAddRequest WithAccuracy(this PlaceAddRequest request, int accuracy)
		{
			request.Accuracy = accuracy;
			return request;
		}

		public static PlaceAddRequest WithLanguage(this PlaceAddRequest request, string language)
		{
			request.Language = language;
			return request;
		}

		public static PlaceAddRequest WithAddress(this PlaceAddRequest request, string address)
		{
			request.Address = address;
			return request;
		}

		public static PlaceAddRequest WithName(this PlaceAddRequest request, string name)
		{
			request.Name = name;
			return request;
		}

		public static PlaceAddRequest WithWebsite(this PlaceAddRequest request, string website)
		{
			request.Website = website;
			return request;
		}

		public static PlaceAddRequest WithPhoneNumber(this PlaceAddRequest request, string phone)
		{
			request.Phone_number = phone;
			return request;
		}

		public static PlaceAddRequest WithTypes(this PlaceAddRequest request, List<string> types)
		{
			request.Types = types;
			return request;
		}

		#endregion

		#region Place Delete

		public static PlaceDeleteRequest GetPlaceDelete() => new PlaceDeleteRequest();

		public static PlaceDeleteRequest WithPlaceId(this PlaceDeleteRequest request, string placeId)
		{
			request.PlaceId = placeId;
			return request;
		}

		#endregion

		#region Place Photo

		public static PlacePhotoRequest GetPlacePhoto() => new PlacePhotoRequest { Key = Key };

		public static PlacePhotoRequest WithExtensions(this PlacePhotoRequest request, string photoReference)
		{
			request.PhotoReference = photoReference;
			return request;
		}

		public static PlacePhotoRequest WithMaxHeight(this PlacePhotoRequest request, string maxHeight)
		{
			request.MaxHeight = maxHeight;
			return request;
		}

		public static PlacePhotoRequest WithMaxWidth(this PlacePhotoRequest request, string maxWidth)
		{
			request.MaxWidth = maxWidth;
			return request;
		}

		#endregion

		#endregion
	}
}