namespace MyNihongo.KanaConverter;

public static class ToRomajiStringEx
{
	/// <summary>
	/// Converts a kana (hiragana or katakana) string to romaji.
	/// </summary>
	/// <param name="this">Kana string to be converted to romaji.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="stringBuilderPool">String builder pool that is useful when many strings are converted in a loop.</param>
	/// <exception cref="InvalidCharacterException"></exception>
	public static string ToRomaji(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy = default, ObjectPool<StringBuilder>? stringBuilderPool = null)
	{
		var result = new StringTextContainer(@this)
			.ConvertToRomaji(unrecognisedCharacterPolicy, stringBuilderPool);

		if (result.ErrorMessage != null)
			throw new InvalidCharacterException(result.ErrorMessage);

		return result.Value;
	}

	/// <summary>
	/// Tries to convert a kana (hiragana or katakana) string to romaji.
	/// </summary>
	/// <param name="this">Kana string to be converted to romaji.</param>
	/// <param name="value">Romaji string after conversion.</param>
	public static bool TryConvertToRomaji(this string @this, out string value) =>
		@this.TryConvertToRomaji(unrecognisedCharacterPolicy: default, stringBuilderPool: null, out value);

	/// <summary>
	/// Tries to convert a kana (hiragana or katakana) string to romaji.
	/// </summary>
	/// <param name="this">Kana string to be converted to romaji.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="value">Romaji string after conversion.</param>
	public static bool TryConvertToRomaji(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, out string value) =>
		@this.TryConvertToRomaji(unrecognisedCharacterPolicy, stringBuilderPool: null, out value);

	/// <summary>
	/// Tries to convert a kana (hiragana or katakana) string to romaji.
	/// </summary>
	/// <param name="this">Kana string to be converted to romaji.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="stringBuilderPool">String builder pool that is useful when many strings are converted in a loop.</param>
	/// <param name="value">Romaji string after conversion.</param>
	public static bool TryConvertToRomaji(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, ObjectPool<StringBuilder>? stringBuilderPool, out string value)
	{
		var result = new StringTextContainer(@this)
			.ConvertToRomaji(unrecognisedCharacterPolicy, stringBuilderPool);

		value = result.Value;

		if (unrecognisedCharacterPolicy == UnrecognisedCharacterPolicy.Append)
			return result.ErrorMessage == null && value != @this;

		return result.ErrorMessage == null;
	}
}
