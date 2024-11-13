namespace MyNihongo.KanaConverter.Tests.KanaToKatakanaStringExTests;

public sealed class TryConvertKanaToKatakanaSokuonShould
{
	[Fact]
	public void ReturnCharsSokuon()
	{
		const string input = "っん",
			expected = "ッン";

		var result = input.TryConvertKanaToKatakana(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}
}
