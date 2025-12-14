namespace MyNihongo.KanaConverter.Tests.KanaToKatakanaStringBuilderExTests;

public class AppendKanaToKatakanaShould
{
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void NotAppendEmpty(string input)
	{
		var result = new StringBuilder()
			.AppendKanaToKatakana(input)
			.ToString();

		result
			.Should()
			.BeEmpty();
	}

	[Fact]
	public void AppendToStringBuilder()
	{
		const string input = "あい",
			expected = "before アイ after";

		var result = new StringBuilder("before ")
			.AppendKanaToKatakana(input)
			.Append(" after")
			.ToString();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void AppendInvalidCharacters()
	{
		const string input = "あ|い",
			expected = "before ア|イ after";

		var result = new StringBuilder("before ")
			.AppendKanaToKatakana(input, UnrecognisedCharacterPolicy.Append)
			.Append(" after")
			.ToString();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void SkipInvalidCharacters()
	{
		const string input = "あ|い",
			expected = "before アイ after";

		var result = new StringBuilder("before ")
			.AppendKanaToKatakana(input, UnrecognisedCharacterPolicy.Skip)
			.Append(" after")
			.ToString();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ThrowIfInvalidCharacters()
	{
		const string input = "あ|い",
			errorMessage = "Invalid kana character \"|\" in \"あ|い\"";

		var result = () => new StringBuilder("before ")
			.AppendKanaToKatakana(input)
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
