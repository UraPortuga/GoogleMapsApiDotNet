using System.Collections.Generic;

namespace GoogleMapsApiDotNet.DirectionsApi.Domain.Resquest
{
	public partial class Directions
	{
		public Directions WithAlternatives(string alternatives)
		{
			Alternatives = alternatives;
			return this;
		}

		public Directions WithArrivalTime(string arrivalTime)
		{
			ArrivalTime = arrivalTime;
			return this;
		}

		public Directions WithUnits(string units)
		{
			Units = units;
			return this;
		}

		public Directions WithAvoid(string avoid)
		{
			Avoid = avoid;
			return this;
		}

		public Directions WithDepartureTime(string departureTime)
		{
			DepartureTime = departureTime;
			return this;
		}

		public Directions WithDestination(List<string> destinations)
		{
			Destination = destinations;
			return this;
		}

		public Directions WithLanguage(string language)
		{
			Language = language;
			return this;
		}

		public Directions WithMode(string mode)
		{
			Mode = mode;
			return this;
		}

		public Directions WithOrigin(string origin)
		{
			Origin = origin;
			return this;
		}

		public Directions WithRegion(string region)
		{
			Region = region;
			return this;
		}

		public Directions WithTrafficModel(string trafficModel)
		{
			TrafficModel = trafficModel;
			return this;
		}

		public Directions WithTransitMode(string transitMode)
		{
			TransitMode = transitMode;
			return this;
		}

		public Directions WithTransitRoutingPreference(string transitRoutingPreference)
		{
			TransitRoutingPreference = transitRoutingPreference;
			return this;
		}

		public Directions WithWaypoints(List<string> waypoints)
		{
			Waypoints = waypoints;
			return this;
		}
	}
}