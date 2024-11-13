namespace MyNihongo.KanaConverter.Tests.KanaToKatakanaStringExTests;

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
