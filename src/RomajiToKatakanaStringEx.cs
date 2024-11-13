namespace MyNihongo.KanaConverter;

public static class RomajiToKatakanaStringEx
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
		var result = new StringTextContainer(@this)
			.ConvertToKatakana(unrecognisedCharacterPolicy, stringBuilderPool);

		if (result.ErrorMessage != null)
			throw new InvalidCharacterException(result.ErrorMessage);

		return result.Value;
	}

	/// <summary>
	/// Tries to convert a romaji string to katakana.
	/// </summary>
	/// <param name="this">Romaji string to be converted to katakana.</param>
	/// <param name="value">Katakana string after conversion.</param>
	public static bool TryConvertToKatakana(this string @this, out string value) =>
		@this.TryConvertToKatakana(unrecognisedCharacterPolicy: default, stringBuilderPool: null, out value);

	/// <summary>
	/// Tries to convert a romaji string to katakana.
	/// </summary>
	/// <param name="this">Romaji string to be converted to katakana.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="value">Katakana string after conversion.</param>
	public static bool TryConvertToKatakana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, out string value) =>
		@this.TryConvertToKatakana(unrecognisedCharacterPolicy, stringBuilderPool: null, out value);

	/// <summary>
	/// Tries to convert a romaji string to katakana.
	/// </summary>
	/// <param name="this">Romaji string to be converted to katakana.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="stringBuilderPool">String builder pool that is useful when many strings are converted in a loop.</param>
	/// <param name="value">Katakana string after conversion.</param>
	public static bool TryConvertToKatakana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, ObjectPool<StringBuilder>? stringBuilderPool, out string value)
	{
		var result = new StringTextContainer(@this)
			.ConvertToKatakana(unrecognisedCharacterPolicy, stringBuilderPool);

		value = result.Value;

		if (unrecognisedCharacterPolicy == UnrecognisedCharacterPolicy.Append)
			return result.ErrorMessage == null && value != @this;

		return result.ErrorMessage == null;
	}
}
