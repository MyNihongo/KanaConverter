namespace MyNihongo.KanaConverter.Tests.StringExKanaToHiraganaTests;

public sealed class TryConvertKanaToHiraganaYouonShould
{
	[Fact]
	public void ReturnCharsYouonK()
	{
		const string expected = "きぁきぃきぅきぇきぉきゃきゅきょきゎ";
		const string input = "キァキィキゥキェキォキャキュキョキヮ";

		var result = input.TryConvertKanaToHiragana(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonG()
	{
		const string expected = "ぎぃぎぅぎぇぎゃぎゅぎょ";
		const string input = "ギィギゥギェギャギュギョ";

		var result = input.TryConvertKanaToHiragana(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonS()
	{
		const string expected = "しぃしぅしぇしゃしゅしょ";
		const string input = "シィシゥシェシャシュショ";

		var result = input.TryConvertKanaToHiragana(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonZ()
	{
		const string expected = "じぃじぅじぇじゃじゅじょ";
		const string input = "ジィジゥジェジャジュジョ";

		var result = input.TryConvertKanaToHiragana(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonT()
	{
		const string expected = "ちぃちぅちぇちゃちゅちょ";
		const string input = "チィチゥチェチャチュチョ";

		var result = input.TryConvertKanaToHiragana(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonN()
	{
		const string expected = "にぃにぅにぇにゃにゅにょ";
		const string input = "ニィニゥニェニャニュニョ";

		var result = input.TryConvertKanaToHiragana(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonH()
	{
		const string expected = "ひぃひぅひぇひゃひゅひょ";
		const string input = "ヒィヒゥヒェヒャヒュヒョ";

		var result = input.TryConvertKanaToHiragana(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonB()
	{
		const string expected = "びぃびぅびぇびゃびゅびょ";
		const string input = "ビィビゥビェビャビュビョ";

		var result = input.TryConvertKanaToHiragana(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonP()
	{
		const string expected = "ぴぃぴぅぴぇぴゃぴゅぴょ";
		const string input = "ピィピゥピェピャピュピョ";

		var result = input.TryConvertKanaToHiragana(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonM()
	{
		const string expected = "みぃみぅみぇみゃみゅみょ";
		const string input = "ミィミゥミェミャミュミョ";

		var result = input.TryConvertKanaToHiragana(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonR()
	{
		const string expected = "りぃりぅりぇりゃりゅりょ";
		const string input = "リィリゥリェリャリュリョ";

		var result = input.TryConvertKanaToHiragana(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}
}
