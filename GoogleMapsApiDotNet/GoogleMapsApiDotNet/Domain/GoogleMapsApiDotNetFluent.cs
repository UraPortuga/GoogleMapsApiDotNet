using System.Collections.Generic;
using System.Linq;
using GoogleMapsApiDotNet.DirectionsApi.Domain.Resquest;
using GoogleMapsApiDotNet.DistanceMatrixApi.Domain.Request;
using GoogleMapsApiDotNet.ElevationApi.Domain.Request;
using GoogleMapsApiDotNet.GeocodingApi.Domain.Resquest;
using GoogleMapsApiDotNet.GeolocationApi.Domain;
using GoogleMapsApiDotNet.GeolocationApi.Domain.Request;
using GoogleMapsApiDotNet.RoadsApi.Domain.Request;
using GoogleMapsApiDotNet.TimeZoneApi.Domain.Request;
using static System.Configuration.ConfigurationSettings;

namespace GoogleMapsApiDotNet.Domain
{
	public static class GoogleMapsApiDotNetFluent
	{
		private static string Key => AppSettings["Key"];

		#region Elevation Request


		public static ElevationRequest GetElevation()
		{
			return new ElevationRequest { Key = Key };
		}

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

		public static TimeZoneRequest GetTimeZone()
		{
			return new TimeZoneRequest { Key = Key };
		}

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

		public static SnapRoadsRequest GetSnapRoads()
		{
			return new SnapRoadsRequest { Key = Key };
		}

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

		public static SpeedLimitRequest GetSpeedLimit()
		{
			return new SpeedLimitRequest { Key = Key };
		}

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

		public static DirectionsRequest GetDirections()
		{
			return new DirectionsRequest { Key = Key };
		}

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

		public static DirectionsRequest WithTransitRoutingPreference(this DirectionsRequest request, string transitRoutingPreference)
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

		public static DistanceMatrixRequest GetDistanceMatrix()
		{
			return new DistanceMatrixRequest { Key = Key };
		}
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

		public static DistanceMatrixRequest WithTransitRoutingPreference(this DistanceMatrixRequest request, string transitRoutingPreference)
		{
			request.TransitRoutingPreference = transitRoutingPreference;
			return request;
		}



		#endregion

		#region Geocoding Request

		public static GeocodingRequest GetGeocoding()
		{
			return new GeocodingRequest { Key = Key };
		}
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

		public static GeolocationRequest GetGeolocation()
		{
			return new GeolocationRequest { Key = Key };
		}
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

		public static GeolocationRequest WithWifiAccessPoints(this GeolocationRequest request, List<WifiAccessPoint> wifiAccessPoints)
		{
			request.WifiAccessPoints = wifiAccessPoints;
			return request;
		}

		#endregion

		#region Places Request



		#endregion
	}
}