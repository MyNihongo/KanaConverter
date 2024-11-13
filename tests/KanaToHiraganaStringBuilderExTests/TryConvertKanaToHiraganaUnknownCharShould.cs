namespace MyNihongo.KanaConverter.Tests.KanaToHiraganaStringBuilderExTests;

public sealed class TryConvertKanaToHiraganaUnknownCharShould
{
	[Fact]
	public void ReturnFalseByDefault()
	{
		const string input = "ヒラガaナ";

		var result = new StringBuilder(input)
			.TryConvertKanaToHiragana(out var output);

		result
			.Should()
			.BeFalse();

		output
			.Should()
			.BeEmpty();
	}

	[Fact]
	public void ReturnTrueAndSkip()
	{
		const UnrecognisedCharacterPolicy policy = UnrecognisedCharacterPolicy.Skip;

		const string input = "ヒラガaナ",
			expected = "ひらがな";

		var result = new StringBuilder(input)
			.TryConvertKanaToHiragana(policy, out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnTrueAndAppend()
	{
		const UnrecognisedCharacterPolicy policy = UnrecognisedCharacterPolicy.Append;

		const string input = "ヒラガナが好キ",
			expected = "ひらがなが好き";

		var result = new StringBuilder(input)
			.TryConvertKanaToHiragana(policy, out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnFalseIfNoChangedAfterAppend()
	{
		const UnrecognisedCharacterPolicy policy = UnrecognisedCharacterPolicy.Append;
		const string input = "中野坂上";

		var result = new StringBuilder(input)
			.TryConvertKanaToHiragana(policy, out var output);

		result
			.Should()
			.BeFalse();

		output
			.Should()
			.Be(input);
	}
}
