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
}
