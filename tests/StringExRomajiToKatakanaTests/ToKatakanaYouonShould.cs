namespace MyNihongo.KanaConverter.Tests.StringExRomajiToKatakanaTests;

public sealed class ToKatakanaYouonShould
{
	[Fact]
	public void ReturnCharsYouonK()
	{
		const string input = "kyakyikyukyekyo",
			expected = "キャキィキュキェキョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}
}
