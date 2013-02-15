using System;
using System.Xml.Serialization;

namespace SevenDigital.Api.Schema.Premium.User
{
	[XmlRoot("user")]
	[Serializable]
	public class User
	{
		[XmlAttribute("id")]
		public string Id { get; set; }

		[XmlElement("type")]
		public string Type { get; set; }

		[XmlElement("emailAddress")]
		public string EmailAddress { get; set; }
	}
}