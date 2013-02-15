using SevenDigital.Api.Schema.Premium.Basket;

namespace SevenDigital.Api.Wrapper.Premium
{
	public static class HasVoucherParameterExtensions
	{
		public static IFluentApi<T> UseVoucherCode<T>(this IFluentApi<T> api, string voucherCode) where T : HasVoucherParameter
		{
			api.WithParameter("vouchercode", voucherCode);
			return api;
		}
	}
}