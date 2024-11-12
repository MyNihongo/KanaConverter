namespace MyNihongo.KanaConverter.Tests.KanaToHiraganaStringBuilderExTests;

public sealed class KanaToHiraganaSokuonShould
{
	[Fact]
	public void ReturnCharsSokuon()
	{
		const string input = "ッン",
			expected = "っん";

		var result = new StringBuilder(input)
			.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}
}
