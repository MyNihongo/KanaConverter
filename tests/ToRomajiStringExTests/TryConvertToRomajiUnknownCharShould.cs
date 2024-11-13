namespace MyNihongo.KanaConverter.Tests.ToRomajiStringExTests;

public sealed class TryConvertToRomajiUnknownCharShould
{
	[Fact]
	public void ReturnFalseByDefault()
	{
		const string input = "かたかaな";

		var result = input.TryConvertToRomaji(out var output);

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
		
		const string input = "かたかaな",
			expected = "katakana";

		var result = input.TryConvertToRomaji(policy, out var output);

		result
			.Should()
			.BeTrue();

		output
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnTrueAndAppend()
	{
		const UnrecognisedCharacterPolicy policy = UnrecognisedCharacterPolicy.Append;

		const string input = "片仮名あるいは平仮名が好き",
			expected = "片仮名aruiha平仮名ga好ki";
		
		var result = input.TryConvertToRomaji(policy, out var output);

		result
			.Should()
			.BeTrue();

		output
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnFalseIfNoChangedAfterAppend()
	{
		const UnrecognisedCharacterPolicy policy = UnrecognisedCharacterPolicy.Append;
		const string input = "中野坂上";
		
		var result = input.TryConvertToRomaji(policy, out var output);

		result
			.Should()
			.BeFalse();

		output
			.Should()
			.Be(input);
	}
}
