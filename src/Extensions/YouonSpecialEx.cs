using System;

namespace MyNihongo.KanaConverter
{
	internal static class YouonSpecialEx
	{
		public static Youon ToYouon(this YouonSpecial @this) =>
			@this switch
			{
				YouonSpecial.A => Youon.A,
				YouonSpecial.I => Youon.I,
				YouonSpecial.U => Youon.U,
				YouonSpecial.E => Youon.E,
				YouonSpecial.O => Youon.O,
				_ => throw new ArgumentOutOfRangeException(nameof(@this), $@"Unknown {nameof(YouonSpecial)}: {@this}")
			};

		public static char GetChar(this YouonSpecial @this) =>
			@this switch
			{
				YouonSpecial.A => 'a',
				YouonSpecial.I => 'i',
				YouonSpecial.U => 'u',
				YouonSpecial.E => 'e',
				YouonSpecial.O => 'o',
				_ => throw new ArgumentOutOfRangeException(nameof(@this), $@"Unknown {nameof(YouonSpecial)}: {@this}")
			};
	}
}
