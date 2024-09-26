namespace MyNihongo.KanaConverter;

public static class StringExRomajiToKatakana
{
	/// <summary>
	/// Converts a romaji string to katakana.
	/// </summary>
	/// <param name="this">Romaji string to be converted to katakana.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="stringBuilderPool">String builder pool that is useful when many strings are converted in a loop.</param>
	/// <exception cref="InvalidCharacterException"></exception>
	public static string ToKatakana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy = default, ObjectPool<StringBuilder>? stringBuilderPool = null)
	{
		var result = @this.ConvertToKatakana(unrecognisedCharacterPolicy, stringBuilderPool);

		if (result.ErrorMessage != null)
			throw new InvalidCharacterException(result.ErrorMessage);

		return result.Value;
	}

	private static ConversionResult ConvertToKatakana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, ObjectPool<StringBuilder>? stringBuilderPool)
	{
		if (string.IsNullOrEmpty(@this))
			return ConversionResult.FromValue(string.Empty);

		var capacity = @this.Length / 2;
		var stringBuilder = stringBuilderPool?.Get() ?? new StringBuilder(capacity);
		stringBuilder.Capacity = capacity;

		try
		{
			int charBuilder = 0;

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
