namespace MyNihongo.KanaConverter;

public static class StringExRomajiToKatakana
{
	private static ConversionResult ConvertToKatakana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, ObjectPool<StringBuilder>? stringBuilderPool)
	{
		if (string.IsNullOrEmpty(@this))
			return ConversionResult.FromValue(string.Empty);

		var capacity = @this.Length / 2;
		var stringBuilder = stringBuilderPool?.Get() ?? new StringBuilder(capacity);
		stringBuilder.Capacity = capacity;

		try
		{
			char? prevChar = null;

			for (var i = 0; i < @this.Length; i++)
			{
				switch (char.ToLower(@this[i]))
				{
					// basic vowels
					case 'a':
					case 'i':
					case 'u':
					case 'e':
					case 'o':
						continue;
					// consonants
					case 'k':
					case 'g':
					case 's':
					case 'z':
					case 't':
					case 'd':
					case 'h':
					case 'b':
					case 'p':
					case 'r':
					case 'n':
					case 'w':
						prevChar = @this[i];
						continue;
					// special consonants with possible 拗音
					case 'y':
						continue;
					default:
					{
						switch (unrecognisedCharacterPolicy)
						{
							case UnrecognisedCharacterPolicy.Skip:
								continue;
							case UnrecognisedCharacterPolicy.Append:
								stringBuilder.Append(@this[i]);
								continue;
							default:
								return ConversionResult.FromError($"Invalid kana character \"{@this[i]}\" in \"{@this}\"");
						}
					}
				}
			}

			return ConversionResult.FromValue(stringBuilder.ToString());
		}
		finally
		{
			stringBuilderPool?.Return(stringBuilder);
		}
	}
}
