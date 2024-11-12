namespace MyNihongo.KanaConverter.Tests.RomajiToKatakanaStringExTests;

public sealed class ToKatakanaYouonShould
{
	[Fact]
	public void ReturnCharsYouonK()
	{
		const string input = "kyakyikyukyekyo",
			expected = "キャキィキュキェキョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonG()
	{
		const string input = "gyagyigyugyegyo",
			expected = "ギャギィギュギェギョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonS()
	{
		const string input = "shashishushesho",
			expected = "シャシシュシェショ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonZ()
	{
		const string input = "jajijujejo",
			expected = "ジャジジュジェジョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonT()
	{
		const string input = "chachichuchecho",
			expected = "チャチチュチェチョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonN()
	{
		const string input = "nyanyinyunyenyo",
			expected = "ニャニィニュニェニョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonH()
	{
		const string input = "hyahyihyuhyehyo",
			expected = "ヒャヒィヒュヒェヒョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonB()
	{
		const string input = "byabyibyubyebyo",
			expected = "ビャビィビュビェビョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonP()
	{
		const string input = "pyapyipyupyepyo",
			expected = "ピャピィピュピェピョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonM()
	{
		const string input = "myamyimyumyemyo",
			expected = "ミャミィミュミェミョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonR()
	{
		const string input = "ryaryiryuryeryo",
			expected = "リャリィリュリェリョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonDakuten()
	{
		const string input = "vavivuvevo",
			expected = "ヴァヴィヴヴェヴォ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}
}
