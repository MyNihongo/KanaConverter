namespace MyNihongo.KanaConverter.Tests.StringExKanaToHiraganaTests;

public sealed class KanaToHiraganaShould
{
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void ReturnEmptyIfNullOrEmpty(string input)
	{
		var result = input.KanaToHiragana();

		result
			.Should()
			.BeEmpty();
	}

	[Fact]
	public void ReturnChars()
	{
		const string expected = "あいうえおん",
			input = "アイウエオン";

		var result = input.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsDakuten()
	{
		const string expected = "ゔ",
			input = "ヴ";

		var result = input.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsK()
	{
		const string expected = "かきくけこ",
			input = "カキクケコ";

		var result = input.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsG()
	{
		const string expected = "がぎぐげご",
			input = "ガギグゲゴ";

		var result = input.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsS()
	{
		const string expected = "さしすせそ",
			input = "サシスセソ";

		var result = input.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsZ()
	{
		const string expected = "ざじずぜぞ",
			input = "ザジズゼゾ";

		var result = input.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsT()
	{
		const string expected = "たちつてと",
			input = "タチツテト";

		var result = input.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsD()
	{
		const string expected = "だぢづでど",
			input = "ダヂヅデド";

		var result = input.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsN()
	{
		const string expected = "なにぬねの",
			input = "ナニヌネノ";

		var result = input.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsH()
	{
		const string expected = "はひふへほ",
			input = "ハヒフヘホ";

		var result = input.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsB()
	{
		const string expected = "ばびぶべぼ",
			input = "バビブベボ";

		var result = input.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsP()
	{
		const string expected = "ぱぴぷぺぽ",
			input = "パピプペポ";

		var result = input.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsM()
	{
		const string expected = "まみむめも",
			input = "マミムメモ";

		var result = input.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsY()
	{
		const string expected = "やゆよ",
			input = "ヤユヨ";

		var result = input.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsR()
	{
		const string expected = "らりるれろ",
			input = "ラリルレロ";

		var result = input.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsW()
	{
		const string expected = "わを",
			input = "ワヲ";

		var result = input.KanaToHiragana();

		result
			.Should()
			.Be(expected);
	}
}
