﻿namespace MyNihongo.KanaConverter;

internal static class ToRomajiTextContainerEx
{
	public static ConversionResult ConvertToRomaji(this ITextContainer @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, ObjectPool<StringBuilder>? stringBuilderPool)
	{
		if (@this.IsEmpty)
			return ConversionResult.FromValue(string.Empty);

		var capacity = @this.Length * 2;
		var stringBuilder = stringBuilderPool?.Get() ?? new StringBuilder(capacity);
		stringBuilder.Capacity = capacity;

		var isSokuon = false;

		try
		{
			for (var i = 0; i < @this.Length; i++)
			{
				string? romaji;
				Youon? youon;

				switch (@this[i])
				{
					// basic
					case 'あ' or 'ア':
						romaji = "a";
						goto Romaji;
					case 'い' or 'イ':
						romaji = "i";
						goto Romaji;
					case 'う' or 'ウ':
						romaji = "u";
						goto Romaji;
					case 'え' or 'エ':
						romaji = "e";
						goto Romaji;
					case 'お' or 'オ':
						romaji = "o";
						goto Romaji;
					case 'ん' or 'ン':
						romaji = "n";
						goto Romaji;
					// basic dakuten
					case 'ゔ' or 'ヴ':
						romaji = "vu";
						goto Romaji;
					// k
					case 'か' or 'カ':
						romaji = "ka";
						goto Romaji;
					case 'き' or 'キ':
						romaji = "ki";
						goto Romaji;
					case 'く' or 'ク':
						romaji = "ku";
						goto Romaji;
					case 'け' or 'ケ':
						romaji = "ke";
						goto Romaji;
					case 'こ' or 'コ':
						romaji = "ko";
						goto Romaji;
					// g
					case 'が' or 'ガ':
						romaji = "ga";
						goto Romaji;
					case 'ぎ' or 'ギ':
						romaji = "gi";
						goto Romaji;
					case 'ぐ' or 'グ':
						romaji = "gu";
						goto Romaji;
					case 'げ' or 'ゲ':
						romaji = "ge";
						goto Romaji;
					case 'ご' or 'ゴ':
						romaji = "go";
						goto Romaji;
					// s
					case 'さ' or 'サ':
						romaji = "sa";
						goto Romaji;
					case 'し' or 'シ':
						romaji = "shi";
						goto Romaji;
					case 'す' or 'ス':
						romaji = "su";
						goto Romaji;
					case 'せ' or 'セ':
						romaji = "se";
						goto Romaji;
					case 'そ' or 'ソ':
						romaji = "so";
						goto Romaji;
					// z
					case 'ざ' or 'ザ':
						romaji = "za";
						goto Romaji;
					case 'じ' or 'ジ':
						romaji = "ji";
						goto Romaji;
					case 'ず' or 'ズ':
						romaji = "zu";
						goto Romaji;
					case 'ぜ' or 'ゼ':
						romaji = "ze";
						goto Romaji;
					case 'ぞ' or 'ゾ':
						romaji = "zo";
						goto Romaji;
					// t
					case 'た' or 'タ':
						romaji = "ta";
						goto Romaji;
					case 'ち' or 'チ':
						romaji = "chi";
						goto Romaji;
					case 'つ' or 'ツ':
						romaji = "tsu";
						goto Romaji;
					case 'て' or 'テ':
						romaji = "te";
						goto Romaji;
					case 'と' or 'ト':
						romaji = "to";
						goto Romaji;
					// d
					case 'だ' or 'ダ':
						romaji = "da";
						goto Romaji;
					case 'ぢ' or 'ヂ':
						romaji = "ji";
						goto Romaji;
					case 'づ' or 'ヅ':
						romaji = "zu";
						goto Romaji;
					case 'で' or 'デ':
						romaji = "de";
						goto Romaji;
					case 'ど' or 'ド':
						romaji = "do";
						goto Romaji;
					// n
					case 'な' or 'ナ':
						romaji = "na";
						goto Romaji;
					case 'に' or 'ニ':
						romaji = "ni";
						goto Romaji;
					case 'ぬ' or 'ヌ':
						romaji = "nu";
						goto Romaji;
					case 'ね' or 'ネ':
						romaji = "ne";
						goto Romaji;
					case 'の' or 'ノ':
						romaji = "no";
						goto Romaji;
					// h
					case 'は' or 'ハ':
						romaji = "ha";
						goto Romaji;
					case 'ひ' or 'ヒ':
						romaji = "hi";
						goto Romaji;
					case 'ふ' or 'フ':
						romaji = "fu";
						goto Romaji;
					case 'へ' or 'ヘ':
						romaji = "he";
						goto Romaji;
					case 'ほ' or 'ホ':
						romaji = "ho";
						goto Romaji;
					// b
					case 'ば' or 'バ':
						romaji = "ba";
						goto Romaji;
					case 'び' or 'ビ':
						romaji = "bi";
						goto Romaji;
					case 'ぶ' or 'ブ':
						romaji = "bu";
						goto Romaji;
					case 'べ' or 'ベ':
						romaji = "be";
						goto Romaji;
					case 'ぼ' or 'ボ':
						romaji = "bo";
						goto Romaji;
					// p
					case 'ぱ' or 'パ':
						romaji = "pa";
						goto Romaji;
					case 'ぴ' or 'ピ':
						romaji = "pi";
						goto Romaji;
					case 'ぷ' or 'プ':
						romaji = "pu";
						goto Romaji;
					case 'ぺ' or 'ペ':
						romaji = "pe";
						goto Romaji;
					case 'ぽ' or 'ポ':
						romaji = "po";
						goto Romaji;
					// m
					case 'ま' or 'マ':
						romaji = "ma";
						goto Romaji;
					case 'み' or 'ミ':
						romaji = "mi";
						goto Romaji;
					case 'む' or 'ム':
						romaji = "mu";
						goto Romaji;
					case 'め' or 'メ':
						romaji = "me";
						goto Romaji;
					case 'も' or 'モ':
						romaji = "mo";
						goto Romaji;
					// y
					case 'や' or 'ヤ':
						romaji = "ya";
						goto Romaji;
					case 'ゆ' or 'ユ':
						romaji = "yu";
						goto Romaji;
					case 'よ' or 'ヨ':
						romaji = "yo";
						goto Romaji;
					// r
					case 'ら' or 'ラ':
						romaji = "ra";
						goto Romaji;
					case 'り' or 'リ':
						romaji = "ri";
						goto Romaji;
					case 'る' or 'ル':
						romaji = "ru";
						goto Romaji;
					case 'れ' or 'レ':
						romaji = "re";
						goto Romaji;
					case 'ろ' or 'ロ':
						romaji = "ro";
						goto Romaji;
					// w
					case 'わ' or 'ワ':
						romaji = "wa";
						goto Romaji;
					case 'を' or 'ヲ':
						romaji = "wo";
						goto Romaji;
					// special (拗音)
					case 'ゃ' or 'ャ':
						youon = Youon.Ya;
						goto Youon;
					case 'ゅ' or 'ュ':
						youon = Youon.Yu;
						goto Youon;
					case 'ょ' or 'ョ':
						youon = Youon.Yo;
						goto Youon;
					case 'ぁ' or 'ァ':
						youon = Youon.A;
						goto YouonSpecial;
					case 'ぃ' or 'ィ':
						youon = Youon.I;
						goto YouonSpecial;
					case 'ぅ' or 'ゥ':
						youon = Youon.U;
						goto YouonSpecial;
					case 'ぇ' or 'ェ':
						youon = Youon.E;
						goto YouonSpecial;
					case 'ぉ' or 'ォ':
						youon = Youon.O;
						goto YouonSpecial;
					case 'ゎ' or 'ヮ':
						youon = Youon.Wa;
						goto YouonSpecial;
					// special (促音)
					case 'っ' or 'ッ':
						isSokuon = true;
						continue;
					// special (長音符)
					case 'ー':
						var vowelIndex = stringBuilder.Length - 1;
						if (vowelIndex < 0)
							return ConversionResult.FromError("Chōonpu (長音符) cannot be the first character");

						char vowelChar;
						switch (stringBuilder[vowelIndex])
						{
							case 'a':
							case 'i':
							case 'u':
							case 'e':
							case 'o':
								vowelChar = stringBuilder[vowelIndex];
								break;
							default:
								return ConversionResult.FromError($"Chōonpu (長音符) cannot extend a consonant in \"{@this}\"");
						}

						stringBuilder.Append(vowelChar);
						continue;
					// skip
					case '・': continue;
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

				Romaji:
				if (isSokuon)
				{
					isSokuon = false;
					char sokuonChar;

					switch (romaji[0])
					{
						case 'c':
							sokuonChar = 't';
							break;
						case 'a':
						case 'i':
						case 'u':
						case 'e':
						case 'o':
							return ConversionResult.FromError($"Sokuon (促音) cannot precede a letter \"{romaji[0]}\"");
						default:
							sokuonChar = romaji[0];
							break;
					}

					stringBuilder.Append(sokuonChar);
				}

				stringBuilder.Append(romaji);
				continue;

				Youon:
				var consonantIndex = stringBuilder.Length - 2;
				if (consonantIndex < 0)
					return ConversionResult.FromError($"Yōon (拗音) \"{youon}\" cannot be the first character");

				var youonChar = youon.Value.GetChar();
				switch (stringBuilder[consonantIndex])
				{
					case 'k':
					case 'g' or 'n' or 'b' or 'p' or 'm' or 'r' or 't' or 'd' or 'f' or 'v':
					{
						stringBuilder[consonantIndex + 1] = 'y';
						stringBuilder.Append(youonChar);
						continue;
					}
					case 's':
					case 'j':
					{
						stringBuilder.Set(consonantIndex + 1, youonChar);
						continue;
					}
					case 'h':
					{
						var checkIndex = consonantIndex - 1;
						if (checkIndex >= 0 && stringBuilder[checkIndex] is 'c' or 's')
							goto case 's';

						goto case 'k';
					}
					default:
						return ConversionResult.FromError($"Unrecognised yōon (拗音) combination in \"{@this}\"");
				}

				YouonSpecial:
				var youonSpecialIndex = stringBuilder.Length - 1;
				if (youonSpecialIndex < 0)
					return ConversionResult.FromError($"Yōon (拗音) \"{youon}\" cannot be the first character");

				char? youonVowelChar;
				switch (stringBuilder[youonSpecialIndex])
				{
					case 'i':
					{
						if (@this[i - 1] is 'い' or 'イ')
						{
							youonVowelChar = 'y';
							goto VowelYouon;
						}

						goto Youon;
					}
					case 'u':
					{
						if (@this[i - 1] is 'う' or 'ウ')
						{
							youonVowelChar = 'w';
							goto VowelYouon;
						}

						goto case 'a';
					}
					case 'a':
					case 'e' or 'o':
					{
						stringBuilder.Set(youonSpecialIndex, youon.Value.GetChar());
						continue;
					}
				}

				return ConversionResult.FromError($"Special yōon (拗音) cannot follow \"{stringBuilder[youonSpecialIndex]}\"");

				VowelYouon:
				stringBuilder[youonSpecialIndex] = youonVowelChar.Value;
				stringBuilder.Append(youon.Value.GetChar());
			}

			return ConversionResult.FromValue(stringBuilder.ToString());
		}
		finally
		{
			stringBuilderPool?.Return(stringBuilder);
		}
	}
}
