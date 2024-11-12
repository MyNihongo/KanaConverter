namespace MyNihongo.KanaConverter.Tests.KanaToHiraganaStringExTests;

public sealed class KanaToHiraganaUnknownCharShould
{
	[Fact]
	public void ThrowExceptionByDefault()
	{
		const string input = "ひaらがな";

		var func = () => input.KanaToHiragana();

		func
			.Should()
			.Throw<InvalidCharacterException>();
	}

	[Fact]
	public void SkipUnknownCharacters()
	{
		const UnrecognisedCharacterPolicy policy = UnrecognisedCharacterPolicy.Skip;

		const string input = "ヒaラガナ",
			expected = "ひらがな";

		var result = input.KanaToHiragana(policy);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void AppendUnknownCharacters()
	{
		const UnrecognisedCharacterPolicy policy = UnrecognisedCharacterPolicy.Append;

		const string input = "ヒラガナガ好キ",
			expected = "ひらがなが好き";

		var result = input.KanaToHiragana(policy);

		result
			.Should()
			.Be(expected);
	}
}
