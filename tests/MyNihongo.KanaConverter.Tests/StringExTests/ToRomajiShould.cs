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
		[InlineData("あいうえお")]
		[InlineData("アイウエオ")]
		public void ReturnChars(string input)
		{
			const string expectedResult = "aiueo";

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

		[Theory]
		[InlineData("ん")]
		[InlineData("ン")]
		public void ReturnCharsSpecial(string input)
		{
			const string expectedResult = "n";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}
	}
}
