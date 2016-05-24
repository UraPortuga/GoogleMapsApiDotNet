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

		public static Elevation GetElevation() => new Elevation { Key = Key };

		public static Elevation WithPath(this Elevation request, string path)
		{
			request.Path = path;
			return request;
		}

		public static Elevation WithSamples(this Elevation request, string samples)
		{
			request.Samples = samples;
			return request;
		}

		public static Elevation WithLocations(this Elevation request, List<string> locations)
		{
			request.Locations = locations;
			return request;
		}

		#endregion

		#region TimeZone Request

		public static TimeZone GetTimeZone() => new TimeZone { Key = Key };

		public static TimeZone WithLanguage(this TimeZone request, string language)
		{
			request.Language = language;
			return request;
		}

		public static TimeZone WithLocation(this TimeZone request, string location)
		{
			request.Location = location;
			return request;
		}

		public static TimeZone WithTimestamp(this TimeZone request, string timestamp)
		{
			request.Timestamp = timestamp;
			return request;
		}

		#endregion

		#region Roads Request

		#region Snap To Roads Request

		public static SnapRoads GetSnapRoads() => new SnapRoads { Key = Key };

		public static SnapRoads WithInterpolate(this SnapRoads request, string interpolate)
		{
			request.Interpolate = interpolate;
			return request;
		}

		public static SnapRoads WithPath(this SnapRoads request, List<string> path)
		{
			request.Path = path;
			return request;
		}

		#endregion

		#region Speed Limit Request 

		public static SpeedLimit GetSpeedLimit() => new SpeedLimit { Key = Key };

		public static SpeedLimit WithPath(this SpeedLimit request, List<string> path)
		{
			request.Path = path;
			return request;
		}

		public static SpeedLimit WithPlaceId(this SpeedLimit request, List<string> placeId)
		{
			request.PlaceId = placeId.ToArray();
			return request;
		}

		public static SpeedLimit WithUnits(this SpeedLimit request, string units)
		{
			request.Units = units;
			return request;
		}

		#endregion

		#endregion

		#region Directions Request

		public static Directions GetDirections() => new Directions { Key = Key };

		public static Directions WithAlternatives(this Directions request, string alternatives)
		{
			request.Alternatives = alternatives;
			return request;
		}

		public static Directions WithArrivalTime(this Directions request, string arrivalTime)
		{
			request.ArrivalTime = arrivalTime;
			return request;
		}

		public static Directions WithUnits(this Directions request, string units)
		{
			request.Units = units;
			return request;
		}

		public static Directions WithAvoid(this Directions request, string avoid)
		{
			request.Avoid = avoid;
			return request;
		}

		public static Directions WithDepartureTime(this Directions request, string departureTime)
		{
			request.DepartureTime = departureTime;
			return request;
		}

		public static Directions WithDestination(this Directions request, List<string> destinations)
		{
			request.Destination = destinations;
			return request;
		}

		public static Directions WithLanguage(this Directions request, string language)
		{
			request.Language = language;
			return request;
		}

		public static Directions WithMode(this Directions request, string mode)
		{
			request.Mode = mode;
			return request;
		}

		public static Directions WithOrigin(this Directions request, string origin)
		{
			request.Origin = origin;
			return request;
		}

		public static Directions WithRegion(this Directions request, string region)
		{
			request.Region = region;
			return request;
		}

		public static Directions WithTrafficModel(this Directions request, string trafficModel)
		{
			request.TrafficModel = trafficModel;
			return request;
		}

		public static Directions WithTransitMode(this Directions request, string transitMode)
		{
			request.TransitMode = transitMode;
			return request;
		}

		public static Directions WithTransitRoutingPreference(this Directions request,
			string transitRoutingPreference)
		{
			request.TransitRoutingPreference = transitRoutingPreference;
			return request;
		}

		public static Directions WithWaypoints(this Directions request, List<string> waypoints)
		{
			request.Waypoints = waypoints;
			return request;
		}

		#endregion

		#region Distance Matrix Request

		public static DistanceMatrix GetDistanceMatrix() => new DistanceMatrix { Key = Key };

		public static DistanceMatrix WithArrivalTime(this DistanceMatrix request, string arrivalTime)
		{
			request.ArrivalTime = arrivalTime;
			return request;
		}

		public static DistanceMatrix WithUnits(this DistanceMatrix request, string units)
		{
			request.Units = units;
			return request;
		}

		public static DistanceMatrix WithAvoid(this DistanceMatrix request, string avoid)
		{
			request.Avoid = avoid;
			return request;
		}

		public static DistanceMatrix WithDepartureTime(this DistanceMatrix request, string departureTime)
		{
			request.DepartureTime = departureTime;
			return request;
		}

		public static DistanceMatrix WithDestination(this DistanceMatrix request, List<string> destinations)
		{
			request.Destination = destinations;
			return request;
		}

		public static DistanceMatrix WithLanguage(this DistanceMatrix request, string language)
		{
			request.Language = language;
			return request;
		}

		public static DistanceMatrix WithMode(this DistanceMatrix request, string mode)
		{
			request.Mode = mode;
			return request;
		}

		public static DistanceMatrix WithOrigin(this DistanceMatrix request, List<string> origin)
		{
			request.Origins = origin;
			return request;
		}

		public static DistanceMatrix WithRegion(this DistanceMatrix request, string region)
		{
			request.Region = region;
			return request;
		}

		public static DistanceMatrix WithTrafficModel(this DistanceMatrix request, string trafficModel)
		{
			request.TrafficModel = trafficModel;
			return request;
		}

		public static DistanceMatrix WithTransitMode(this DistanceMatrix request, string transitMode)
		{
			request.TransitMode = transitMode;
			return request;
		}

		public static DistanceMatrix WithTransitRoutingPreference(this DistanceMatrix request,
			string transitRoutingPreference)
		{
			request.TransitRoutingPreference = transitRoutingPreference;
			return request;
		}

		#endregion

		#region Geocoding Request

		public static Geocoding GetGeocoding() => new Geocoding { Key = Key };

		public static Geocoding WithAddress(this Geocoding request, string address)
		{
			request.Address = address;
			return request;
		}

		public static Geocoding WithComponents(this Geocoding request, string components)
		{
			request.Components = components;
			return request;
		}

		public static Geocoding WithLatLng(this Geocoding request, string latLng)
		{
			request.LatLng = latLng;
			return request;
		}

		public static Geocoding WithPlaceId(this Geocoding request, string placeId)
		{
			request.PlaceId = placeId;
			return request;
		}

		public static Geocoding WithLanguage(this Geocoding request, string language)
		{
			request.Language = language;
			return request;
		}

		public static Geocoding WithResultType(this Geocoding request, string resultType)
		{
			request.ResultType = resultType;
			return request;
		}

		public static Geocoding WithBounds(this Geocoding request, List<string> bounds)
		{
			request.Bounds = bounds;
			return request;
		}

		public static Geocoding WithRegion(this Geocoding request, string region)
		{
			request.Region = region;
			return request;
		}

		public static Geocoding WithLocationType(this Geocoding request, string locationType)
		{
			request.LocationType = locationType;
			return request;
		}

		#endregion

		#region Geolocation Request

		public static Geolocation GetGeolocation() => new Geolocation { Key = Key };

		public static Geolocation WithCarrier(this Geolocation request, string carrier)
		{
			request.Carrier = carrier;
			return request;
		}

		public static Geolocation WithConsiderIp(this Geolocation request, string considerIp)
		{
			request.ConsiderIp = considerIp;
			return request;
		}

		public static Geolocation WithHomeMobileCountryCode(this Geolocation request, int homeMobileCountryCode)
		{
			request.HomeMobileCountryCode = homeMobileCountryCode;
			return request;
		}

		public static Geolocation WithHomeMobileNetworkCode(this Geolocation request, int homeMobileNetworkCode)
		{
			request.HomeMobileNetworkCode = homeMobileNetworkCode;
			return request;
		}

		public static Geolocation WithRadioType(this Geolocation request, string radioType)
		{
			request.RadioType = radioType;
			return request;
		}

		public static Geolocation WithCellTowers(this Geolocation request, List<CellTower> cellTowers)
		{
			request.CellTowers = cellTowers;
			return request;
		}

		public static Geolocation WithWifiAccessPoints(this Geolocation request,
			List<WifiAccessPoint> wifiAccessPoints)
		{
			request.WifiAccessPoints = wifiAccessPoints;
			return request;
		}

		#endregion

		#region Places Request

		#region Place Nearby Search

		public static PlaceNearbySearch GetPlaceNearbySearch() => new PlaceNearbySearch { Key = Key };

		public static PlaceNearbySearch WithKeyword(this PlaceNearbySearch request, string keyword)
		{
			request.Keyword = keyword;
			return request;
		}

		public static PlaceNearbySearch WithLanguage(this PlaceNearbySearch request, string language)
		{
			request.Language = language;
			return request;
		}

		public static PlaceNearbySearch WithLocation(this PlaceNearbySearch request, string location)
		{
			request.Location = location;
			return request;
		}

		public static PlaceNearbySearch WithMaxPrice(this PlaceNearbySearch request, string maxPrice)
		{
			request.MaxPrice = maxPrice;
			return request;
		}

		public static PlaceNearbySearch WithMinPrice(this PlaceNearbySearch request, string minPrice)
		{
			request.MinPrice = minPrice;
			return request;
		}

		public static PlaceNearbySearch WithName(this PlaceNearbySearch request, string name)
		{
			request.Name = name;
			return request;
		}

		public static PlaceNearbySearch WithOpenNow(this PlaceNearbySearch request, string openNow)
		{
			request.OpenNow = openNow;
			return request;
		}

		public static PlaceNearbySearch WithPagetoken(this PlaceNearbySearch request, string pagetoken)
		{
			request.Pagetoken = pagetoken;
			return request;
		}

		public static PlaceNearbySearch WithRadius(this PlaceNearbySearch request, string radius)
		{
			request.Radius = radius;
			return request;
		}

		public static PlaceNearbySearch WithRankby(this PlaceNearbySearch request, string rankby)
		{
			request.Rankby = rankby;
			return request;
		}

		public static PlaceNearbySearch WithTypes(this PlaceNearbySearch request, string types)
		{
			request.Types = types;
			return request;
		}

		public static PlaceNearbySearch WithZagatSelectedy(this PlaceNearbySearch request, string zagatSelected)
		{
			request.ZagatSelected = zagatSelected;
			return request;
		}

		#endregion

		#region Place Text Search

		public static PlaceTextSearch GetPlaceTextSearch() => new PlaceTextSearch { Key = Key };

		public static PlaceTextSearch WithKeyword(this PlaceTextSearch request, string query)
		{
			request.Query = query;
			return request;
		}

		public static PlaceTextSearch WithLanguage(this PlaceTextSearch request, string language)
		{
			request.Language = language;
			return request;
		}

		public static PlaceTextSearch WithLocation(this PlaceTextSearch request, string location)
		{
			request.Location = location;
			return request;
		}

		public static PlaceTextSearch WithMaxPrice(this PlaceTextSearch request, string maxPrice)
		{
			request.MaxPrice = maxPrice;
			return request;
		}

		public static PlaceTextSearch WithMinPrice(this PlaceTextSearch request, string minPrice)
		{
			request.MinPrice = minPrice;
			return request;
		}

		public static PlaceTextSearch WithOpenNow(this PlaceTextSearch request, string openNow)
		{
			request.OpenNow = openNow;
			return request;
		}

		public static PlaceTextSearch WithPagetoken(this PlaceTextSearch request, string pagetoken)
		{
			request.Pagetoken = pagetoken;
			return request;
		}

		public static PlaceTextSearch WithRadius(this PlaceTextSearch request, string radius)
		{
			request.Radius = radius;
			return request;
		}

		public static PlaceTextSearch WithTypes(this PlaceTextSearch request, string types)
		{
			request.Types = types;
			return request;
		}

		public static PlaceTextSearch WithZagatSelectedy(this PlaceTextSearch request, string zagatSelected)
		{
			request.ZagatSelected = zagatSelected;
			return request;
		}

		#endregion

		#region Place Radar Search

		public static PlaceRadarSearch GetPlaceRadarSearch() => new PlaceRadarSearch { Key = Key };

		public static PlaceRadarSearch WithKeyword(this PlaceRadarSearch request, string keyword)
		{
			request.Keyword = keyword;
			return request;
		}

		public static PlaceRadarSearch WithLocation(this PlaceRadarSearch request, string location)
		{
			request.Location = location;
			return request;
		}

		public static PlaceRadarSearch WithMaxPrice(this PlaceRadarSearch request, string maxPrice)
		{
			request.MaxPrice = maxPrice;
			return request;
		}

		public static PlaceRadarSearch WithMinPrice(this PlaceRadarSearch request, string minPrice)
		{
			request.MinPrice = minPrice;
			return request;
		}

		public static PlaceRadarSearch WithName(this PlaceRadarSearch request, string name)
		{
			request.Name = name;
			return request;
		}

		public static PlaceRadarSearch WithOpenNow(this PlaceRadarSearch request, string openNow)
		{
			request.OpenNow = openNow;
			return request;
		}

		public static PlaceRadarSearch WithPagetoken(this PlaceRadarSearch request, string pagetoken)
		{
			request.Pagetoken = pagetoken;
			return request;
		}

		public static PlaceRadarSearch WithRadius(this PlaceRadarSearch request, string radius)
		{
			request.Radius = radius;
			return request;
		}

		public static PlaceRadarSearch WithTypes(this PlaceRadarSearch request, string types)
		{
			request.Types = types;
			return request;
		}

		public static PlaceRadarSearch WithZagatSelectedy(this PlaceRadarSearch request, string zagatSelected)
		{
			request.ZagatSelected = zagatSelected;
			return request;
		}

		#endregion

		#region Place Autocomplete 

		public static PlaceAutocomplete GetPlaceAutocomplete() => new PlaceAutocomplete { Key = Key };

		public static PlaceAutocomplete WithKeyword(this PlaceAutocomplete request, string input)
		{
			request.Input = input;
			return request;
		}

		public static PlaceAutocomplete WithLanguage(this PlaceAutocomplete request, string language)
		{
			request.Language = language;
			return request;
		}

		public static PlaceAutocomplete WithLocation(this PlaceAutocomplete request, string location)
		{
			request.Location = location;
			return request;
		}

		public static PlaceAutocomplete WithRadius(this PlaceAutocomplete request, string radius)
		{
			request.Radius = radius;
			return request;
		}

		public static PlaceAutocomplete WithTypes(this PlaceAutocomplete request, string types)
		{
			request.Types = types;
			return request;
		}

		public static PlaceAutocomplete WithComponents(this PlaceAutocomplete request, string components)
		{
			request.Components = components;
			return request;
		}

		public static PlaceAutocomplete WithOffset(this PlaceAutocomplete request, string offset)
		{
			request.Offset = offset;
			return request;
		}

		#endregion

		#region Place Query Autocomplete

		public static PlaceQueryAutocomplete GetPlaceQueryAutocomplete() => new PlaceQueryAutocomplete { Key = Key };

		public static PlaceQueryAutocomplete WithKeyword(this PlaceQueryAutocomplete request, string input)
		{
			request.Input = input;
			return request;
		}

		public static PlaceQueryAutocomplete WithLanguage(this PlaceQueryAutocomplete request, string language)
		{
			request.Language = language;
			return request;
		}

		public static PlaceQueryAutocomplete WithLocation(this PlaceQueryAutocomplete request, string location)
		{
			request.Location = location;
			return request;
		}

		public static PlaceQueryAutocomplete WithRadius(this PlaceQueryAutocomplete request, string radius)
		{
			request.Radius = radius;
			return request;
		}

		public static PlaceQueryAutocomplete WithOffset(this PlaceQueryAutocomplete request, string offset)
		{
			request.Offset = offset;
			return request;
		}

		#endregion

		#region Place Details

		public static PlaceDetails GetPlaceDetails() => new PlaceDetails { Key = Key };

		public static PlaceDetails WithExtensions(this PlaceDetails request, string extensions)
		{
			request.Extensions = extensions;
			return request;
		}

		public static PlaceDetails WithLanguage(this PlaceDetails request, string language)
		{
			request.Language = language;
			return request;
		}

		public static PlaceDetails WithPlaceId(this PlaceDetails request, string placeId)
		{
			request.PlaceId = placeId;
			return request;
		}

		public static PlaceDetails WithReference(this PlaceDetails request, string reference)
		{
			request.Reference = reference;
			return request;
		}

		#endregion

		#region Place Add

		public static PlaceAdd GetPlaceAdd() => new PlaceAdd();

		public static PlaceAdd WithAccuracy(this PlaceAdd request, int accuracy)
		{
			request.Accuracy = accuracy;
			return request;
		}

		public static PlaceAdd WithLanguage(this PlaceAdd request, string language)
		{
			request.Language = language;
			return request;
		}

		public static PlaceAdd WithAddress(this PlaceAdd request, string address)
		{
			request.Address = address;
			return request;
		}

		public static PlaceAdd WithName(this PlaceAdd request, string name)
		{
			request.Name = name;
			return request;
		}

		public static PlaceAdd WithWebsite(this PlaceAdd request, string website)
		{
			request.Website = website;
			return request;
		}

		public static PlaceAdd WithPhoneNumber(this PlaceAdd request, string phone)
		{
			request.PhoneNumber = phone;
			return request;
		}

		public static PlaceAdd WithTypes(this PlaceAdd request, List<string> types)
		{
			request.Types = types;
			return request;
		}

		#endregion

		#region Place Delete

		public static PlaceDelete GetPlaceDelete() => new PlaceDelete();

		public static PlaceDelete WithPlaceId(this PlaceDelete request, string placeId)
		{
			request.PlaceId = placeId;
			return request;
		}

		#endregion

		#region Place Photo

		public static PlacePhoto GetPlacePhoto() => new PlacePhoto { Key = Key };

		public static PlacePhoto WithExtensions(this PlacePhoto request, string photoReference)
		{
			request.PhotoReference = photoReference;
			return request;
		}

		public static PlacePhoto WithMaxHeight(this PlacePhoto request, string maxHeight)
		{
			request.MaxHeight = maxHeight;
			return request;
		}

		public static PlacePhoto WithMaxWidth(this PlacePhoto request, string maxWidth)
		{
			request.MaxWidth = maxWidth;
			return request;
		}

		#endregion

		#endregion
	}
}