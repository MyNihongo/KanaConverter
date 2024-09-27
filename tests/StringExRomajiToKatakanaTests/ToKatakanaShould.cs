namespace MyNihongo.KanaConverter.Tests.StringExRomajiToKatakanaTests;

public sealed class ToKatakanaShould
{
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void ReturnEmptyIfNullOrEmpty(string input)
	{
		var result = input.ToKatakana();

		result
			.Should()
			.BeEmpty();
	}

	[Fact]
	public void ReturnChars()
	{
		const string input = "aiueon",
			expected = "アイウエオン";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnDakuten()
	{
		const string input = "vu",
			expected = "ヴ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsK()
	{
		const string input = "kakikukeko",
			expected = "カキクケコ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsG()
	{
		const string input = "gagigugego",
			expected = "ガギグゲゴ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsS()
	{
		const string input = "sashisuseso",
			expected = "サシスセソ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("zajizuzezo")]
	[InlineData("zazizuzezo")]
	public void ReturnCharsZ(string input)
	{
		const string expected = "ザジズゼゾ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("tachitsuteto")]
	[InlineData("tathitsuteto")]
	[InlineData("tacitsuteto")]
	[InlineData("tachituteto")]
	[InlineData("tachicuteto")]
	[InlineData("tachicsuteto")]
	public void ReturnCharsT(string input)
	{
		const string expected = "タチツテト";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("kantan", "カンタン")]
	public void ReturnCharsWords(string input, string expected)
	{
		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}
}
