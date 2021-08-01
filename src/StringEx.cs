using System;
using System.Text;
using MyNihongo.KanaConverter.Exceptions;

namespace MyNihongo.KanaConverter
{
	public static class StringEx
	{
		/// <summary>
		/// Converts a kana (hiragana or katakana) string to romaji
		/// </summary>
		/// <param name="this">Kana string to be converted to romaji</param>
		/// <param name="stringBuilderProvider">Custom function to create a <see cref="StringBuilder"/>. Useful for Microsoft.Extensions.ObjectPool and ObjectPool&lt;StringBuilder&gt;.Get()</param>
		/// <exception cref="InvalidKanaException"></exception>
		public static string ToRomaji(this string @this, Func<StringBuilder>? stringBuilderProvider = null)
		{
			if (string.IsNullOrEmpty(@this))
				return string.Empty;

			StringBuilder stringBuilder;
			{
				var capacity = @this.Length * 2;
				stringBuilder = stringBuilderProvider?.Invoke() ?? new StringBuilder(capacity);
				stringBuilder.Capacity = capacity;
			}

			var isSokuon = false;

			for (var i = 0; i < @this.Length; i++)
			{
				string? romaji;
				Youon? youon = null;
				YouonSpecial? youonSpecial;

				switch (@this[i])
				{
					// basic
					case 'あ' or 'ア': romaji = "a"; goto Romaji;
					case 'い' or 'イ': romaji = "i"; goto Romaji;
					case 'う' or 'ウ': romaji = "u"; goto Romaji;
					case 'え' or 'エ': romaji = "e"; goto Romaji;
					case 'お' or 'オ': romaji = "o"; goto Romaji;
					case 'ん' or 'ン': romaji = "n"; goto Romaji;
					// k
					case 'か' or 'カ': romaji = "ka"; goto Romaji;
					case 'き' or 'キ': romaji = "ki"; goto Romaji;
					case 'く' or 'ク': romaji = "ku"; goto Romaji;
					case 'け' or 'ケ': romaji = "ke"; goto Romaji;
					case 'こ' or 'コ': romaji = "ko"; goto Romaji;
					// g
					case 'が' or 'ガ': romaji = "ga"; goto Romaji;
					case 'ぎ' or 'ギ': romaji = "gi"; goto Romaji;
					case 'ぐ' or 'グ': romaji = "gu"; goto Romaji;
					case 'げ' or 'ゲ': romaji = "ge"; goto Romaji;
					case 'ご' or 'ゴ': romaji = "go"; goto Romaji;
					// s
					case 'さ' or 'サ': romaji = "sa"; goto Romaji;
					case 'し' or 'シ': romaji = "shi"; goto Romaji;
					case 'す' or 'ス': romaji = "su"; goto Romaji;
					case 'せ' or 'セ': romaji = "se"; goto Romaji;
					case 'そ' or 'ソ': romaji = "so"; goto Romaji;
					// z
					case 'ざ' or 'ザ': romaji = "za"; goto Romaji;
					case 'じ' or 'ジ': romaji = "ji"; goto Romaji;
					case 'ず' or 'ズ': romaji = "zu"; goto Romaji;
					case 'ぜ' or 'ゼ': romaji = "ze"; goto Romaji;
					case 'ぞ' or 'ゾ': romaji = "zo"; goto Romaji;
					// t
					case 'た' or 'タ': romaji = "ta"; goto Romaji;
					case 'ち' or 'チ': romaji = "chi"; goto Romaji;
					case 'つ' or 'ツ': romaji = "tsu"; goto Romaji;
					case 'て' or 'テ': romaji = "te"; goto Romaji;
					case 'と' or 'ト': romaji = "to"; goto Romaji;
					// d
					case 'だ' or 'ダ': romaji = "da"; goto Romaji;
					case 'ぢ' or 'ヂ': romaji = "ji"; goto Romaji;
					case 'づ' or 'ヅ': romaji = "zu"; goto Romaji;
					case 'で' or 'デ': romaji = "de"; goto Romaji;
					case 'ど' or 'ド': romaji = "do"; goto Romaji;
					// n
					case 'な' or 'ナ': romaji = "na"; goto Romaji;
					case 'に' or 'ニ': romaji = "ni"; goto Romaji;
					case 'ぬ' or 'ヌ': romaji = "nu"; goto Romaji;
					case 'ね' or 'ネ': romaji = "ne"; goto Romaji;
					case 'の' or 'ノ': romaji = "no"; goto Romaji;
					// h
					case 'は' or 'ハ': romaji = "ha"; goto Romaji;
					case 'ひ' or 'ヒ': romaji = "hi"; goto Romaji;
					case 'ふ' or 'フ': romaji = "fu"; goto Romaji;
					case 'へ' or 'ヘ': romaji = "he"; goto Romaji;
					case 'ほ' or 'ホ': romaji = "ho"; goto Romaji;
					// b
					case 'ば' or 'バ': romaji = "ba"; goto Romaji;
					case 'び' or 'ビ': romaji = "bi"; goto Romaji;
					case 'ぶ' or 'ブ': romaji = "bu"; goto Romaji;
					case 'べ' or 'ベ': romaji = "be"; goto Romaji;
					case 'ぼ' or 'ボ': romaji = "bo"; goto Romaji;
					// p
					case 'ぱ' or 'パ': romaji = "pa"; goto Romaji;
					case 'ぴ' or 'ピ': romaji = "pi"; goto Romaji;
					case 'ぷ' or 'プ': romaji = "pu"; goto Romaji;
					case 'ぺ' or 'ペ': romaji = "pe"; goto Romaji;
					case 'ぽ' or 'ポ': romaji = "po"; goto Romaji;
					// m
					case 'ま' or 'マ': romaji = "ma"; goto Romaji;
					case 'み' or 'ミ': romaji = "mi"; goto Romaji;
					case 'む' or 'ム': romaji = "mu"; goto Romaji;
					case 'め' or 'メ': romaji = "me"; goto Romaji;
					case 'も' or 'モ': romaji = "mo"; goto Romaji;
					// y
					case 'や' or 'ヤ': romaji = "ya"; goto Romaji;
					case 'ゆ' or 'ユ': romaji = "yu"; goto Romaji;
					case 'よ' or 'ヨ': romaji = "yo"; goto Romaji;
					// r
					case 'ら' or 'ラ': romaji = "ra"; goto Romaji;
					case 'り' or 'リ': romaji = "ri"; goto Romaji;
					case 'る' or 'ル': romaji = "ru"; goto Romaji;
					case 'れ' or 'レ': romaji = "re"; goto Romaji;
					case 'ろ' or 'ロ': romaji = "ro"; goto Romaji;
					// w
					case 'わ' or 'ワ': romaji = "wa"; goto Romaji;
					case 'を' or 'ヲ': romaji = "wo"; goto Romaji;
					// special (拗音)
					case 'ゃ' or 'ャ': youon = Youon.Ya; goto Youon;
					case 'ゅ' or 'ュ': youon = Youon.Yu; goto Youon;
					case 'ょ' or 'ョ': youon = Youon.Yo; goto Youon;
					case 'ぃ' or 'ィ': youonSpecial = YouonSpecial.I; goto YouonSpecial;
					case 'ぇ' or 'ェ': youonSpecial = YouonSpecial.E; goto YouonSpecial;
					// special (促音)
					case 'っ' or 'ッ': isSokuon = true; continue;
					// special (長音符)
					case 'ー':
						var vowelIndex = stringBuilder.Length - 1;
						if (vowelIndex < 0)
							throw new InvalidKanaException("Chōonpu (長音符) cannot be the first character");

						var vowelChar = stringBuilder[vowelIndex] switch
						{
							'a' or 'i' or 'u' or 'e' or 'o' => stringBuilder[vowelIndex],
							_ => throw new InvalidKanaException($"Chōonpu (長音符) cannot extend a consonant in \"{@this}\"")
						};

						stringBuilder.Append(vowelChar);
						continue;
					default:
						throw new InvalidKanaException(@this[i], @this);
				}

				Romaji:
				if (isSokuon)
				{
					isSokuon = false;

					var sokuonChar = romaji[0] switch
					{
						'c' => 't',
						'a' or 'i' or 'u' or 'e' or 'o' or 'w' => throw new InvalidKanaException($"Sokuon (促音) cannot precede a letter \"{romaji[0]}\""),
						_ => romaji[0]
					};

					stringBuilder.Append(sokuonChar);
				}

				stringBuilder.Append(romaji);
				continue;

				Youon:
				var consonantIndex = stringBuilder.Length - 2;
				if (consonantIndex < 0)
					throw new InvalidKanaException($"Yōon (拗音) \"{youon}\" cannot be the first character");

				var youonChar = youon.Value.GetChar();
				switch (stringBuilder[consonantIndex])
				{
					case 'k':
					case 'g' or 'n' or 'b' or 'p' or 'm' or 'r':
						{
							stringBuilder[consonantIndex + 1] = 'y';
							stringBuilder.Append(youonChar);
							continue;
						}
					case 's':
					case 'j':
						{
							stringBuilder[consonantIndex + 1] = youonChar;
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
						throw new InvalidKanaException($"Unrecognised yōon (拗音) combination in \"{@this}\"");
				}

				YouonSpecial:
				var youonSpecialIndex = stringBuilder.Length - 1;
				if (youonSpecialIndex < 0)
					throw new InvalidKanaException($"Yōon (拗音) \"{youon}\" cannot be the first character");

				switch (stringBuilder[youonSpecialIndex])
				{
					case 'i':
						youon = youonSpecial.Value.ToYouon();
						goto Youon;
					case 'u':
						{
							if (@this[i - 1] is 'う' or 'ウ')
							{
								var specialYouonChar = youonSpecial.Value.GetChar();
								stringBuilder[youonSpecialIndex] = 'w';
								stringBuilder.Append(specialYouonChar);
								continue;
							}

							goto case 'e';
						}
					case 'e':
						{
							var specialYouonChar = youonSpecial.Value.GetChar();
							stringBuilder[youonSpecialIndex] = specialYouonChar;
							continue;
						}
				}

				throw new InvalidKanaException($"Special yōon (拗音) cannot follow \"{stringBuilder[youonSpecialIndex]}\"");
			}

			return stringBuilder.ToString();
		}
	}
}
