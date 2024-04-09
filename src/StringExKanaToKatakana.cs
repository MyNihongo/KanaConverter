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
		if (string.IsNullOrEmpty(@this))
			return ConversionResult.FromValue(string.Empty);
		
		var capacity = @this.Length;
		var stringBuilder = stringBuilderPool?.Get() ?? new StringBuilder(capacity);
		stringBuilder.Capacity = capacity;

		try
		{
			for (var i = 0; i < @this.Length; i++)
			{
				switch (@this[i])
				{
					// basic
					case 'あ':
						stringBuilder.Append('ア');
						continue;
					case 'い':
						stringBuilder.Append('イ');
						continue;
					case 'う':
						stringBuilder.Append('ウ');
						continue;
					case 'え':
						stringBuilder.Append('エ');
						continue;
					case 'お':
						stringBuilder.Append('オ');
						continue;
					case 'ん':
						stringBuilder.Append('ン');
						continue;
					// basic dakuten
					case 'ゔ':
						stringBuilder.Append('ヴ');
						continue;
					// k
					case 'か':
						stringBuilder.Append('カ');
						continue;
					case 'き':
						stringBuilder.Append('キ');
						continue;
					case 'く':
						stringBuilder.Append('ク');
						continue;
					case 'け':
						stringBuilder.Append('ケ');
						continue;
					case 'こ':
						stringBuilder.Append('コ');
						continue;
					// g
					case 'が':
						stringBuilder.Append('ガ');
						continue;
					case 'ぎ':
						stringBuilder.Append('ギ');
						continue;
					case 'ぐ':
						stringBuilder.Append('グ');
						continue;
					case 'ゲ':
						stringBuilder.Append('ゲ');
						continue;
					case 'ご':
						stringBuilder.Append('ゴ');
						continue;
					// s
					case 'さ':
						stringBuilder.Append('サ');
						continue;
					case 'し':
						stringBuilder.Append('シ');
						continue;
					case 'す':
						stringBuilder.Append('ス');
						continue;
					case 'せ':
						stringBuilder.Append('セ');
						continue;
					case 'そ':
						stringBuilder.Append('ソ');
						continue;
					// z
					case 'ざ':
						stringBuilder.Append('ザ');
						continue;
					case 'じ':
						stringBuilder.Append('ジ');
						continue;
					case 'ず':
						stringBuilder.Append('ズ');
						continue;
					case 'ぜ':
						stringBuilder.Append('ゼ');
						continue;
					case 'ぞ':
						stringBuilder.Append('ゾ');
						continue;
					// t
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
