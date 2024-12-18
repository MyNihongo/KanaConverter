﻿namespace MyNihongo.KanaConverter.Tests.ToRomajiStringBuilderExTests;

public sealed class TryConvertToRomajiShould
{
	[Theory]
	[InlineData(null)]
	[InlineData("")]
	public void ReturnEmptyIfNullOrEmpty(string input)
	{
		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.BeEmpty();
	}

	[Theory]
	[InlineData("あいうえおん")]
	[InlineData("アイウエオン")]
	public void ReturnChars(string input)
	{
		const string expected = "aiueon";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ゔ")]
	[InlineData("ヴ")]
	public void ReturnCharsDakuten(string input)
	{
		const string expected = "vu";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("かきくけこ")]
	[InlineData("カキクケコ")]
	public void ReturnCharsK(string input)
	{
		const string expected = "kakikukeko";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("がぎぐげご")]
	[InlineData("ガギグゲゴ")]
	public void ReturnCharsG(string input)
	{
		const string expected = "gagigugego";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("さしすせそ")]
	[InlineData("サシスセソ")]
	public void ReturnCharsS(string input)
	{
		const string expected = "sashisuseso";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ざじずぜぞ")]
	[InlineData("ザジズゼゾ")]
	public void ReturnCharsZ(string input)
	{
		const string expected = "zajizuzezo";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("たちつてと")]
	[InlineData("タチツテト")]
	public void ReturnCharsT(string input)
	{
		const string expected = "tachitsuteto";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("だぢづでど")]
	[InlineData("ダヂヅデド")]
	public void ReturnCharsD(string input)
	{
		const string expected = "dajizudedo";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("なにぬねの")]
	[InlineData("ナニヌネノ")]
	public void ReturnCharsN(string input)
	{
		const string expected = "naninuneno";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("はひふへほ")]
	[InlineData("ハヒフヘホ")]
	public void ReturnCharsH(string input)
	{
		const string expected = "hahifuheho";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ばびぶべぼ")]
	[InlineData("バビブベボ")]
	public void ReturnCharsB(string input)
	{
		const string expected = "babibubebo";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ぱぴぷぺぽ")]
	[InlineData("パピプペポ")]
	public void ReturnCharsP(string input)
	{
		const string expected = "papipupepo";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("まみむめも")]
	[InlineData("マミムメモ")]
	public void ReturnCharsM(string input)
	{
		const string expected = "mamimumemo";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("やゆよ")]
	[InlineData("ヤユヨ")]
	public void ReturnCharsY(string input)
	{
		const string expected = "yayuyo";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("らりるれろ")]
	[InlineData("ラリルレロ")]
	public void ReturnCharsR(string input)
	{
		const string expected = "rarirurero";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("わを")]
	[InlineData("ワヲ")]
	public void ReturnCharsW(string input)
	{
		const string expected = "wawo";

		var result = new StringBuilder(input)
			.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}
}
