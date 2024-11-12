namespace MyNihongo.KanaConverter.Tests.KanaToHiraganaStringBuilderExTests;

public sealed class KanaToHiraganaYouonShould
{
	[Fact]
	public void ReturnCharsYouonK()
	{
		const string expected = "きぁきぃきぅきぇきぉきゃきゅきょきゎ",
			input = "キァキィキゥキェキォキャキュキョキヮ";

		var result = new StringBuilder(input)
			.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonG()
	{
		const string expected = "ぎぃぎぅぎぇぎゃぎゅぎょ",
			input = "ギィギゥギェギャギュギョ";

		var result = new StringBuilder(input)
			.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonS()
	{
		const string expected = "しぃしぅしぇしゃしゅしょ",
			input = "シィシゥシェシャシュショ";

		var result = new StringBuilder(input)
			.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonZ()
	{
		const string expected = "じぃじぅじぇじゃじゅじょ",
			input = "ジィジゥジェジャジュジョ";

		var result = new StringBuilder(input)
			.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonT()
	{
		const string expected = "ちぃちぅちぇちゃちゅちょ",
			input = "チィチゥチェチャチュチョ";

		var result = new StringBuilder(input)
			.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonN()
	{
		const string expected = "にぃにぅにぇにゃにゅにょ",
			input = "ニィニゥニェニャニュニョ";

		var result = new StringBuilder(input)
			.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonH()
	{
		const string expected = "ひぃひぅひぇひゃひゅひょ",
			input = "ヒィヒゥヒェヒャヒュヒョ";

		var result = new StringBuilder(input)
			.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonB()
	{
		const string expected = "びぃびぅびぇびゃびゅびょ",
			input = "ビィビゥビェビャビュビョ";

		var result = new StringBuilder(input)
			.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonP()
	{
		const string expected = "ぴぃぴぅぴぇぴゃぴゅぴょ",
			input = "ピィピゥピェピャピュピョ";

		var result = new StringBuilder(input)
			.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonM()
	{
		const string expected = "みぃみぅみぇみゃみゅみょ",
			input = "ミィミゥミェミャミュミョ";

		var result = new StringBuilder(input)
			.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonR()
	{
		const string expected = "りぃりぅりぇりゃりゅりょ",
			input = "リィリゥリェリャリュリョ";

		var result = new StringBuilder(input)
			.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}
}
