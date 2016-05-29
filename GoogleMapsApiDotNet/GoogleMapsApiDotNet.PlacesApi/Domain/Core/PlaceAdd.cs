using System.Collections.Generic;

namespace GoogleMapsApiDotNet.PlacesApi.Domain.Request
{
	public partial class PlaceAdd
	{
		public PlaceAdd WithAccuracy(int accuracy)
		{
			Accuracy = accuracy;
			return this;
		}

		public PlaceAdd WithLanguage(string language)
		{
			Language = language;
			return this;
		}

		public PlaceAdd WithAddress(string address)
		{
			Address = address;
			return this;
		}

		public PlaceAdd WithName(string name)
		{
			Name = name;
			return this;
		}

		public PlaceAdd WithWebsite(string website)
		{
			Website = website;
			return this;
		}

		public PlaceAdd WithPhoneNumber(string phone)
		{
			PhoneNumber = phone;
			return this;
		}

		public PlaceAdd WithTypes(List<string> types)
		{
			Types = types;
			return this;
		}
	}
}