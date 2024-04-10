namespace MyNihongo.KanaConverter.Tests.StringExKanaToHiraganaTests;

public sealed class KanaToHiraganaSokuonShould
{
	[Fact]
	public void ReturnCharsSokuon()
	{
		const string input = "ッン",
			expected = "っん";

		var result = input.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}
}
