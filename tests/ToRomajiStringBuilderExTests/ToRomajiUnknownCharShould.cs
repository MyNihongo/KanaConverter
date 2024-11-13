namespace MyNihongo.KanaConverter.Tests.ToRomajiStringBuilderExTests;

public sealed class ToRomajiUnknownCharShould
{
	[Fact]
	public void ThrowExceptionByDefault()
	{
		const string input = "かたかaな";

		var func = () => new StringBuilder(input)
			.ToRomaji();

		func
			.Should()
			.Throw<InvalidCharacterException>();
	}

	[Fact]
	public void SkipUnknownCharacters()
	{
		const UnrecognisedCharacterPolicy policy = UnrecognisedCharacterPolicy.Skip;

		const string input = "かbたかaな",
			expected = "katakana";

		var result = new StringBuilder(input)
			.ToRomaji(policy);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void AppendUnknownCharacters()
	{
		const UnrecognisedCharacterPolicy policy = UnrecognisedCharacterPolicy.Append;

		const string input = "片仮名あるいは平仮名が好き",
			expected = "片仮名aruiha平仮名ga好ki";

		var result = new StringBuilder(input)
			.ToRomaji(policy);

		result
			.Should()
			.Be(expected);
	}
}
