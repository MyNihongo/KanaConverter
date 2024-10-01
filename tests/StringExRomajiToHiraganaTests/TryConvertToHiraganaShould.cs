namespace MyNihongo.KanaConverter.Tests.StringExRomajiToHiraganaTests;

public sealed class TryConvertToHiraganaShould
{
	[Fact]
	public void ReturnFalseIfUnknownChar()
	{
		const string input = "aiueonq";

		var result = input.TryConvertToHiragana(out var convertResult);

		result
			.Should()
			.BeFalse();

		convertResult
			.Should()
			.BeEmpty();
	}

	[Fact]
	public void ReturnTrueIfAppendUnknownChar()
	{
		const string input = "aiueonq",
			expected = "あいうえおんq";

		var result = input.TryConvertToHiragana(UnrecognisedCharacterPolicy.Append, out var convertResult);

		result
			.Should()
			.BeTrue();

		convertResult
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnFalseIfAllCharsUnknown()
	{
		const string input = "qx";

		var result = input.TryConvertToHiragana(UnrecognisedCharacterPolicy.Append, out var convertResult);

		result
			.Should()
			.BeFalse();

		convertResult
			.Should()
			.Be(input);
	}

	[Fact]
	public void ReturnTrueIfIgnoreUnknownChars()
	{
		const string input = "aiueonq",
			expected = "あいうえおん";

		var result = input.TryConvertToHiragana(UnrecognisedCharacterPolicy.Skip, out var convertResult);

		result
			.Should()
			.BeTrue();

		convertResult
			.Should()
			.Be(expected);
	}
}
