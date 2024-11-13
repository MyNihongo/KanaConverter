namespace MyNihongo.KanaConverter.Tests.KanaToHiraganaStringBuilderExTests;

public sealed class TryConvertKanaToHiraganaSokuonShould
{
	[Fact]
	public void ReturnCharsSokuon()
	{
		const string input = "ッン",
			expected = "っん";

		var result = new StringBuilder(input)
			.TryConvertKanaToHiragana(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}
}
