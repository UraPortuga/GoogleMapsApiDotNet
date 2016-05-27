using Newtonsoft.Json;
using static System.Configuration.ConfigurationSettings;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace GoogleMapsApiDotNet.Domain.Domain
{
	public class BaseRequest
	{
		public BaseRequest()
		{

			ServicePointManager.DefaultConnectionLimit = 100;
			ServicePointManager.Expect100Continue = false;
		}

		[JsonIgnore]
		public static TimeSpan TimeoutRest { get; set; } = Timeout.InfiniteTimeSpan;

		[JsonIgnore]
		public static string Url { get; set; }

		public static void SetUrl<T>()
		{
			Url = AppSettings[nameof(T)];
		}

		public async Task<T> GetAsync<T>(string resourceUri)
		{
			using (var client = new HttpClient())
			{
				SetUrl<T>();
				client.BaseAddress = new Uri(Url);
				client.DefaultRequestHeaders.Accept.Clear();
				client.Timeout = TimeoutRest;
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				var response = await client.GetAsync(resourceUri);
				if (response.IsSuccessStatusCode)
					return await response.Content.ReadAsAsync<T>();
				return default(T);
			}
		}

		public async Task<T> PostAsync<T>(object pObject, string resourceUri = null)
		{
			using (var client = new HttpClient())
			{
				SetUrl<T>();
				client.BaseAddress = new Uri(Url);
				client.DefaultRequestHeaders.Accept.Clear();
				client.Timeout = TimeoutRest;
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				var response = await client.PostAsJsonAsync(resourceUri, pObject);
				if (response.IsSuccessStatusCode)
					return await response.Content.ReadAsAsync<T>();
				return default(T);
			}
		}

	}
}