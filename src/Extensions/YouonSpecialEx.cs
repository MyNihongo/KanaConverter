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
				_ => throw new ArgumentOutOfRangeException(nameof(@this), $@"Unknown {nameof(YouonSpecial)}: {@this}")
			};

		public static char GetChar(this YouonSpecial @this) =>
			@this switch
			{
				YouonSpecial.I => 'i',
				YouonSpecial.E => 'e',
				_ => throw new ArgumentOutOfRangeException(nameof(@this), $@"Unknown {nameof(YouonSpecial)}: {@this}")
			};
	}
}
