using System;
using FluentAssertions;
using MyNihongo.KanaConverter.Exceptions;
using Xunit;
// ReSharper disable InconsistentNaming

namespace MyNihongo.KanaConverter.Tests.StringExTests
{
	public sealed class ToRomajiYouonSpecialShould
	{
		[Theory]
		[InlineData("あぃ")]
		[InlineData("おぃ")]
		[InlineData("かぃ")]
		[InlineData("こぃ")]
		[InlineData("がぃ")]
		[InlineData("ごぃ")]
		[InlineData("さぃ")]
		[InlineData("そぃ")]
		[InlineData("ざぃ")]
		[InlineData("ぞぃ")]
		[InlineData("たぃ")]
		[InlineData("とぃ")]
		[InlineData("だぃ")]
		[InlineData("どぃ")]
		[InlineData("なぃ")]
		[InlineData("のぃ")]
		[InlineData("はぃ")]
		[InlineData("ほぃ")]
		[InlineData("ばぃ")]
		[InlineData("ぼぃ")]
		[InlineData("ぱぃ")]
		[InlineData("ぽぃ")]
		[InlineData("まぃ")]
		[InlineData("もぃ")]
		[InlineData("らぃ")]
		[InlineData("ろぃ")]
		[InlineData("アィ")]
		[InlineData("オィ")]
		[InlineData("カィ")]
		[InlineData("コィ")]
		[InlineData("ガィ")]
		[InlineData("ゴィ")]
		[InlineData("サィ")]
		[InlineData("ソィ")]
		[InlineData("ザィ")]
		[InlineData("ゾィ")]
		[InlineData("タィ")]
		[InlineData("トィ")]
		[InlineData("ダィ")]
		[InlineData("ドィ")]
		[InlineData("ナィ")]
		[InlineData("ノィ")]
		[InlineData("ハィ")]
		[InlineData("ホィ")]
		[InlineData("バィ")]
		[InlineData("ボィ")]
		[InlineData("パィ")]
		[InlineData("ポィ")]
		[InlineData("マィ")]
		[InlineData("モィ")]
		[InlineData("ラィ")]
		[InlineData("ロィ")]
		public void ThrowExceptionIfNotEndsWithIU(string input)
		{
			Action action = () => input.ToRomaji();

			action
				.Should()
				.ThrowExactly<InvalidKanaException>();
		}

		[Theory]
		[InlineData("うぃうぇ")]
		[InlineData("ウィウェ")]
		public void ReturnCharsYouonSpecial(string input)
		{
			const string expectedResult = "wiwe";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("くぁくぃくぇけぃ")]
		[InlineData("クァクィクェケィ")]
		public void ReturnCharsYouonSpecialK(string input)
		{
			const string expectedResult = "kakikeki";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぐぁぐぃぐぇげぃ")]
		[InlineData("グァグィグェゲィ")]
		public void ReturnCharsYouonSpecialG(string input)
		{
			const string expectedResult = "gagigegi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("すぁすぃすぇせぃ")]
		[InlineData("スァスィスェセィ")]
		public void ReturnCharsYouonSpecialS(string input)
		{
			const string expectedResult = "sasisesi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ずぁずぃずぇぜぃ")]
		[InlineData("ズァズィズェゼィ")]
		public void ReturnCharsYouonSpecialZ(string input)
		{
			const string expectedResult = "zazizezi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("つぁつぃつぇてぃ")]
		[InlineData("ツァツィツェティ")]
		public void ReturnCharsYouonSpecialT(string input)
		{
			const string expectedResult = "tsatsitseti";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("づぁづぃづぇでぃ")]
		[InlineData("ヅァヅィヅェディ")]
		public void ReturnCharsYouonSpecialD(string input)
		{
			const string expectedResult = "zazizedi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぬぁぬぃぬぇねぃ")]
		[InlineData("ヌァヌィヌェネィ")]
		public void ReturnCharsYouonSpecialN(string input)
		{
			const string expectedResult = "nanineni";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ふぁふぃふぇへぃ")]
		[InlineData("ファフィフェヘィ")]
		public void ReturnCharsYouonSpecialH(string input)
		{
			const string expectedResult = "fafifehi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぶぁぶぃぶぇべぃ")]
		[InlineData("ブァブィブェベィ")]
		public void ReturnCharsYouonSpecialB(string input)
		{
			const string expectedResult = "babibebi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぷぁぷぃぷぇぺぃ")]
		[InlineData("プァプィプェペィ")]
		public void ReturnCharsYouonSpecialP(string input)
		{
			const string expectedResult = "papipepi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("むぁむぃむぇめぃ")]
		[InlineData("ムァムィムェメィ")]
		public void ReturnCharsYouonSpecialM(string input)
		{
			const string expectedResult = "mamimemi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ゆぁゆぃゆぇ")]
		[InlineData("ユァユィユェ")]
		public void ReturnCharsYouonSpecialY(string input)
		{
			const string expectedResult = "yayiye";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("るぁるぃるぇれぃ")]
		[InlineData("ルァルィルェレィ")]
		public void ReturnCharsYouonSpecialR(string input)
		{
			const string expectedResult = "rarireri";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}
	}
}
