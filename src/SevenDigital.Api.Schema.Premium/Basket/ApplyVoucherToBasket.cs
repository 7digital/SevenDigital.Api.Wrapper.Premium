using System.Xml.Serialization;
using SevenDigital.Api.Schema.Attributes;
using SevenDigital.Api.Schema.OAuth;

namespace SevenDigital.Api.Schema.Premium.Basket
{
	[XmlRoot("basket")]
	[OAuthSigned]
	[HttpPost]
	[RequireSecure]
	[ApiEndpoint("basket/applyVoucher")]
	public class ApplyVoucherToBasket : Schema.Basket.Basket, HasVoucherParameter
	{ }
}