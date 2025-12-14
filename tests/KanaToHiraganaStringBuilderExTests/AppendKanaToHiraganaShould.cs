namespace MyNihongo.KanaConverter.Tests.KanaToHiraganaStringBuilderExTests;

public sealed class AppendKanaToHiraganaShould
{
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void NotAppendEmpty(string input)
	{
		var result = new StringBuilder()
			.AppendKanaToHiragana(input)
			.ToString();

		result
			.Should()
			.BeEmpty();
	}

	[Fact]
	public void AppendToStringBuilder()
	{
		const string input = "アイ",
			expected = "before あい after";

		var result = new StringBuilder("before ")
			.AppendKanaToHiragana(input)
			.Append(" after")
			.ToString();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void AppendInvalidCharacters()
	{
		const string input = "ア|イ",
			expected = "before あ|い after";

		var result = new StringBuilder("before ")
			.AppendKanaToHiragana(input, UnrecognisedCharacterPolicy.Append)
			.Append(" after")
			.ToString();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void SkipInvalidCharacters()
	{
		const string input = "ア|イ",
			expected = "before あい after";

		var result = new StringBuilder("before ")
			.AppendKanaToHiragana(input, UnrecognisedCharacterPolicy.Skip)
			.Append(" after")
			.ToString();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ThrowIfInvalidCharacters()
	{
		const string input = "ア|イ",
			errorMessage = "Invalid kana character \"|\" in \"ア|イ\"";

		var result = () => new StringBuilder("before ")
			.AppendKanaToHiragana(input)
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
