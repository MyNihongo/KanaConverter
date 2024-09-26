namespace MyNihongo.KanaConverter;

public static partial class StringEx
{
	/// <summary>
	/// Converts a kana (hiragana or katakana) string to hiragana.
	/// </summary>
	/// <param name="this">Kana string to be converted to hiragana.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="stringBuilderPool">String builder pool that is useful when many strings are converted in a loop.</param>
	/// <exception cref="InvalidCharacterException"></exception>
	public static string KanaToHiragana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy = default, ObjectPool<StringBuilder>? stringBuilderPool = null)
	{
		var result = @this.ConvertKanaToHiragana(unrecognisedCharacterPolicy, stringBuilderPool);

		if (result.ErrorMessage != null)
			throw new InvalidCharacterException(result.ErrorMessage);

		return result.Value;
	}

	/// <summary>
	/// Tries to convert a kana (hiragana or katakana) string to hiragana.
	/// </summary>
	/// <param name="this">Kana string to be converted to hiragana.</param>
	/// <param name="value">Romaji string after conversion.</param>
	public static bool TryConvertKanaToHiragana(this string @this, out string value) =>
		@this.TryConvertKanaToHiragana(unrecognisedCharacterPolicy: default, stringBuilderPool: null, out value);

	/// <summary>
	/// Tries to convert a kana (hiragana or katakana) string to hiragana.
	/// </summary>
	/// <param name="this">Kana string to be converted to hiragana.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="value">Romaji string after conversion.</param>
	public static bool TryConvertKanaToHiragana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, out string value) =>
		@this.TryConvertKanaToHiragana(unrecognisedCharacterPolicy, stringBuilderPool: null, out value);

	/// <summary>
	/// Tries to convert a kana (hiragana or katakana) string to hiragana.
	/// </summary>
	/// <param name="this">Kana string to be converted to hiragana.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="stringBuilderPool">String builder pool that is useful when many strings are converted in a loop.</param>
	/// <param name="value">Romaji string after conversion.</param>
	public static bool TryConvertKanaToHiragana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, ObjectPool<StringBuilder>? stringBuilderPool, out string value)
	{
		var result = @this.ConvertKanaToHiragana(unrecognisedCharacterPolicy, stringBuilderPool);
		value = result.Value;

		if (unrecognisedCharacterPolicy == UnrecognisedCharacterPolicy.Append)
			return result.ErrorMessage == null && value != @this;

		return result.ErrorMessage == null;
	}

	private static ConversionResult ConvertKanaToHiragana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, ObjectPool<StringBuilder>? stringBuilderPool)
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
					case 'ア':
						stringBuilder.Append('あ');
						continue;
					case 'イ':
						stringBuilder.Append('い');
						continue;
					case 'ウ':
						stringBuilder.Append('う');
						continue;
					case 'エ':
						stringBuilder.Append('え');
						continue;
					case 'オ':
						stringBuilder.Append('お');
						continue;
					case 'ン':
						stringBuilder.Append('ん');
						continue;
					// basic dakuten
					case 'ヴ':
						stringBuilder.Append('ゔ');
						continue;
					// k
					case 'カ':
						stringBuilder.Append('か');
						continue;
					case 'キ':
						stringBuilder.Append('き');
						continue;
					case 'ク':
						stringBuilder.Append('く');
						continue;
					case 'ケ':
						stringBuilder.Append('け');
						continue;
					case 'コ':
						stringBuilder.Append('こ');
						continue;
					// g
					case 'ガ':
						stringBuilder.Append('が');
						continue;
					case 'ギ':
						stringBuilder.Append('ぎ');
						continue;
					case 'グ':
						stringBuilder.Append('ぐ');
						continue;
					case 'ゲ':
						stringBuilder.Append('げ');
						continue;
					case 'ゴ':
						stringBuilder.Append('ご');
						continue;
					// s
					case 'サ':
						stringBuilder.Append('さ');
						continue;
					case 'シ':
						stringBuilder.Append('し');
						continue;
					case 'ス':
						stringBuilder.Append('す');
						continue;
					case 'セ':
						stringBuilder.Append('せ');
						continue;
					case 'ソ':
						stringBuilder.Append('そ');
						continue;
					// z
					case 'ザ':
						stringBuilder.Append('ざ');
						continue;
					case 'ジ':
						stringBuilder.Append('じ');
						continue;
					case 'ズ':
						stringBuilder.Append('ず');
						continue;
					case 'ゼ':
						stringBuilder.Append('ぜ');
						continue;
					case 'ゾ':
						stringBuilder.Append('ぞ');
						continue;
					// t
					case 'タ':
						stringBuilder.Append('た');
						continue;
					case 'チ':
						stringBuilder.Append('ち');
						continue;
					case 'ツ':
						stringBuilder.Append('つ');
						continue;
					case 'テ':
						stringBuilder.Append('て');
						continue;
					case 'ト':
						stringBuilder.Append('と');
						continue;
					// d
					case 'ダ':
						stringBuilder.Append('だ');
						continue;
					case 'ヂ':
						stringBuilder.Append('ぢ');
						continue;
					case 'ヅ':
						stringBuilder.Append('づ');
						continue;
					case 'デ':
						stringBuilder.Append('で');
						continue;
					case 'ド':
						stringBuilder.Append('ど');
						continue;
					// n
					case 'ナ':
						stringBuilder.Append('な');
						continue;
					case 'ニ':
						stringBuilder.Append('に');
						continue;
					case 'ヌ':
						stringBuilder.Append('ぬ');
						continue;
					case 'ネ':
						stringBuilder.Append('ね');
						continue;
					case 'ノ':
						stringBuilder.Append('の');
						continue;
					// h
					case 'ハ':
						stringBuilder.Append('は');
						continue;
					case 'ヒ':
						stringBuilder.Append('ひ');
						continue;
					case 'フ':
						stringBuilder.Append('ふ');
						continue;
					case 'ヘ':
						stringBuilder.Append('へ');
						continue;
					case 'ホ':
						stringBuilder.Append('ほ');
						continue;
					// b
					case 'バ':
						stringBuilder.Append('ば');
						continue;
					case 'ビ':
						stringBuilder.Append('び');
						continue;
					case 'ブ':
						stringBuilder.Append('ぶ');
						continue;
					case 'ベ':
						stringBuilder.Append('べ');
						continue;
					case 'ボ':
						stringBuilder.Append('ぼ');
						continue;
					// p
					case 'パ':
						stringBuilder.Append('ぱ');
						continue;
					case 'ピ':
						stringBuilder.Append('ぴ');
						continue;
					case 'プ':
						stringBuilder.Append('ぷ');
						continue;
					case 'ペ':
						stringBuilder.Append('ぺ');
						continue;
					case 'ポ':
						stringBuilder.Append('ぽ');
						continue;
					// m
					case 'マ':
						stringBuilder.Append('ま');
						continue;
					case 'ミ':
						stringBuilder.Append('み');
						continue;
					case 'ム':
						stringBuilder.Append('む');
						continue;
					case 'メ':
						stringBuilder.Append('め');
						continue;
					case 'モ':
						stringBuilder.Append('も');
						continue;
					// y
					case 'ヤ':
						stringBuilder.Append('や');
						continue;
					case 'ユ':
						stringBuilder.Append('ゆ');
						continue;
					case 'ヨ':
						stringBuilder.Append('よ');
						continue;
					// r
					case 'ラ':
						stringBuilder.Append('ら');
						continue;
					case 'リ':
						stringBuilder.Append('り');
						continue;
					case 'ル':
						stringBuilder.Append('る');
						continue;
					case 'レ':
						stringBuilder.Append('れ');
						continue;
					case 'ロ':
						stringBuilder.Append('ろ');
						continue;
					// w
					case 'ワ':
						stringBuilder.Append('わ');
						continue;
					case 'ヲ':
						stringBuilder.Append('を');
						continue;
					// special (拗音)
					case 'ャ':
						stringBuilder.Append('ゃ');
						continue;
					case 'ュ':
						stringBuilder.Append('ゅ');
						continue;
					case 'ョ':
						stringBuilder.Append('ょ');
						continue;
					case 'ァ':
						stringBuilder.Append('ぁ');
						continue;
					case 'ィ':
						stringBuilder.Append('ぃ');
						continue;
					case 'ゥ':
						stringBuilder.Append('ぅ');
						continue;
					case 'ェ':
						stringBuilder.Append('ぇ');
						continue;
					case 'ォ':
						stringBuilder.Append('ぉ');
						continue;
					case 'ヮ':
						stringBuilder.Append('ゎ');
						continue;
					// special (促音)
					case 'ッ':
						stringBuilder.Append('っ');
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
