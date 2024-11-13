namespace MyNihongo.KanaConverter.Tests.KanaToKatakanaStringBuilderExTests;

public sealed class TryConvertKanaToKatakanaSokuonShould
{
	[Fact]
	public void ReturnCharsSokuon()
	{
		const string input = "っん",
			expected = "ッン";

		var result = new StringBuilder(input)
			.TryConvertKanaToKatakana(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}
}
