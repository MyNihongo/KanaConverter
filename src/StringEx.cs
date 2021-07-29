using System.Text;
using MyNihongo.KanaConverter.Exceptions;

namespace MyNihongo.KanaConverter
{
	public static class StringEx
	{
		/// <summary>
		/// Converts a kana (hiragana or katakana) string to romaji
		/// </summary>
		public static string ToRomaji(this string @this)
		{
			if (string.IsNullOrEmpty(@this))
				return string.Empty;

			var stringBuilder = new StringBuilder(@this.Length);

			for (var i = 0; i < @this.Length; i++)
			{
				string romaji = @this[i] switch
				{
					// basic
					'あ' or 'ア' => "a",
					'い' or 'イ' => "i",
					'う' or 'ウ' => "u",
					'え' or 'エ' => "e",
					'お' or 'オ' => "o",
					'ん' or 'ン' => "n",
					// k
					'か' or 'カ' => "ka",
					'き' or 'キ' => "ki",
					'く' or 'ク' => "ku",
					'け' or 'ケ' => "ke",
					'こ' or 'コ' => "ko",
					// g
					'が' or 'ガ' => "ga",
					'ぎ' or 'ギ' => "gi",
					'ぐ' or 'グ' => "gu",
					'げ' or 'ゲ' => "ge",
					'ご' or 'ゴ' => "go",
					// s
					'さ' or 'サ' => "sa",
					'し' or 'シ' => "shi",
					'す' or 'ス' => "su",
					'せ' or 'セ' => "se",
					'そ' or 'ソ' => "so",
					// z
					'ざ' or 'ザ' => "za",
					'じ' or 'ジ' => "ji",
					'ず' or 'ズ' => "zu",
					'ぜ' or 'ゼ' => "ze",
					'ぞ' or 'ゾ' => "zo",
					// t
					'た' or 'タ' => "ta",
					'ち' or 'チ' => "chi",
					'つ' or 'ツ' => "tsu",
					'て' or 'テ' => "te",
					'と' or 'ト' => "to",
					// d
					'だ' or 'ダ' => "da",
					'ぢ' or 'ヂ' => "ji",
					'づ' or 'ヅ' => "zu",
					'で' or 'デ' => "de",
					'ど' or 'ド' => "do",
					// n
					'な' or 'ナ' => "na",
					'に' or 'ニ' => "ni",
					'ぬ' or 'ヌ' => "nu",
					'ね' or 'ネ' => "ne",
					'の' or 'ノ' => "no",
					// h
					'は' or 'ハ' => "ha",
					'ひ' or 'ヒ' => "hi",
					'ふ' or 'フ' => "fu",
					'へ' or 'ヘ' => "he",
					'ほ' or 'ホ' => "ho",
					// b
					'ば' or 'バ' => "ba",
					'び' or 'ビ' => "bi",
					'ぶ' or 'ブ' => "bu",
					'べ' or 'ベ' => "be",
					'ぼ' or 'ボ' => "bo",
					// p
					'ぱ' or 'パ' => "pa",
					'ぴ' or 'ピ' => "pi",
					'ぷ' or 'プ' => "pu",
					'ぺ' or 'ペ' => "pe",
					'ぽ' or 'ポ' => "po",
					// m
					'ま' or 'マ' => "ma",
					'み' or 'ミ' => "mi",
					'む' or 'ム' => "mu",
					'め' or 'メ' => "me",
					'も' or 'モ' => "mo",
					// y
					'や' or 'ヤ' => "ya",
					'ゆ' or 'ユ' => "yu",
					'よ' or 'ヨ' => "yo",
					// r
					'ら' or 'ラ' => "ra",
					'り' or 'リ' => "ri",
					'る' or 'ル' => "ru",
					'れ' or 'レ' => "re",
					'ろ' or 'ロ' => "ro",
					// w
					'わ' or 'ワ' => "wa",
					'を' or 'ヲ' => "wo",
					_ => throw new InvalidKanaException(@this[i], @this)
				};

				stringBuilder.Append(romaji);
			}

			return stringBuilder.ToString();
		}
	}
}
