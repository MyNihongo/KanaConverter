namespace MyNihongo.KanaConverter.Tests.StringExKanaToKatakanaTests;

public sealed class KanaToKatakanaSokuonShould
{
	[Fact]
	public void ReturnCharsSokuon()
	{
		const string input = "っん",
			expected = "ッン";

		var result = input.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}
}
