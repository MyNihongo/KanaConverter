using System;

namespace MyNihongo.KanaConverter
{
	internal static class YouonSpecialEx
	{
		public static Youon ToYouon(this YouonSpecial @this) =>
			@this switch
			{
				YouonSpecial.I => Youon.I,
				YouonSpecial.E => Youon.E,
				YouonSpecial.A => Youon.A,
				YouonSpecial.O => Youon.O,
				_ => throw new ArgumentOutOfRangeException(nameof(@this), $@"Unknown {nameof(YouonSpecial)}: {@this}")
			};

		public static char GetChar(this YouonSpecial @this) =>
			@this switch
			{
				YouonSpecial.I => 'i',
				YouonSpecial.E => 'e',
				YouonSpecial.A => 'a',
				YouonSpecial.O => 'o',
				_ => throw new ArgumentOutOfRangeException(nameof(@this), $@"Unknown {nameof(YouonSpecial)}: {@this}")
			};
	}
}
