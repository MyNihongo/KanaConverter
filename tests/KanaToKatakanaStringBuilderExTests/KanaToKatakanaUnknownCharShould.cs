namespace MyNihongo.KanaConverter.Tests.KanaToKatakanaStringBuilderExTests;

public sealed class KanaToKatakanaUnknownCharShould
{
	[Fact]
	public void ThrowExceptionByDefault()
	{
		const string input = "かたかaな";

		var func = () => new StringBuilder(input)
			.KanaToKatakana();

		func
			.Should()
			.Throw<InvalidCharacterException>();
	}

	[Fact]
	public void SkipUnknownCharacters()
	{
		const UnrecognisedCharacterPolicy policy = UnrecognisedCharacterPolicy.Skip;

		const string input = "かbたかaな",
			expected = "カタカナ";

		var result = new StringBuilder(input)
			.KanaToKatakana(policy);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void AppendUnknownCharacters()
	{
		const UnrecognisedCharacterPolicy policy = UnrecognisedCharacterPolicy.Append;

		const string input = "カタカナが好き",
			expected = "カタカナガ好キ";

		var result = new StringBuilder(input)
			.KanaToKatakana(policy);

		result
			.Should()
			.Be(expected);
	}
}
