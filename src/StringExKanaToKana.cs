namespace MyNihongo.KanaConverter;

public static partial class StringEx
{
	/// <summary>
	/// Convert a kana (hiragana or katakana) string to the opposite kana. Hiragana to katakana / Katakana to hiragana.
	/// </summary>
	/// <param name="this">Kana string to be converted to the opposite kana.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="stringBuilderPool">String builder pool that is useful when many strings are converted in a loop.</param>
	/// <exception cref="InvalidKanaException"></exception>
	public static string ToOppositeKana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy = default, ObjectPool<StringBuilder>? stringBuilderPool = null)
	{
		var result = @this.ConvertKanaToKana(unrecognisedCharacterPolicy, stringBuilderPool);

		if (result.ErrorMessage != null)
			throw new InvalidKanaException(result.ErrorMessage);

		return result.Value;
	}

	/// <summary>
	/// Tries to convert a kana (hiragana or katakana) string to the opposite kana. Hiragana to katakana / Katakana to hiragana.
	/// </summary>
	/// <param name="this">Kana string to be converted to the opposite kana.</param>
	/// <param name="value">Romaji string after conversion.</param>
	public static bool TryConvertKanaToKana(this string @this, out string value) =>
		@this.TryConvertKanaToKana(unrecognisedCharacterPolicy: default, stringBuilderPool: null, out value);

	/// <summary>
	/// Tries to convert a kana (hiragana or katakana) string to the opposite kana. Hiragana to katakana / Katakana to hiragana.
	/// </summary>
	/// <param name="this">Kana string to be converted to the opposite kana.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="value">Romaji string after conversion.</param>
	public static bool TryConvertKanaToKana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, out string value) =>
		@this.TryConvertKanaToKana(unrecognisedCharacterPolicy, stringBuilderPool: null, out value);

	/// <summary>
	/// Tries to convert a kana (hiragana or katakana) string to the opposite kana. Hiragana to katakana / Katakana to hiragana.
	/// </summary>
	/// <param name="this">Kana string to be converted to the opposite kana.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="stringBuilderPool">String builder pool that is useful when many strings are converted in a loop.</param>
	/// <param name="value">Romaji string after conversion.</param>
	public static bool TryConvertKanaToKana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, ObjectPool<StringBuilder>? stringBuilderPool, out string value)
	{
		var result = @this.ConvertKanaToKana(unrecognisedCharacterPolicy, stringBuilderPool);
		value = result.Value;

		if (unrecognisedCharacterPolicy == UnrecognisedCharacterPolicy.Append)
			return result.ErrorMessage == null && value != @this;

		return result.ErrorMessage == null;
	}

	private static ConversionResult ConvertKanaToKana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, ObjectPool<StringBuilder>? stringBuilderPool)
	{
	}
}
