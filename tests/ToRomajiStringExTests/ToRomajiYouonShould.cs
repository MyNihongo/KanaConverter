namespace MyNihongo.KanaConverter.Tests.ToRomajiStringExTests;

public sealed class ToRomajiYouonShould
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
		Action action = () => input.ToRomaji();

		action
			.Should()
			.ThrowExactly<InvalidCharacterException>();
	}

	[Theory]
	[InlineData("きぃきぅきぇきゃきゅきょ")]
	[InlineData("キィキゥキェキャキュキョ")]
	public void ReturnCharsYouonK(string input)
	{
		const string expected = "kyikyukyekyakyukyo";

		var result = input.ToRomaji();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ぎぃぎぅぎぇぎゃぎゅぎょ")]
	[InlineData("ギィギゥギェギャギュギョ")]
	public void ReturnCharsYouonG(string input)
	{
		const string expected = "gyigyugyegyagyugyo";

		var result = input.ToRomaji();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("しぃしぅしぇしゃしゅしょ")]
	[InlineData("シィシゥシェシャシュショ")]
	public void ReturnCharsYouonS(string input)
	{
		const string expected = "shishusheshashusho";

		var result = input.ToRomaji();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("じぃじぅじぇじゃじゅじょ")]
	[InlineData("ジィジゥジェジャジュジョ")]
	public void ReturnCharsYouonZ(string input)
	{
		const string expected = "jijujejajujo";

		var result = input.ToRomaji();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ちぃちぅちぇちゃちゅちょ")]
	[InlineData("チィチゥチェチャチュチョ")]
	public void ReturnCharsYouonT(string input)
	{
		const string expected = "chichuchechachucho";

		var result = input.ToRomaji();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("にぃにぅにぇにゃにゅにょ")]
	[InlineData("ニィニゥニェニャニュニョ")]
	public void ReturnCharsYouonN(string input)
	{
		const string expected = "nyinyunyenyanyunyo";

		var result = input.ToRomaji();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ひぃひぅひぇひゃひゅひょ")]
	[InlineData("ヒィヒゥヒェヒャヒュヒョ")]
	public void ReturnCharsYouonH(string input)
	{
		const string expected = "hyihyuhyehyahyuhyo";

		var result = input.ToRomaji();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("びぃびぅびぇびゃびゅびょ")]
	[InlineData("ビィビゥビェビャビュビョ")]
	public void ReturnCharsYouonB(string input)
	{
		const string expected = "byibyubyebyabyubyo";

		var result = input.ToRomaji();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ぴぃぴぅぴぇぴゃぴゅぴょ")]
	[InlineData("ピィピゥピェピャピュピョ")]
	public void ReturnCharsYouonP(string input)
	{
		const string expected = "pyipyupyepyapyupyo";

		var result = input.ToRomaji();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("みぃみぅみぇみゃみゅみょ")]
	[InlineData("ミィミゥミェミャミュミョ")]
	public void ReturnCharsYouonM(string input)
	{
		const string expected = "myimyumyemyamyumyo";

		var result = input.ToRomaji();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("りぃりぅりぇりゃりゅりょ")]
	[InlineData("リィリゥリェリャリュリョ")]
	public void ReturnCharsYouonR(string input)
	{
		const string expected = "ryiryuryeryaryuryo";

		var result = input.ToRomaji();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ゔぁゔぃゔぅゔぇゔぉ")]
	[InlineData("ヴァヴィヴゥヴェヴォ")]
	public void ReturnCharsDakuten(string input)
	{
		const string expected = "vavivuvevo";

		var result = input.ToRomaji();

		result
			.Should()
			.Be(expected);
	}
}
