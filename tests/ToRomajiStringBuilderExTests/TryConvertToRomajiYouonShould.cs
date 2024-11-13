namespace MyNihongo.KanaConverter.Tests.ToRomajiStringBuilderExTests;

public sealed class TryConvertToRomajiYouonShould
{
	[Theory]
	[InlineData("ゃき")]
	[InlineData("ぃき")]
	[InlineData("ゅき")]
	[InlineData("ぇき")]
	[InlineData("ょき")]
	[InlineData("ャキ")]
	[InlineData("ィキ")]
	[InlineData("ュキ")]
	[InlineData("ェキ")]
	[InlineData("ョキ")]
	public void ThrowExceptionIfStartsWithYouon(string input)
	{
		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeFalse();

		valueResult
			.Should()
			.BeEmpty();
	}

	[Theory]
	[InlineData("きぃきぅきぇきゃきゅきょ")]
	[InlineData("キィキゥキェキャキュキョ")]
	public void ReturnCharsYouonK(string input)
	{
		const string expected = "kyikyukyekyakyukyo";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ぎぃぎぅぎぇぎゃぎゅぎょ")]
	[InlineData("ギィギゥギェギャギュギョ")]
	public void ReturnCharsYouonG(string input)
	{
		const string expected = "gyigyugyegyagyugyo";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("しぃしぅしぇしゃしゅしょ")]
	[InlineData("シィシゥシェシャシュショ")]
	public void ReturnCharsYouonS(string input)
	{
		const string expected = "shishusheshashusho";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("じぃじぅじぇじゃじゅジョ")]
	[InlineData("ジィジゥジェジャジュジョ")]
	public void ReturnCharsYouonZ(string input)
	{
		const string expected = "jijujejajujo";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ちぃちぅちぇちゃちゅちょ")]
	[InlineData("チィチゥチェチャチュチョ")]
	public void ReturnCharsYouonT(string input)
	{
		const string expected = "chichuchechachucho";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("にぃにぅにぇにゃにゅにょ")]
	[InlineData("ニィニゥニェニャニュニョ")]
	public void ReturnCharsYouonＮ(string input)
	{
		const string expected = "nyinyunyenyanyunyo";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ひぃひぅひぇひゃひゅひょ")]
	[InlineData("ヒィヒゥヒェヒャヒュヒョ")]
	public void ReturnCharsYouonH(string input)
	{
		const string expected = "hyihyuhyehyahyuhyo";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("びぃびぅびぇびゃびゅびょ")]
	[InlineData("ビィビゥビェビャビュビョ")]
	public void ReturnCharsYouonB(string input)
	{
		const string expected = "byibyubyebyabyubyo";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ぴぃぴぅぴぇぴゃぴゅぴょ")]
	[InlineData("ピィピゥピェピャピュピョ")]
	public void ReturnCharsYouonP(string input)
	{
		const string expected = "pyipyupyepyapyupyo";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("みぃみぅみぇみゃみゅみょ")]
	[InlineData("ミィミゥミェミャミュミョ")]
	public void ReturnCharsYouonM(string input)
	{
		const string expected = "myimyumyemyamyumyo";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("りぃりぅりぇりゃりゅりょ")]
	[InlineData("リィリゥリェリャリュリョ")]
	public void ReturnCharsYouonR(string input)
	{
		const string expected = "ryiryuryeryaryuryo";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}
}
