namespace MyNihongo.KanaConverter.Tests.StringExKanaToKatakanaTests;

public sealed class KanaToKatakanaYouonShould
{
	[Fact]
	public void ReturnCharsYouonK()
	{
		const string input = "きぃきぅきぇきゃきゅきょ",
			expected = "キィキゥキェキャキュキョ";

		var result = input.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonG()
	{
		const string input = "ぎぃぎぅぎぇぎゃぎゅぎょ",
			expected = "ギィギゥギェギャギュギョ";

		var result = input.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonS()
	{
		const string input = "しぃしぅしぇしゃしゅしょ",
			expected = "シィシゥシェシャシュショ";

		var result = input.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonZ()
	{
		const string input = "じぃじぅじぇじゃじゅじょ",
			expected = "ジィジゥジェジャジュジョ";

		var result = input.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonT()
	{
		const string input = "ちぃちぅちぇちゃちゅちょ",
			expected = "チィチゥチェチャチュチョ";

		var result = input.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonN()
	{
		const string input = "にぃにぅにぇにゃにゅにょ",
			expected = "ニィニゥニェニャニュニョ";

		var result = input.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonH()
	{
		const string input = "ひぃひぅひぇひゃひゅひょ",
			expected = "ヒィヒゥヒェヒャヒュヒョ";

		var result = input.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonB()
	{
		const string input = "びぃびぅびぇびゃびゅびょ",
			expected = "ビィビゥビェビャビュビョ";

		var result = input.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonP()
	{
		const string input = "ぴぃぴぅぴぇぴゃぴゅぴょ",
			expected = "ピィピゥピェピャピュピョ";

		var result = input.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonM()
	{
		const string input = "みぃみぅみぇみゃみゅみょ",
			expected = "ミィミゥミェミャミュミョ";

		var result = input.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonR()
	{
		const string input = "りぃりぅりぇりゃりゅりょ",
			expected = "リィリゥリェリャリュリョ";

		var result = input.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}
}
