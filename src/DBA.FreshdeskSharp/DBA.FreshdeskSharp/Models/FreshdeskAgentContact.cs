using System;
using Newtonsoft.Json;

namespace DBA.FreshdeskSharp.Models
{
	public class FreshdeskAgentContact
	{
		/// <summary>
		/// Set to true if the agent is verified
		/// </summary>
		public bool Active { get; set; }
		/// <summary>
		/// Email address of the agent
		/// </summary>
		public string Email { get; set; }
		/// <summary>
		/// Job title of the agent
		/// </summary>
		[JsonProperty("job_title")]
		public object JobTitle { get; set; }
		/// <summary>
		/// Language of the agent. Default language is "en"
		/// </summary>
		public string Language { get; set; }
		/// <summary>
		/// Timestamp of the agent's last successful login
		/// </summary>
		[JsonProperty("last_login_at")]
		public DateTime? LastLoginAt { get; set; }
		/// <summary>
		/// Mobile number of the agent
		/// </summary>
		public object Mobile { get; set; }
		/// <summary>
		/// Name of the agent
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Telephone number of the agent
		/// </summary>
		public object Phone { get; set; }
		
		/// <summary>
		/// Time zone of the agent
		/// </summary>
		[JsonProperty("time_zone")]
		public string TimeZone { get; set; }
		
		/// <summary>
		/// Creation timestamp
		/// </summary>
		[JsonProperty("created_at")]
		public DateTime? CreatedAt { get; set; }
		
		/// <summary>
		/// Timestamp of the last update
		/// </summary>
		[JsonProperty("updated_at")]
		public DateTime? UpdatedAt { get; set; }
	}
}