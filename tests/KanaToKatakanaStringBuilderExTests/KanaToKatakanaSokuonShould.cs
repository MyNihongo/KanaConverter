namespace MyNihongo.KanaConverter.Tests.KanaToKatakanaStringBuilderExTests;

public sealed class KanaToKatakanaSokuonShould
{
	[Fact]
	public void ReturnCharsSokuon()
	{
		const string input = "っん",
			expected = "ッン";

		var result = new StringBuilder(input)
			.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}
}
