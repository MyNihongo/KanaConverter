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
		[InlineData("きぃきぅきぇきゃきゅきょ")]
		[InlineData("キィキゥキェキャキュキョ")]
		public void ReturnCharsYouonK(string input)
		{
			const string expectedResult = "kyikyukyekyakyukyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぎぃぎぅぎぇぎゃぎゅぎょ")]
		[InlineData("ギィギゥギェギャギュギョ")]
		public void ReturnCharsYouonG(string input)
		{
			const string expectedResult = "gyigyugyegyagyugyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("しぃしぅしぇしゃしゅしょ")]
		[InlineData("シィシゥシェシャシュショ")]
		public void ReturnCharsYouonS(string input)
		{
			const string expectedResult = "shishusheshashusho";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("じぃじぅじぇじゃじゅジョ")]
		[InlineData("ジィジゥジェジャジュジョ")]
		public void ReturnCharsYouonZ(string input)
		{
			const string expectedResult = "jijujejajujo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ちぃちぅちぇちゃちゅちょ")]
		[InlineData("チィチゥチェチャチュチョ")]
		public void ReturnCharsYouonT(string input)
		{
			const string expectedResult = "chichuchechachucho";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("にぃにぅにぇにゃにゅにょ")]
		[InlineData("ニィニゥニェニャニュニョ")]
		public void ReturnCharsYouonＮ(string input)
		{
			const string expectedResult = "nyinyunyenyanyunyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ひぃひぅひぇひゃひゅひょ")]
		[InlineData("ヒィヒゥヒェヒャヒュヒョ")]
		public void ReturnCharsYouonH(string input)
		{
			const string expectedResult = "hyihyuhyehyahyuhyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("びぃびぅびぇびゃびゅびょ")]
		[InlineData("ビィビゥビェビャビュビョ")]
		public void ReturnCharsYouonB(string input)
		{
			const string expectedResult = "byibyubyebyabyubyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぴぃぴぅぴぇぴゃぴゅぴょ")]
		[InlineData("ピィピゥピェピャピュピョ")]
		public void ReturnCharsYouonP(string input)
		{
			const string expectedResult = "pyipyupyepyapyupyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("みぃみぅみぇみゃみゅみょ")]
		[InlineData("ミィミゥミェミャミュミョ")]
		public void ReturnCharsYouonM(string input)
		{
			const string expectedResult = "myimyumyemyamyumyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("りぃりぅりぇりゃりゅりょ")]
		[InlineData("リィリゥリェリャリュリョ")]
		public void ReturnCharsYouonR(string input)
		{
			const string expectedResult = "ryiryuryeryaryuryo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}
	}
}
