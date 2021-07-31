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
				string? romaji = null;
				Youon? youon = null;

				switch (@this[i])
				{
					// basic
					case 'あ' or 'ア': romaji = "a"; break;
					case 'い' or 'イ': romaji = "i"; break;
					case 'う' or 'ウ': romaji = "u"; break;
					case 'え' or 'エ': romaji = "e"; break;
					case 'お' or 'オ': romaji = "o"; break;
					case 'ん' or 'ン': romaji = "n"; break;
					// k
					case 'か' or 'カ': romaji = "ka"; break;
					case 'き' or 'キ': romaji = "ki"; break;
					case 'く' or 'ク': romaji = "ku"; break;
					case 'け' or 'ケ': romaji = "ke"; break;
					case 'こ' or 'コ': romaji = "ko"; break;
					// g
					case 'が' or 'ガ': romaji = "ga"; break;
					case 'ぎ' or 'ギ': romaji = "gi"; break;
					case 'ぐ' or 'グ': romaji = "gu"; break;
					case 'げ' or 'ゲ': romaji = "ge"; break;
					case 'ご' or 'ゴ': romaji = "go"; break;
					// s
					case 'さ' or 'サ': romaji = "sa"; break;
					case 'し' or 'シ': romaji = "shi"; break;
					case 'す' or 'ス': romaji = "su"; break;
					case 'せ' or 'セ': romaji = "se"; break;
					case 'そ' or 'ソ': romaji = "so"; break;
					// z
					case 'ざ' or 'ザ': romaji = "za"; break;
					case 'じ' or 'ジ': romaji = "ji"; break;
					case 'ず' or 'ズ': romaji = "zu"; break;
					case 'ぜ' or 'ゼ': romaji = "ze"; break;
					case 'ぞ' or 'ゾ': romaji = "zo"; break;
					// t
					case 'た' or 'タ': romaji = "ta"; break;
					case 'ち' or 'チ': romaji = "chi"; break;
					case 'つ' or 'ツ': romaji = "tsu"; break;
					case 'て' or 'テ': romaji = "te"; break;
					case 'と' or 'ト': romaji = "to"; break;
					// d
					case 'だ' or 'ダ': romaji = "da"; break;
					case 'ぢ' or 'ヂ': romaji = "ji"; break;
					case 'づ' or 'ヅ': romaji = "zu"; break;
					case 'で' or 'デ': romaji = "de"; break;
					case 'ど' or 'ド': romaji = "do"; break;
					// n
					case 'な' or 'ナ': romaji = "na"; break;
					case 'に' or 'ニ': romaji = "ni"; break;
					case 'ぬ' or 'ヌ': romaji = "nu"; break;
					case 'ね' or 'ネ': romaji = "ne"; break;
					case 'の' or 'ノ': romaji = "no"; break;
					// h
					case 'は' or 'ハ': romaji = "ha"; break;
					case 'ひ' or 'ヒ': romaji = "hi"; break;
					case 'ふ' or 'フ': romaji = "fu"; break;
					case 'へ' or 'ヘ': romaji = "he"; break;
					case 'ほ' or 'ホ': romaji = "ho"; break;
					// b
					case 'ば' or 'バ': romaji = "ba"; break;
					case 'び' or 'ビ': romaji = "bi"; break;
					case 'ぶ' or 'ブ': romaji = "bu"; break;
					case 'べ' or 'ベ': romaji = "be"; break;
					case 'ぼ' or 'ボ': romaji = "bo"; break;
					// p
					case 'ぱ' or 'パ': romaji = "pa"; break;
					case 'ぴ' or 'ピ': romaji = "pi"; break;
					case 'ぷ' or 'プ': romaji = "pu"; break;
					case 'ぺ' or 'ペ': romaji = "pe"; break;
					case 'ぽ' or 'ポ': romaji = "po"; break;
					// m
					case 'ま' or 'マ': romaji = "ma"; break;
					case 'み' or 'ミ': romaji = "mi"; break;
					case 'む' or 'ム': romaji = "mu"; break;
					case 'め' or 'メ': romaji = "me"; break;
					case 'も' or 'モ': romaji = "mo"; break;
					// y
					case 'や' or 'ヤ': romaji = "ya"; break;
					case 'ゆ' or 'ユ': romaji = "yu"; break;
					case 'よ' or 'ヨ': romaji = "yo"; break;
					// r
					case 'ら' or 'ラ': romaji = "ra"; break;
					case 'り' or 'リ': romaji = "ri"; break;
					case 'る' or 'ル': romaji = "ru"; break;
					case 'れ' or 'レ': romaji = "re"; break;
					case 'ろ' or 'ロ': romaji = "ro"; break;
					// w
					case 'わ' or 'ワ': romaji = "wa"; break;
					case 'を' or 'ヲ': romaji = "wo"; break;
					// special (拗音)
					case 'ゃ' or 'ャ': youon = Youon.Ya; break;
					case 'ゅ' or 'ュ': youon = Youon.Yu; break;
					case 'ェ': youon = Youon.Ye; break;
					case 'ょ' or 'ョ': youon = Youon.Yo; break;
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

				if (romaji != null)
				{
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
				}
				else if (youon.HasValue)
				{
					var consonantIndex = stringBuilder.Length - 2;
					if (consonantIndex < 0)
						throw new InvalidKanaException($"Yōon (拗音) \"{youon}\" cannot be the first character");

					var youonChar = youon.Value.GetChar();
					switch (stringBuilder[consonantIndex])
					{
						case 'k':
						case 'g':
						case 'n':
						case 'b':
						case 'p':
						case 'm':
						case 'r':
							{
								stringBuilder[consonantIndex + 1] = 'y';
								stringBuilder.Append(youonChar);
								break;
							}
						case 's':
						case 'j':
							{
								stringBuilder[consonantIndex + 1] = youonChar;
								break;
							}
						case 'h':
							{
								var checkIndex = consonantIndex - 1;
								if (checkIndex >= 0 && stringBuilder[checkIndex] is 'c' or 's')
									goto case 'j';

								goto case 'r';
							}
						default:
							throw new InvalidKanaException($"Unrecognised yōon (拗音) combination in \"{@this}\"");
					}
				}
			}

			return stringBuilder.ToString();
		}
	}
}
