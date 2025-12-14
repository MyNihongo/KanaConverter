namespace MyNihongo.KanaConverter.Tests.RomajiToHiraganaStringBuilderExTests;

public sealed class AppendToHiraganaShould
{
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void NotAppendEmpty(string input)
	{
		var result = new StringBuilder()
			.AppendToHiragana(input)
			.ToString();

		result
			.Should()
			.BeEmpty();
	}

	[Fact]
	public void AppendToStringBuilder()
	{
		const string input = "ai",
			expected = "before あい after";

		var result = new StringBuilder("before ")
			.AppendToHiragana(input)
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
			expected = "before あ|い after";

		var result = new StringBuilder("before ")
			.AppendToHiragana(input, UnrecognisedCharacterPolicy.Append)
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
			expected = "before あい after";

		var result = new StringBuilder("before ")
			.AppendToHiragana(input, UnrecognisedCharacterPolicy.Skip)
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
			.AppendToHiragana(input)
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
