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
				Youon.E => 'e',
				Youon.I => 'i',
				Youon.A => 'a',
				Youon.O => 'o',
				_ => throw new ArgumentOutOfRangeException(nameof(@this), @this, $@"Unknown {nameof(Youon)}: {@this}")
			};
	}
}
