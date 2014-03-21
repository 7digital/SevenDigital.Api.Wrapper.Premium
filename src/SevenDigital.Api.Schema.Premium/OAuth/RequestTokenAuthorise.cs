using System;
using SevenDigital.Api.Schema.Attributes;
using SevenDigital.Api.Schema.OAuth;

namespace SevenDigital.Api.Schema.Premium.OAuth
{
	[ApiEndpoint("oauth/requestToken/authorise")]
	[Serializable]
	[HttpPost]
	[OAuthSigned]
	[RequireSecure]
	public class RequestTokenAuthorise
	{ }
}