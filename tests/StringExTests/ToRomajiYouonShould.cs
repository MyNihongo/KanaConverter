using FluentAssertions;
using Xunit;

namespace MyNihongo.KanaConverter.Tests.StringExTests
{
	public sealed class ToRomajiYouonShould
	{
		[Theory]
		[InlineData("きゃきゅきょ")]
		[InlineData("キャキュキョ")]
		public void ReturnCharsYouonK(string input)
		{
			const string expectedResult = "kyakyukyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぎゃぎゅぎょ")]
		[InlineData("ギャギュギョ")]
		public void ReturnCharsYouonG(string input)
		{
			const string expectedResult = "gyagyugyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("しゃしゅしょ")]
		[InlineData("シャシュショ")]
		public void ReturnCharsYouonS(string input)
		{
			const string expectedResult = "shashusho";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("じゃじゅジョ")]
		[InlineData("ジャジュジョ")]
		public void ReturnCharsYouonZ(string input)
		{
			const string expectedResult = "jajujo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ちゃちゅちょ")]
		[InlineData("チャチュチョ")]
		public void ReturnCharsYouonT(string input)
		{
			const string expectedResult = "chachucho";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("にゃにゅにょ")]
		[InlineData("ニャニュニョ")]
		public void ReturnCharsYouonＮ(string input)
		{
			const string expectedResult = "nyanyunyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ひゃひゅひょ")]
		[InlineData("ヒャヒュヒョ")]
		public void ReturnCharsYouonH(string input)
		{
			const string expectedResult = "hyahyuhyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("びゃびゅびょ")]
		[InlineData("ビャビュビョ")]
		public void ReturnCharsYouonB(string input)
		{
			const string expectedResult = "byabyubyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぴゃぴゅぴょ")]
		[InlineData("ピャピュピョ")]
		public void ReturnCharsYouonP(string input)
		{
			const string expectedResult = "pyapyupyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("みゃみゅみょ")]
		[InlineData("ミャミュミョ")]
		public void ReturnCharsYouonM(string input)
		{
			const string expectedResult = "myamyumyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("りゃりゅりょ")]
		[InlineData("リャリュリョ")]
		public void ReturnCharsYouonR(string input)
		{
			const string expectedResult = "ryaryuryo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}
	}
}
