namespace MyNihongo.KanaConverter.Tests.StringExRomajiToKatakanaTests;

public sealed class ToKatakanaYouonShould
{
	[Fact]
	public void ReturnCharsYouonK()
	{
		const string input = "kyikyukyekyakyukyo",
			expected = "キィキゥキェキャキュキョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}
}
