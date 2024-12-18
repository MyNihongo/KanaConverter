﻿namespace MyNihongo.KanaConverter;

internal static class KanaToKatakanaTextContainerEx
{
	public static ConversionResult ConvertKanaToKatakana(this ITextContainer @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, ObjectPool<StringBuilder>? stringBuilderPool)
	{
		if (@this.IsEmpty)
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
					case 'げ':
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
					case 'た':
						stringBuilder.Append('タ');
						continue;
					case 'ち':
						stringBuilder.Append('チ');
						continue;
					case 'つ':
						stringBuilder.Append('ツ');
						continue;
					case 'て':
						stringBuilder.Append('テ');
						continue;
					case 'と':
						stringBuilder.Append('ト');
						continue;
					// d
					case 'だ':
						stringBuilder.Append('ダ');
						continue;
					case 'ぢ':
						stringBuilder.Append('ヂ');
						continue;
					case 'づ':
						stringBuilder.Append('ヅ');
						continue;
					case 'で':
						stringBuilder.Append('デ');
						continue;
					case 'ど':
						stringBuilder.Append('ド');
						continue;
					// n
					case 'な':
						stringBuilder.Append('ナ');
						continue;
					case 'に':
						stringBuilder.Append('ニ');
						continue;
					case 'ぬ':
						stringBuilder.Append('ヌ');
						continue;
					case 'ね':
						stringBuilder.Append('ネ');
						continue;
					case 'の':
						stringBuilder.Append('ノ');
						continue;
					// h
					case 'は':
						stringBuilder.Append('ハ');
						continue;
					case 'ひ':
						stringBuilder.Append('ヒ');
						continue;
					case 'ふ':
						stringBuilder.Append('フ');
						continue;
					case 'へ':
						stringBuilder.Append('ヘ');
						continue;
					case 'ほ':
						stringBuilder.Append('ホ');
						continue;
					// b
					case 'ば':
						stringBuilder.Append('バ');
						continue;
					case 'び':
						stringBuilder.Append('ビ');
						continue;
					case 'ぶ':
						stringBuilder.Append('ブ');
						continue;
					case 'べ':
						stringBuilder.Append('ベ');
						continue;
					case 'ぼ':
						stringBuilder.Append('ボ');
						continue;
					// p
					case 'ぱ':
						stringBuilder.Append('パ');
						continue;
					case 'ぴ':
						stringBuilder.Append('ピ');
						continue;
					case 'ぷ':
						stringBuilder.Append('プ');
						continue;
					case 'ぺ':
						stringBuilder.Append('ペ');
						continue;
					case 'ぽ':
						stringBuilder.Append('ポ');
						continue;
					// m
					case 'ま':
						stringBuilder.Append('マ');
						continue;
					case 'み':
						stringBuilder.Append('ミ');
						continue;
					case 'む':
						stringBuilder.Append('ム');
						continue;
					case 'め':
						stringBuilder.Append('メ');
						continue;
					case 'も':
						stringBuilder.Append('モ');
						continue;
					// y
					case 'や':
						stringBuilder.Append('ヤ');
						continue;
					case 'ゆ':
						stringBuilder.Append('ユ');
						continue;
					case 'よ':
						stringBuilder.Append('ヨ');
						continue;
					// r
					case 'ら':
						stringBuilder.Append('ラ');
						continue;
					case 'り':
						stringBuilder.Append('リ');
						continue;
					case 'る':
						stringBuilder.Append('ル');
						continue;
					case 'れ':
						stringBuilder.Append('レ');
						continue;
					case 'ろ':
						stringBuilder.Append('ロ');
						continue;
					// w
					case 'わ':
						stringBuilder.Append('ワ');
						continue;
					case 'を':
						stringBuilder.Append('ヲ');
						continue;
					// special (拗音)
					case 'ゃ':
						stringBuilder.Append('ャ');
						continue;
					case 'ゅ':
						stringBuilder.Append('ュ');
						continue;
					case 'ょ':
						stringBuilder.Append('ョ');
						continue;
					case 'ぁ':
						stringBuilder.Append('ァ');
						continue;
					case 'ぃ':
						stringBuilder.Append('ィ');
						continue;
					case 'ぅ':
						stringBuilder.Append('ゥ');
						continue;
					case 'ぇ':
						stringBuilder.Append('ェ');
						continue;
					case 'ぉ':
						stringBuilder.Append('ォ');
						continue;
					case 'ゎ':
						stringBuilder.Append('ヮ');
						continue;
					// special (促音)
					case 'っ':
						stringBuilder.Append('ッ');
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
