namespace MyNihongo.KanaConverter.Tests.RomajiToKatakanaStringBuilderExTests;

public sealed class AppendToKatakanaShould
{
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void NotAppendEmpty(string input)
	{
		var result = new StringBuilder()
			.AppendToKatakana(input)
			.ToString();

		result
			.Should()
			.BeEmpty();
	}

	[Fact]
	public void AppendToStringBuilder()
	{
		const string input = "ai",
			expected = "before アイ after";

		var result = new StringBuilder("before ")
			.AppendToKatakana(input)
			.Append(" after")
			.ToString();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void AppendInvalidCharacters()
	{
		const string input = "a|i",
			expected = "before ア|イ after";

		var result = new StringBuilder("before ")
			.AppendToKatakana(input, UnrecognisedCharacterPolicy.Append)
			.Append(" after")
			.ToString();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void SkipInvalidCharacters()
	{
		const string input = "a|i",
			expected = "before アイ after";

		var result = new StringBuilder("before ")
			.AppendToKatakana(input, UnrecognisedCharacterPolicy.Skip)
			.Append(" after")
			.ToString();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ThrowIfInvalidCharacters()
	{
		const string input = "a|i",
			errorMessage = "Invalid kana character \"|\" in \"a|i\"";

		var result = () => new StringBuilder("before ")
			.AppendToKatakana(input)
			.Append(" after")
			.ToString();

		result
			.Should()
			.Throw<InvalidCharacterException>()
			.And.Message
			.Should()
			.Be(errorMessage);
	}
}
