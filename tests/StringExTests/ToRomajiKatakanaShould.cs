namespace MyNihongo.KanaConverter.Tests.StringExTests;

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
	public void ReturnCharsLongVowelA(string input, string expected)
	{
		var result = input.ToRomaji();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("イー", "ii")]
	[InlineData("キー", "kii")]
	[InlineData("キィー", "kyii")]
	[InlineData("ギー", "gii")]
	[InlineData("ギィー", "gyii")]
	[InlineData("シー", "shii")]
	[InlineData("シィー", "shii")]
	[InlineData("ジー", "jii")]
	[InlineData("ジィー", "jii")]
	[InlineData("チー", "chii")]
	[InlineData("チィー", "chii")]
	[InlineData("ヂー", "jii")]
	[InlineData("ニー", "nii")]
	[InlineData("ニィー", "nyii")]
	[InlineData("ヒー", "hii")]
	[InlineData("ヒィー", "hyii")]
	[InlineData("ビー", "bii")]
	[InlineData("ビィー", "byii")]
	[InlineData("ピー", "pii")]
	[InlineData("ピィー", "pyii")]
	[InlineData("ミー", "mii")]
	[InlineData("ミィー", "myii")]
	[InlineData("リー", "rii")]
	[InlineData("リィー", "ryii")]
	public void ReturnCharsLongVowelI(string input, string expected)
	{
		var result = input.ToRomaji();

		result
			.Should()
			.Be(expected);
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
	public void ReturnCahrsLongVowelU(string input, string expected)
	{
		var result = input.ToRomaji();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("エー", "ee")]
	[InlineData("ケー", "kee")]
	[InlineData("キェー", "kyee")]
	[InlineData("ゲー", "gee")]
	[InlineData("ギェー", "gyee")]
	[InlineData("セー", "see")]
	[InlineData("シェー", "shee")]
	[InlineData("ゼー", "zee")]
	[InlineData("ジェー", "jee")]
	[InlineData("テー", "tee")]
	[InlineData("チェー", "chee")]
	[InlineData("デー", "dee")]
	[InlineData("ネー", "nee")]
	[InlineData("ニェー", "nyee")]
	[InlineData("ヘー", "hee")]
	[InlineData("ヒェー", "hyee")]
	[InlineData("ベー", "bee")]
	[InlineData("ビェー", "byee")]
	[InlineData("ペー", "pee")]
	[InlineData("ピェー", "pyee")]
	[InlineData("メー", "mee")]
	[InlineData("ミェー", "myee")]
	[InlineData("レー", "ree")]
	[InlineData("リェー", "ryee")]
	public void ReturnCharsLongVowelE(string input, string expected)
	{
		var result = input.ToRomaji();

		result
			.Should()
			.Be(expected);
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
	public void ReturnCharsLongVowelO(string input, string expected)
	{
		var result = input.ToRomaji();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void SkipPunctuationMark()
	{
		const string input = "ジ・エンド",
			expected = "jiendo";

		var result = input.ToRomaji();

		result
			.Should()
			.Be(expected);
	}
}