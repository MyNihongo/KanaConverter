namespace MyNihongo.KanaConverter;

public static partial class StringEx
{
	/// <summary>
	/// Converts a kana (hiragana or katakana) string to katakana.
	/// </summary>
	/// <param name="this">Kana string to be converted to katakana.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="stringBuilderPool">String builder pool that is useful when many strings are converted in a loop.</param>
	/// <exception cref="InvalidKanaException"></exception>
	public static string KanaToKatakana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy = default, ObjectPool<StringBuilder>? stringBuilderPool = null)
	{
		var result = @this.ConvertKanaToKatakana(unrecognisedCharacterPolicy, stringBuilderPool);

		if (result.ErrorMessage != null)
			throw new InvalidKanaException(result.ErrorMessage);

		return result.Value;
	}

	/// <summary>
	/// Tries to convert a kana (hiragana or katakana) string to katakana.
	/// </summary>
	/// <param name="this">Kana string to be converted to katakana.</param>
	/// <param name="value">Romaji string after conversion.</param>
	public static bool TryConvertKanaToKatakana(this string @this, out string value) =>
		@this.TryConvertKanaToKatakana(unrecognisedCharacterPolicy: default, stringBuilderPool: null, out value);

	/// <summary>
	/// Tries to convert a kana (hiragana or katakana) string to katakana.
	/// </summary>
	/// <param name="this">Kana string to be converted to katakana.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="value">Romaji string after conversion.</param>
	public static bool TryConvertKanaToKatakana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, out string value) =>
		@this.TryConvertKanaToKatakana(unrecognisedCharacterPolicy, stringBuilderPool: null, out value);

	/// <summary>
	/// Tries to convert a kana (hiragana or katakana) string to katakana.
	/// </summary>
	/// <param name="this">Kana string to be converted to katakana.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="stringBuilderPool">String builder pool that is useful when many strings are converted in a loop.</param>
	/// <param name="value">Romaji string after conversion.</param>
	public static bool TryConvertKanaToKatakana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, ObjectPool<StringBuilder>? stringBuilderPool, out string value)
	{
		var result = @this.ConvertKanaToKatakana(unrecognisedCharacterPolicy, stringBuilderPool);
		value = result.Value;

		if (unrecognisedCharacterPolicy == UnrecognisedCharacterPolicy.Append)
			return result.ErrorMessage == null && value != @this;

		return result.ErrorMessage == null;
	}

	private static ConversionResult ConvertKanaToKatakana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, ObjectPool<StringBuilder>? stringBuilderPool)
	{
	}
}
