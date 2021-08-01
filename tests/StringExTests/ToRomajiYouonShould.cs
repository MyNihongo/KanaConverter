using System;
using FluentAssertions;
using MyNihongo.KanaConverter.Exceptions;
using Xunit;

namespace MyNihongo.KanaConverter.Tests.StringExTests
{
	public sealed class ToRomajiYouonShould
	{
		[Theory]
		[InlineData("ゃき")]
		[InlineData("ぃき")]
		[InlineData("ゅき")]
		[InlineData("ぇき")]
		[InlineData("ょき")]
		[InlineData("ャキ")]
		[InlineData("ィキ")]
		[InlineData("ュキ")]
		[InlineData("ェキ")]
		[InlineData("ョキ")]
		public void ThrowExceptionIfStartsWithYouon(string input)
		{
			Action action = () => input.ToRomaji();

			action
				.Should()
				.ThrowExactly<InvalidKanaException>();
		}

		[Theory]
		[InlineData("きゃきぃきゅきぇきょ")]
		[InlineData("キャキィキュキェキョ")]
		public void ReturnCharsYouonK(string input)
		{
			const string expectedResult = "kyakyikyukyekyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぎゃぎぃぎゅぎぇぎょ")]
		[InlineData("ギャギィギュギェギョ")]
		public void ReturnCharsYouonG(string input)
		{
			const string expectedResult = "gyagyigyugyegyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("しゃしぃしゅしぇしょ")]
		[InlineData("シャシィシュシェショ")]
		public void ReturnCharsYouonS(string input)
		{
			const string expectedResult = "shashishushesho";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("じゃじぃじゅじぇジョ")]
		[InlineData("ジャジィジュジェジョ")]
		public void ReturnCharsYouonZ(string input)
		{
			const string expectedResult = "jajijujejo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ちゃちぃちゅちぇちょ")]
		[InlineData("チャチィチュチェチョ")]
		public void ReturnCharsYouonT(string input)
		{
			const string expectedResult = "chachichuchecho";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("にゃにぃにゅにぇにょ")]
		[InlineData("ニャニィニュニェニョ")]
		public void ReturnCharsYouonＮ(string input)
		{
			const string expectedResult = "nyanyinyunyenyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ひゃひぃひゅひぇひょ")]
		[InlineData("ヒャヒィヒュヒェヒョ")]
		public void ReturnCharsYouonH(string input)
		{
			const string expectedResult = "hyahyihyuhyehyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("びゃびぃびゅびぇびょ")]
		[InlineData("ビャビィビュビェビョ")]
		public void ReturnCharsYouonB(string input)
		{
			const string expectedResult = "byabyibyubyebyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぴゃぴぃぴゅぴぇぴょ")]
		[InlineData("ピャピィピュピェピョ")]
		public void ReturnCharsYouonP(string input)
		{
			const string expectedResult = "pyapyipyupyepyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("みゃみぃみゅみぇみょ")]
		[InlineData("ミャミィミュミェミョ")]
		public void ReturnCharsYouonM(string input)
		{
			const string expectedResult = "myamyimyumyemyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("りゃりぃりゅりぇりょ")]
		[InlineData("リャリィリュリェリョ")]
		public void ReturnCharsYouonR(string input)
		{
			const string expectedResult = "ryaryiryuryeryo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}
	}
}
