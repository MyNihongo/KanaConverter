namespace MyNihongo.KanaConverter.Tests.KanaToKatakanaStringExTests;

public sealed class TryConvertKanaToKatakanaUnknownCharShould
{
	[Fact]
	public void ReturnFalseByDefault()
	{
		const string input = "かたかaな";

		var result = input.TryConvertKanaToKatakana(out var output);

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

		const string input = "かbたかaな",
			expected = "カタカナ";

		var result = input.TryConvertKanaToKatakana(policy, out var valueResult);

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

		const string input = "カタカナが好き",
			expected = "カタカナガ好キ";

		var result = input.TryConvertKanaToKatakana(policy, out var valueResult);

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
		
		var result = input.TryConvertKanaToKatakana(policy, out var output);

		result
			.Should()
			.BeFalse();

		output
			.Should()
			.Be(input);
	}
}
