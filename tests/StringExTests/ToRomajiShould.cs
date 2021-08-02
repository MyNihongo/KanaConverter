using FluentAssertions;
using Xunit;

namespace MyNihongo.KanaConverter.Tests.StringExTests
{
	public sealed class ToRomajiShould
	{
		[Theory]
		[InlineData(null)]
		[InlineData("")]
		public void ReturnEmptyIfNullOrEmpty(string input)
		{
			var result = input.ToRomaji();

			result
				.Should()
				.BeEmpty();
		}

		[Theory]
		[InlineData("あいうえおん")]
		[InlineData("アイウエオン")]
		public void ReturnChars(string input)
		{
			const string expectedResult = "aiueon";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ゔ")]
		[InlineData("ヴ")]
		public void ReturnCharsDakuten(string input)
		{
			const string expectedResult = "vu";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("かきくけこ")]
		[InlineData("カキクケコ")]
		public void ReturnCharsK(string input)
		{
			const string expectedResult = "kakikukeko";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("がぎぐげご")]
		[InlineData("ガギグゲゴ")]
		public void ReturnCharsG(string input)
		{
			const string expectedResult = "gagigugego";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("さしすせそ")]
		[InlineData("サシスセソ")]
		public void ReturnCharsS(string input)
		{
			const string expectedResult = "sashisuseso";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ざじずぜぞ")]
		[InlineData("ザジズゼゾ")]
		public void ReturnCharsZ(string input)
		{
			const string expectedResult = "zajizuzezo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("たちつてと")]
		[InlineData("タチツテト")]
		public void ReturnCharsT(string input)
		{
			const string expectedResult = "tachitsuteto";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("だぢづでど")]
		[InlineData("ダヂヅデド")]
		public void ReturnCharsD(string input)
		{
			const string expectedResult = "dajizudedo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("なにぬねの")]
		[InlineData("ナニヌネノ")]
		public void ReturnCharsN(string input)
		{
			const string expectedResult = "naninuneno";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("はひふへほ")]
		[InlineData("ハヒフヘホ")]
		public void ReturnCharsH(string input)
		{
			const string expectedResult = "hahifuheho";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ばびぶべぼ")]
		[InlineData("バビブベボ")]
		public void ReturnCharsB(string input)
		{
			const string expectedResult = "babibubebo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぱぴぷぺぽ")]
		[InlineData("パピプペポ")]
		public void ReturnCharsP(string input)
		{
			const string expectedResult = "papipupepo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("まみむめも")]
		[InlineData("マミムメモ")]
		public void ReturnCharsM(string input)
		{
			const string expectedResult = "mamimumemo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("やゆよ")]
		[InlineData("ヤユヨ")]
		public void ReturnCharsY(string input)
		{
			const string expectedResult = "yayuyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("らりるれろ")]
		[InlineData("ラリルレロ")]
		public void ReturnCharsR(string input)
		{
			const string expectedResult = "rarirurero";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("わを")]
		[InlineData("ワヲ")]
		public void ReturnCharsW(string input)
		{
			const string expectedResult = "wawo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}
	}
}
