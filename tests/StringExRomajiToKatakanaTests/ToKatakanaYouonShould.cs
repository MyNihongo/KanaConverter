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

	[Fact]
	public void ReturnCharsYouonG()
	{
		const string input = "gyagyigyugyegyo",
			expected = "ギャギィギュギェギョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonS()
	{
		const string input = "shashishushesho",
			expected = "シャシシュシェショ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsYouonZ()
	{
		const string input = "jajijujejo",
			expected = "ジャジジュジェジョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}
}
