namespace MyNihongo.KanaConverter;

internal static class YouonEx
{
	public static YouonChar GetChar(this Youon @this) =>
		@this switch
		{
			Youon.Ya => new YouonChar('a'),
			Youon.Yu => new YouonChar('u'),
			Youon.Yo => new YouonChar('o'),
			Youon.A => new YouonChar('a'),
			Youon.I => new YouonChar('i'),
			Youon.U => new YouonChar('u'),
			Youon.E => new YouonChar('e'),
			Youon.O => new YouonChar('o'),
			Youon.Wa => new YouonChar('w', 'a'),
			_ => throw new ArgumentOutOfRangeException(nameof(@this), @this, $@"Unknown {nameof(Youon)}: {@this}")
		};
}