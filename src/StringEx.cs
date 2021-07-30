using System.Text;
using MyNihongo.KanaConverter.Exceptions;

namespace MyNihongo.KanaConverter
{
	public static class StringEx
	{
		/// <summary>
		/// Converts a kana (hiragana or katakana) string to romaji
		/// </summary>
		/// <exception cref="InvalidKanaException"></exception>
		public static string ToRomaji(this string @this)
		{
			if (string.IsNullOrEmpty(@this))
				return string.Empty;

			var stringBuilder = new StringBuilder(@this.Length);
			var isSokuon = false;

			for (var i = 0; i < @this.Length; i++)
			{
				string? romaji = null;
				Youon? youon = null;

				switch (@this[i])
				{
					// basic
					case 'あ': case 'ア': romaji = "a"; break;
					case 'い': case 'イ': romaji = "i"; break;
					case 'う': case 'ウ': romaji = "u"; break;
					case 'え': case 'エ': romaji = "e"; break;
					case 'お': case 'オ': romaji = "o"; break;
					case 'ん': case 'ン': romaji = "n"; break;
					// k
					case 'か': case 'カ': romaji = "ka"; break;
					case 'き': case 'キ': romaji = "ki"; break;
					case 'く': case 'ク': romaji = "ku"; break;
					case 'け': case 'ケ': romaji = "ke"; break;
					case 'こ': case 'コ': romaji = "ko"; break;
					// g
					case 'が': case 'ガ': romaji = "ga"; break;
					case 'ぎ': case 'ギ': romaji = "gi"; break;
					case 'ぐ': case 'グ': romaji = "gu"; break;
					case 'げ': case 'ゲ': romaji = "ge"; break;
					case 'ご': case 'ゴ': romaji = "go"; break;
					// s
					case 'さ': case 'サ': romaji = "sa"; break;
					case 'し': case 'シ': romaji = "shi"; break;
					case 'す': case 'ス': romaji = "su"; break;
					case 'せ': case 'セ': romaji = "se"; break;
					case 'そ': case 'ソ': romaji = "so"; break;
					// z
					case 'ざ': case 'ザ': romaji = "za"; break;
					case 'じ': case 'ジ': romaji = "ji"; break;
					case 'ず': case 'ズ': romaji = "zu"; break;
					case 'ぜ': case 'ゼ': romaji = "ze"; break;
					case 'ぞ': case 'ゾ': romaji = "zo"; break;
					// t
					case 'た': case 'タ': romaji = "ta"; break;
					case 'ち': case 'チ': romaji = "chi"; break;
					case 'つ': case 'ツ': romaji = "tsu"; break;
					case 'て': case 'テ': romaji = "te"; break;
					case 'と': case 'ト': romaji = "to"; break;
					// d
					case 'だ': case 'ダ': romaji = "da"; break;
					case 'ぢ': case 'ヂ': romaji = "ji"; break;
					case 'づ': case 'ヅ': romaji = "zu"; break;
					case 'で': case 'デ': romaji = "de"; break;
					case 'ど': case 'ド': romaji = "do"; break;
					// n
					case 'な': case 'ナ': romaji = "na"; break;
					case 'に': case 'ニ': romaji = "ni"; break;
					case 'ぬ': case 'ヌ': romaji = "nu"; break;
					case 'ね': case 'ネ': romaji = "ne"; break;
					case 'の': case 'ノ': romaji = "no"; break;
					// h
					case 'は': case 'ハ': romaji = "ha"; break;
					case 'ひ': case 'ヒ': romaji = "hi"; break;
					case 'ふ': case 'フ': romaji = "fu"; break;
					case 'へ': case 'ヘ': romaji = "he"; break;
					case 'ほ': case 'ホ': romaji = "ho"; break;
					// b
					case 'ば': case 'バ': romaji = "ba"; break;
					case 'び': case 'ビ': romaji = "bi"; break;
					case 'ぶ': case 'ブ': romaji = "bu"; break;
					case 'べ': case 'ベ': romaji = "be"; break;
					case 'ぼ': case 'ボ': romaji = "bo"; break;
					// p
					case 'ぱ': case 'パ': romaji = "pa"; break;
					case 'ぴ': case 'ピ': romaji = "pi"; break;
					case 'ぷ': case 'プ': romaji = "pu"; break;
					case 'ぺ': case 'ペ': romaji = "pe"; break;
					case 'ぽ': case 'ポ': romaji = "po"; break;
					// m
					case 'ま': case 'マ': romaji = "ma"; break;
					case 'み': case 'ミ': romaji = "mi"; break;
					case 'む': case 'ム': romaji = "mu"; break;
					case 'め': case 'メ': romaji = "me"; break;
					case 'も': case 'モ': romaji = "mo"; break;
					// y
					case 'や': case 'ヤ': romaji = "ya"; break;
					case 'ゆ': case 'ユ': romaji = "yu"; break;
					case 'よ': case 'ヨ': romaji = "yo"; break;
					// r
					case 'ら': case 'ラ': romaji = "ra"; break;
					case 'り': case 'リ': romaji = "ri"; break;
					case 'る': case 'ル': romaji = "ru"; break;
					case 'れ': case 'レ': romaji = "re"; break;
					case 'ろ': case 'ロ': romaji = "ro"; break;
					// w
					case 'わ': case 'ワ': romaji = "wa"; break;
					case 'を': case 'ヲ': romaji = "wo"; break;
					// special (拗音)
					case 'ゃ': case 'ャ': youon = Youon.Ya; break;
					case 'ゅ': case 'ュ': youon = Youon.Yu; break;
					case 'ょ': case 'ョ': youon = Youon.Yo; break;
					// special (促音)
					case 'っ': case 'ッ': isSokuon = true; continue;
					default:
						throw new InvalidKanaException(@this[i], @this);
				}

				if (romaji != null)
				{
					if (isSokuon)
					{
						isSokuon = false;
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
								if (checkIndex >= 0)
								{
									if (stringBuilder[checkIndex] == 'c' || stringBuilder[checkIndex] == 's')
										goto case 'j';
								}
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
