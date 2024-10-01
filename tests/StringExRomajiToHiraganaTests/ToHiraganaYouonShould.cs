namespace MyNihongo.KanaConverter.Tests.StringExRomajiToHiraganaTests;

public sealed class ToHiraganaYouonShould
{
	[Fact]
	public void ReturnCharsYouonK()
	{
		const string input = "kyakyikyukyekyo",
			expected = "きゃきぃきゅきぇきょ";

		var result = input.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonG()
	{
		const string input = "gyagyigyugyegyo",
			expected = "ぎゃぎぃぎゅぎぇぎょ";

		var result = input.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonS()
	{
		const string input = "shashishushesho",
			expected = "しゃししゅしぇしょ";

		var result = input.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonZ()
	{
		const string input = "jajijujejo",
			expected = "じゃじじゅじぇじょ";

		var result = input.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonT()
	{
		const string input = "chachichuchecho",
			expected = "ちゃちちゅちぇちょ";

		var result = input.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonN()
	{
		const string input = "nyanyinyunyenyo",
			expected = "にゃにぃにゅにぇにょ";

		var result = input.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonH()
	{
		const string input = "hyahyihyuhyehyo",
			expected = "ひゃひぃひゅひぇひょ";

		var result = input.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonB()
	{
		const string input = "byabyibyubyebyo",
			expected = "びゃびぃびゅびぇびょ";

		var result = input.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonP()
	{
		const string input = "pyapyipyupyepyo",
			expected = "ぴゃぴぃぴゅぴぇぴょ";

		var result = input.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonM()
	{
		const string input = "myamyimyumyemyo",
			expected = "みゃみぃみゅみぇみょ";

		var result = input.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonR()
	{
		const string input = "ryaryiryuryeryo",
			expected = "りゃりぃりゅりぇりょ";

		var result = input.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonDakuten()
	{
		const string input = "vavivuvevo",
			expected = "ゔぁゔぃゔゔぇゔぉ";

		var result = input.ToHiragana();

		result
			.Should()
			.Be(expected);
	}
}
