namespace MyNihongo.KanaConverter.Tests.StringExKanaToKatakanaTests;

public sealed class KanaToKatakanaShould
{
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void ReturnEmptyIfNullOrEmpty(string input)
	{
		var result = input.KanaToKatakana();

		result
			.Should()
			.BeEmpty();
	}
	
	[Fact]
	public void ReturnChars()
	{
		const string input = "あいうえおん",
			expected = "アイウエオン";

		var result = input.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}
	
	[Fact]
	public void ReturnCharsDakuten()
	{
		const string input = "ゔ",
			expected = "ヴ";

		var result = input.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}
	
	[Fact]
	public void ReturnCharsK()
	{
		const string input = "かきくけこ",
			expected = "カキクケコ";

		var result = input.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}
	
	[Fact]
	public void ReturnCharsS()
	{
		const string input = "さしすせそ",
			expected = "サシスセソ";

		var result = input.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}
	
	[Fact]
	public void ReturnCharsZ()
	{
		const string input = "ざじずぜぞ",
			expected = "ザジズゼゾ";

		var result = input.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}
}
