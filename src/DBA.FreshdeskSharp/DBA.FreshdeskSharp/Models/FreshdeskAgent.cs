namespace DBA.FreshdeskSharp.Models
{
	using System;
	using Newtonsoft.Json;
	using System.Collections.Generic;

	public class FreshdeskAgent
	{
		/// <summary>
		/// If the agent is in a group that has enabled "Automatic Ticket Assignment", this attribute will be set to true if the agent is accepting new tickets
		/// </summary>
		public bool Available { get; set; }
		
		/// <summary>
		/// Timestamp that denotes when the agent became available/unavailable (depending on the value of the 'available' attribute)
		/// </summary>
		[JsonProperty("available_since")] 
		public DateTime? AvailableSince { get; set; }

		/// <summary>
		/// User ID of the agent
		/// </summary>
		public ulong Id { get; set; }

		/// <summary>
		/// Set to true if this is an occasional agent (true => occasional, false => full-time)
		/// </summary>
		public bool Occasional { get; set; }

		/// <summary>
		/// Signature of the agent in HTML format
		/// </summary>
		public string Signature { get; set; }

		/// <summary>
		/// Ticket permission of the agent
		/// (1 -&gt; Global Access, 2 -&gt; Group Access, 3 -&gt; Restricted Access)
		/// </summary>
		[JsonProperty("ticket_scope")] 
		public FreshdeskAgentTicketScopeEnum TicketScope { get; set; }

		/// <summary>
		/// Group IDs associated with the agent
		/// </summary>
		[JsonProperty("group_ids")]
		public List<ulong> GroupIds { get; set; }

		/// <summary>
		/// Role IDs associated with the agent
		/// </summary>
		[JsonProperty("role_ids")]
		public List<ulong> RoleIds { get; set; }

		/// <summary>
		/// Agent creation timestamp
		/// </summary>
		[JsonProperty("created_at")]
		public DateTime? CreatedAt { get; set; }

		/// <summary>
		/// Agent updated timestamp
		/// </summary>
		[JsonProperty("updated_at")]
		public DateTime? UpdatedAt { get; set; }

		/// <summary>
		/// Agent's contact information
		/// </summary>
		public FreshdeskAgentContact Contact { get; set; }
	}
}
