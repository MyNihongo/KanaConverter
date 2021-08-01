using System;

namespace MyNihongo.KanaConverter
{
	internal static class YouonEx
	{
		public static char GetChar(this Youon @this) =>
			@this switch
			{
				Youon.Ya => 'a',
				Youon.Yu => 'u',
				Youon.Yo => 'o',
				Youon.A => 'a',
				Youon.I => 'i',
				Youon.U => 'u',
				Youon.E => 'e',
				Youon.O => 'o',
				_ => throw new ArgumentOutOfRangeException(nameof(@this), @this, $@"Unknown {nameof(Youon)}: {@this}")
			};
	}
}
