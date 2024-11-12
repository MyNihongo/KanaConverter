namespace MyNihongo.KanaConverter;

internal static class StringBuilderEx
{
	public static void Append(this StringBuilder @this, in YouonChar youonChar)
	{
		@this.Append(youonChar.Char);

		if (youonChar.SecondChar.HasValue)
			@this.Append(youonChar.SecondChar.Value);
	}

	public static void Set(this StringBuilder @this, int index, in YouonChar youonChar)
	{
		@this[index] = youonChar.Char;

		if (youonChar.SecondChar.HasValue)
			@this.Append(youonChar.SecondChar.Value);
	}

	public static bool IsEqual(this StringBuilder @this, in string value)
	{
		if (@this.Length != value.Length)
			return false;

		for (var i = 0; i < value.Length; i++)
		{
			if (value[i] != @this[i])
				return false;
		}

		return true;
	}
}
