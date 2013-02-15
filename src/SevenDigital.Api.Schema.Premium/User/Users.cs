using System.Collections.Generic;
using System.Xml.Serialization;
using SevenDigital.Api.Schema.Attributes;
using SevenDigital.Api.Schema.OAuth;

namespace SevenDigital.Api.Schema.Premium.User
{
	[XmlRoot("users")]
	[OAuthSigned]
	[ApiEndpoint("users")]
	public class Users
	{
		[XmlElement("user")]
		public List<User> UserList { get; set; }
	}
}