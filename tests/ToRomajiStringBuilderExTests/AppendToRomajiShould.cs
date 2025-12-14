namespace MyNihongo.KanaConverter.Tests.ToRomajiStringBuilderExTests;

public sealed class AppendToRomajiShould
{
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void NotAppendEmpty(string input)
	{
		var result = new StringBuilder()
			.AppendToRomaji(input)
			.ToString();

		result
			.Should()
			.BeEmpty();
	}

	[Fact]
	public void AppendToStringBuilder()
	{
		const string input = "あイ",
			expected = "before ai after";

		var result = new StringBuilder("before ")
			.AppendToRomaji(input)
			.Append(" after")
			.ToString();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void AppendInvalidCharacters()
	{
		const string input = "あ|イ",
			expected = "before a|i after";

		var result = new StringBuilder("before ")
			.AppendToRomaji(input, UnrecognisedCharacterPolicy.Append)
			.Append(" after")
			.ToString();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void SkipInvalidCharacters()
	{
		const string input = "あ|イ",
			expected = "before ai after";

		var result = new StringBuilder("before ")
			.AppendToRomaji(input, UnrecognisedCharacterPolicy.Skip)
			.Append(" after")
			.ToString();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ThrowIfInvalidCharacters()
	{
		const string input = "あ|イ",
			errorMessage = "Invalid kana character \"|\" in \"あ|イ\"";

		var result = () => new StringBuilder("before ")
			.AppendToRomaji(input)
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
