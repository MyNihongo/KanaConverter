using FluentAssertions;
using Xunit;

namespace MyNihongo.KanaConverter.Tests.StringExTests
{
	public sealed class ToRomajiKatakanaShould
	{
		[Theory]
		[InlineData("アー", "aa")]
		[InlineData("カー", "kaa")]
		[InlineData("キャー", "kyaa")]
		[InlineData("ガー", "gaa")]
		[InlineData("ギャー", "gyaa")]
		[InlineData("サー", "saa")]
		[InlineData("シャー", "shaa")]
		[InlineData("ザー", "zaa")]
		[InlineData("ジャー", "jaa")]
		[InlineData("ター", "taa")]
		[InlineData("チャー", "chaa")]
		[InlineData("ダー", "daa")]
		[InlineData("ヂャー", "jaa")]
		[InlineData("ナー", "naa")]
		[InlineData("ニャー", "nyaa")]
		[InlineData("ハー", "haa")]
		[InlineData("ヒャー", "hyaa")]
		[InlineData("バー", "baa")]
		[InlineData("ビャー", "byaa")]
		[InlineData("パー", "paa")]
		[InlineData("ピャー", "pyaa")]
		[InlineData("マー", "maa")]
		[InlineData("ミャー", "myaa")]
		[InlineData("ヤー", "yaa")]
		[InlineData("ラー", "raa")]
		[InlineData("リャー", "ryaa")]
		[InlineData("ワー", "waa")]
		public void ReturnCharsLongVowelA(string input, string expectedResult)
		{
			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("イー", "ii")]
		[InlineData("キー", "kii")]
		[InlineData("ギー", "gii")]
		[InlineData("シー", "shii")]
		[InlineData("ジー", "jii")]
		[InlineData("チー", "chii")]
		[InlineData("ヂー", "jii")]
		[InlineData("ニー", "nii")]
		[InlineData("ヒー", "hii")]
		[InlineData("ビー", "bii")]
		[InlineData("ピー", "pii")]
		[InlineData("ミー", "mii")]
		[InlineData("リー", "rii")]
		public void ReturnCharsLongVowelI(string input, string expectedResult)
		{
			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ウー", "uu")]
		[InlineData("クー", "kuu")]
		[InlineData("キュー", "kyuu")]
		[InlineData("グー", "guu")]
		[InlineData("ギュー", "gyuu")]
		[InlineData("スー", "suu")]
		[InlineData("シュー", "shuu")]
		[InlineData("ズー", "zuu")]
		[InlineData("ジュー", "juu")]
		[InlineData("ツー", "tsuu")]
		[InlineData("チュー", "chuu")]
		[InlineData("ヅー", "zuu")]
		[InlineData("ヌー", "nuu")]
		[InlineData("ニュー", "nyuu")]
		[InlineData("フー", "fuu")]
		[InlineData("ヒュー", "hyuu")]
		[InlineData("ブー", "buu")]
		[InlineData("ビュー", "byuu")]
		[InlineData("プー", "puu")]
		[InlineData("ピュー", "pyuu")]
		[InlineData("ムー", "muu")]
		[InlineData("ミュー", "myuu")]
		[InlineData("ユー", "yuu")]
		[InlineData("ルー", "ruu")]
		[InlineData("リュー", "ryuu")]
		public void ReturnCahrsLongVowelU(string input, string expectedResult)
		{
			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("エー", "ee")]
		[InlineData("ケー", "kee")]
		[InlineData("ゲー", "gee")]
		[InlineData("セー", "see")]
		[InlineData("ゼー", "zee")]
		[InlineData("テー", "tee")]
		[InlineData("デー", "dee")]
		[InlineData("ネー", "nee")]
		[InlineData("ヘー", "hee")]
		[InlineData("ベー", "bee")]
		[InlineData("ペー", "pee")]
		[InlineData("メー", "mee")]
		[InlineData("レー", "ree")]
		public void ReturnCharsLongVowelE(string input, string expectedResult)
		{
			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("オー", "oo")]
		[InlineData("コー", "koo")]
		[InlineData("キョー", "kyoo")]
		[InlineData("ゴー", "goo")]
		[InlineData("ギョー", "gyoo")]
		[InlineData("ソー", "soo")]
		[InlineData("ショー", "shoo")]
		[InlineData("ゾー", "zoo")]
		[InlineData("ジョー", "joo")]
		[InlineData("トー", "too")]
		[InlineData("チョー", "choo")]
		[InlineData("ドー", "doo")]
		[InlineData("ヂョー", "joo")]
		[InlineData("ノー", "noo")]
		[InlineData("ニョー", "nyoo")]
		[InlineData("ホー", "hoo")]
		[InlineData("ヒョー", "hyoo")]
		[InlineData("ボー", "boo")]
		[InlineData("ビョー", "byoo")]
		[InlineData("ポー", "poo")]
		[InlineData("ピョー", "pyoo")]
		[InlineData("モー", "moo")]
		[InlineData("ミョー", "myoo")]
		[InlineData("ヨー", "yoo")]
		[InlineData("ロー", "roo")]
		[InlineData("リョー", "ryoo")]
		[InlineData("ヲー", "woo")]
		public void ReturnCharsLongVowelO(string input, string expectedResult)
		{
			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("キェ", "kye")]
		[InlineData("ギェ", "gye")]
		[InlineData("シェ", "she")]
		[InlineData("ジェ", "je")]
		[InlineData("チェ", "che")]
		[InlineData("ニェ", "nye")]
		[InlineData("ヒェ", "hye")]
		[InlineData("ビェ", "bye")]
		[InlineData("ピェ", "pye")]
		[InlineData("ミェ", "mye")]
		[InlineData("リェ", "rye")]
		public void ReturnCharsYouonE(string input, string expectedResult)
		{
			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}
	}
}
