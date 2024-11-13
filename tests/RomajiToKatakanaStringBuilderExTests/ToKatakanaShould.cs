namespace MyNihongo.KanaConverter.Tests.RomajiToKatakanaStringBuilderExTests;

public sealed class ToKatakanaShould
{
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void ReturnEmptyIfNullOrEmpty(string input)
	{
		var result = new StringBuilder(input)
			.ToKatakana();

		result
			.Should()
			.BeEmpty();
	}

	[Fact]
	public void ThrowExceptionIfInvalidChar()
	{
		const string input = "aiueonq";

		var func = () => new StringBuilder(input)
			.ToKatakana();

		func
			.Should()
			.ThrowExactly<InvalidCharacterException>();
	}

	[Fact]
	public void AppendUnknownChars()
	{
		const string input = "aiueonq",
			expected = "アイウエオンq";

		var result = new StringBuilder(input)
			.ToKatakana(UnrecognisedCharacterPolicy.Append);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void IgnoreUnknownChars()
	{
		const string input = "aiueonq",
			expected = "アイウエオン";

		var result = new StringBuilder(input)
			.ToKatakana(UnrecognisedCharacterPolicy.Skip);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void UseStringBuilderPool()
	{
		var stringBuilderPool = new DefaultObjectPoolProvider()
			.CreateStringBuilderPool();

		const string input = "aiueon",
			expected = "アイウエオン";

		var result = new StringBuilder(input)
			.ToKatakana(stringBuilderPool: stringBuilderPool);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnChars()
	{
		const string input = "aiueon",
			expected = "アイウエオン";

		var result = new StringBuilder(input)
			.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsK()
	{
		const string input = "kakikukeko",
			expected = "カキクケコ";

		var result = new StringBuilder(input)
			.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsG()
	{
		const string input = "gagigugego",
			expected = "ガギグゲゴ";

		var result = new StringBuilder(input)
			.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsS()
	{
		const string input = "sashisuseso",
			expected = "サシスセソ";

		var result = new StringBuilder(input)
			.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("zajizuzezo")]
	[InlineData("zazizuzezo")]
	public void ReturnCharsZ(string input)
	{
		const string expected = "ザジズゼゾ";

		var result = new StringBuilder(input)
			.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("tachitsuteto")]
	[InlineData("tathitsuteto")]
	[InlineData("tacitsuteto")]
	[InlineData("tachituteto")]
	[InlineData("tachicuteto")]
	[InlineData("tachicsuteto")]
	public void ReturnCharsT(string input)
	{
		const string expected = "タチツテト";

		var result = new StringBuilder(input)
			.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsD1()
	{
		const string input = "dajizudedo",
			expected = "ダジズデド";

		var result = new StringBuilder(input)
			.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("dadidudedo")]
	[InlineData("dadidzudedo")]
	public void ReturnCharsD2(string input)
	{
		const string expected = "ダヂヅデド";

		var result = new StringBuilder(input)
			.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsN()
	{
		const string input = "naninuneno",
			expected = "ナニヌネノ";

		var result = new StringBuilder(input)
			.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("hahifuheho")]
	[InlineData("hahihuheho")]
	[InlineData("fafifufefo")]
	public void ReturnCharsH(string input)
	{
		const string expected = "ハヒフヘホ";

		var result = new StringBuilder(input)
			.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsB()
	{
		const string input = "babibubebo",
			expected = "バビブベボ";

		var result = new StringBuilder(input)
			.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsP()
	{
		const string input = "papipupepo",
			expected = "パピプペポ";

		var result = new StringBuilder(input)
			.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsM()
	{
		const string input = "mamimumemo",
			expected = "マミムメモ";

		var result = new StringBuilder(input)
			.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsY()
	{
		const string input = "yayuyo",
			expected = "ヤユヨ";

		var result = new StringBuilder(input)
			.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("rarirurero")]
	[InlineData("lalilulelo")]
	public void ReturnCharsR(string input)
	{
		const string expected = "ラリルレロ";

		var result = new StringBuilder(input)
			.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsW()
	{
		const string input = "wawiwewo",
			expected = "ワヰヱヲ";

		var result = new StringBuilder(input)
			.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("kantan", "カンタン")]
	[InlineData("banana", "バナナ")]
	public void ReturnCharsWords(string input, string expected)
	{
		var result = new StringBuilder(input)
			.ToKatakana();

		result
			.Should()
			.Be(expected);
	}
}
