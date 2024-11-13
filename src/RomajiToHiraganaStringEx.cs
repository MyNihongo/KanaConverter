namespace MyNihongo.KanaConverter;

public static class RomajiToHiraganaStringEx
{
	/// <summary>
	/// Converts a romaji string to hiragana.
	/// </summary>
	/// <param name="this">Romaji string to be converted to hiragana.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="stringBuilderPool">String builder pool that is useful when many strings are converted in a loop.</param>
	/// <exception cref="InvalidCharacterException"></exception>
	public static string ToHiragana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy = default, ObjectPool<StringBuilder>? stringBuilderPool = null)
	{
		var result = new StringTextContainer(@this)
			.ConvertToHiragana(unrecognisedCharacterPolicy, stringBuilderPool);

		if (result.ErrorMessage != null)
			throw new InvalidCharacterException(result.ErrorMessage);

		return result.Value;
	}

	/// <summary>
	/// Tries to convert a romaji string to hiragana.
	/// </summary>
	/// <param name="this">Romaji string to be converted to hiragana.</param>
	/// <param name="value">Hiragana string after conversion.</param>
	public static bool TryConvertToHiragana(this string @this, out string value) =>
		@this.TryConvertToHiragana(unrecognisedCharacterPolicy: default, stringBuilderPool: null, out value);

	/// <summary>
	/// Tries to convert a romaji string to hiragana.
	/// </summary>
	/// <param name="this">Romaji string to be converted to hiragana.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="value">Hiragana string after conversion.</param>
	public static bool TryConvertToHiragana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, out string value) =>
		@this.TryConvertToHiragana(unrecognisedCharacterPolicy, stringBuilderPool: null, out value);

	/// <summary>
	/// Tries to convert a romaji string to hiragana.
	/// </summary>
	/// <param name="this">Romaji string to be converted to Hiragana.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="stringBuilderPool">String builder pool that is useful when many strings are converted in a loop.</param>
	/// <param name="value">Hiragana string after conversion.</param>
	public static bool TryConvertToHiragana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, ObjectPool<StringBuilder>? stringBuilderPool, out string value)
	{
		var result = new StringTextContainer(@this)
			.ConvertToHiragana(unrecognisedCharacterPolicy, stringBuilderPool);

		value = result.Value;

		if (unrecognisedCharacterPolicy == UnrecognisedCharacterPolicy.Append)
			return result.ErrorMessage == null && value != @this;

		return result.ErrorMessage == null;
	}
}
