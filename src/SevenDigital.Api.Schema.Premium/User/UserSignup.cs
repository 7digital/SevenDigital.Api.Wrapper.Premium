using System;
using System.Xml.Serialization;
using SevenDigital.Api.Schema.Attributes;
using SevenDigital.Api.Schema.OAuth;

namespace SevenDigital.Api.Schema.Premium.User
{
	[ApiEndpoint("user/signup")]
	[HttpPost]
	[OAuthSigned]
	[RequireSecure]
	[XmlRoot("user")]
	[Serializable]
	public class UserSignup : User
	{}
}