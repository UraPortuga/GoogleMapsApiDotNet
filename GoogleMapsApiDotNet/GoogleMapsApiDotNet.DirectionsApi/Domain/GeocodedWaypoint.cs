﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsApiDotNet.DirectionsApi.Domain
{
	public class GeocodedWaypoint
	{
		public string Geocoder_status { get; set; }
		public string Place_id { get; set; }
		public List<string> Types { get; set; }
	}
}
