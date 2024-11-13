namespace MyNihongo.KanaConverter.Tests.KanaToKatakanaStringBuilderExTests;

public sealed class KanaToKatakanaShould
{
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void ReturnEmptyIfNullOrEmpty(string input)
	{
		var result = new StringBuilder(input)
			.KanaToKatakana();

		result
			.Should()
			.BeEmpty();
	}

	[Fact]
	public void ReturnChars()
	{
		const string input = "あいうえおん",
			expected = "アイウエオン";

		var result = new StringBuilder(input)
			.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsDakuten()
	{
		const string input = "ゔ",
			expected = "ヴ";

		var result = new StringBuilder(input)
			.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsK()
	{
		const string input = "かきくけこ",
			expected = "カキクケコ";

		var result = new StringBuilder(input)
			.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsG()
	{
		const string input = "がぎぐげご",
			expected = "ガギグゲゴ";

		var result = new StringBuilder(input)
			.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsS()
	{
		const string input = "さしすせそ",
			expected = "サシスセソ";

		var result = new StringBuilder(input)
			.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsZ()
	{
		const string input = "ざじずぜぞ",
			expected = "ザジズゼゾ";

		var result = new StringBuilder(input)
			.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsT()
	{
		const string input = "たちつてと",
			expected = "タチツテト";

		var result = new StringBuilder(input)
			.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsD()
	{
		const string input = "だぢづでど",
			expected = "ダヂヅデド";

		var result = new StringBuilder(input)
			.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsN()
	{
		const string input = "なにぬねの",
			expected = "ナニヌネノ";

		var result = new StringBuilder(input)
			.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsH()
	{
		const string input = "はひふへほ",
			expected = "ハヒフヘホ";

		var result = new StringBuilder(input)
			.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsB()
	{
		const string input = "ばびぶべぼ",
			expected = "バビブベボ";

		var result = new StringBuilder(input)
			.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsP()
	{
		const string input = "ぱぴぷぺぽ",
			expected = "パピプペポ";

		var result = new StringBuilder(input)
			.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsM()
	{
		const string input = "まみむめも",
			expected = "マミムメモ";

		var result = new StringBuilder(input)
			.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsY()
	{
		const string input = "やゆよ",
			expected = "ヤユヨ";

		var result = new StringBuilder(input)
			.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsR()
	{
		const string input = "らりるれろ",
			expected = "ラリルレロ";

		var result = new StringBuilder(input)
			.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsW()
	{
		const string input = "わを",
			expected = "ワヲ";

		var result = new StringBuilder(input)
			.KanaToKatakana();

		result
			.Should()
			.Be(expected);
	}
}
