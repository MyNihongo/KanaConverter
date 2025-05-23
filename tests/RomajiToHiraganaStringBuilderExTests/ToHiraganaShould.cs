﻿namespace MyNihongo.KanaConverter.Tests.RomajiToHiraganaStringBuilderExTests;

public sealed class ToHiraganaShould
{
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void ReturnEmptyIfNullOrEmpty(string input)
	{
		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.BeEmpty();
	}

	[Fact]
	public void ThrowExceptionIfInvalidChar()
	{
		const string input = "aiueonq";

		var func = () => new StringBuilder(input)
			.ToHiragana();

		func
			.Should()
			.ThrowExactly<InvalidCharacterException>();
	}

	[Fact]
	public void AppendUnknownChars()
	{
		const string input = "aiueonq",
			expected = "あいうえおんq";

		var result = new StringBuilder(input)
			.ToHiragana(UnrecognisedCharacterPolicy.Append);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void IgnoreUnknownChars()
	{
		const string input = "aiueonq",
			expected = "あいうえおん";

		var result = new StringBuilder(input)
			.ToHiragana(UnrecognisedCharacterPolicy.Skip);

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
			expected = "あいうえおん";

		var result = new StringBuilder(input).ToHiragana(stringBuilderPool: stringBuilderPool);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnChars()
	{
		const string input = "aiueon",
			expected = "あいうえおん";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsK()
	{
		const string input = "kakikukeko",
			expected = "かきくけこ";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsG()
	{
		const string input = "gagigugego",
			expected = "がぎぐげご";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsS()
	{
		const string input = "sashisuseso",
			expected = "さしすせそ";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("zajizuzezo")]
	[InlineData("zazizuzezo")]
	public void ReturnCharsZ(string input)
	{
		const string expected = "ざじずぜぞ";

		var result = new StringBuilder(input)
			.ToHiragana();

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
		const string expected = "たちつてと";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsD1()
	{
		const string input = "dajizudedo",
			expected = "だじずでど";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("dadidudedo")]
	[InlineData("dadidzudedo")]
	public void ReturnCharsD2(string input)
	{
		const string expected = "だぢづでど";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsN()
	{
		const string input = "naninuneno",
			expected = "なにぬねの";

		var result = new StringBuilder(input)
			.ToHiragana();

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
		const string expected = "はひふへほ";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsB()
	{
		const string input = "babibubebo",
			expected = "ばびぶべぼ";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsP()
	{
		const string input = "papipupepo",
			expected = "ぱぴぷぺぽ";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsM()
	{
		const string input = "mamimumemo",
			expected = "まみむめも";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsY()
	{
		const string input = "yayuyo",
			expected = "やゆよ";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("rarirurero")]
	[InlineData("lalilulelo")]
	public void ReturnCharsR(string input)
	{
		const string expected = "らりるれろ";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsW()
	{
		const string input = "wawiwewo",
			expected = "わゐゑを";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("kantan", "かんたん")]
	[InlineData("banana", "ばなな")]
	public void ReturnCharsWords(string input, string expected)
	{
		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}
}
