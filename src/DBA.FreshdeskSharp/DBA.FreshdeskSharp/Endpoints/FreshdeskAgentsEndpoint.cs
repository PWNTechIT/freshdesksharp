namespace DBA.FreshdeskSharp.Endpoints
{
	using System;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using Core;
	using Models;
	using Models.Internal;
	using Newtonsoft.Json;

	public class FreshdeskAgentsEndpoint : FreshdeskEndpointBase
	{
		private readonly string _apiBaseUri;
		private readonly FreshdeskHttpClient _httpClient;
		private readonly JsonSerializerSettings _serializationSettings;

		internal FreshdeskAgentsEndpoint(FreshdeskConfigInternal config, FreshdeskHttpClient httpClient, JsonSerializerSettings serializationSettings)
		{
			_apiBaseUri = config.ApiBaseUri;
			_httpClient = httpClient;
			_serializationSettings = serializationSettings;
		}

		public async Task<List<FreshdeskAgent>> GetListAsync(FreshdeskAgentsListOptions options = null)
		{
			var query = GetListQueryString(options);
			var requestUri = $"{_apiBaseUri}/agents{query}";
			using (var response = await _httpClient.GetAsync(requestUri).ConfigureAwait(false))
			{
				return await GetResponseAsync<List<FreshdeskAgent>>(response).ConfigureAwait(false);
			}
		}

		private static string GetListQueryString(FreshdeskAgentsListOptions options)
		{
			if (options == null)
			{
				return "";
			}

			var filters = new List<string>();
			if (options.Email != default(string))
			{
				filters.Add($"email={options.Email.ToLowerInvariant()}");
			}
			if (options.Mobile != default(string))
			{
				filters.Add($"mobile={options.Mobile.ToLowerInvariant()}");
			}
			if (options.Phone != default(string))
			{
				filters.Add($"phone={options.Phone.ToLowerInvariant()}");
			}
			if (options.State != null)
			{
				filters.Add($"state={Enum.GetName(typeof(FreshdeskAgentFilterState), options.State).ToLowerInvariant()}");
			}

			AddPageFilters(options, filters);
			return filters.Count == 0 ? "" : $"?{string.Join("&", filters)}";
		}
	}
}
