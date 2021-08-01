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
		[InlineData("くぁくぃくぇくぉけぃ")]
		[InlineData("クァクィクェクォケィ")]
		public void ReturnCharsYouonSpecialK(string input)
		{
			const string expectedResult = "kakikekoki";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぐぁぐぃぐぇぐぉげぃ")]
		[InlineData("グァグィグェグォゲィ")]
		public void ReturnCharsYouonSpecialG(string input)
		{
			const string expectedResult = "gagigegogi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("すぁすぃすぇすぉせぃ")]
		[InlineData("スァスィスェスォセィ")]
		public void ReturnCharsYouonSpecialS(string input)
		{
			const string expectedResult = "sasisesosi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ずぁずぃずぇずぉぜぃ")]
		[InlineData("ズァズィズェズォゼィ")]
		public void ReturnCharsYouonSpecialZ(string input)
		{
			const string expectedResult = "zazizezozi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("つぁつぃつぇつぉてぃ")]
		[InlineData("ツァツィツェツォティ")]
		public void ReturnCharsYouonSpecialT(string input)
		{
			const string expectedResult = "tsatsitsetsoti";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("づぁづぃづぇづぉでぃ")]
		[InlineData("ヅァヅィヅェヅォディ")]
		public void ReturnCharsYouonSpecialD(string input)
		{
			const string expectedResult = "zazizezodi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぬぁぬぃぬぇぬぉねぃ")]
		[InlineData("ヌァヌィヌェヌォネィ")]
		public void ReturnCharsYouonSpecialN(string input)
		{
			const string expectedResult = "naninenoni";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ふぁふぃふぇふぉへぃ")]
		[InlineData("ファフィフェフォヘィ")]
		public void ReturnCharsYouonSpecialH(string input)
		{
			const string expectedResult = "fafifefohi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぶぁぶぃぶぇぶぉべぃ")]
		[InlineData("ブァブィブェブォベィ")]
		public void ReturnCharsYouonSpecialB(string input)
		{
			const string expectedResult = "babibebobi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぷぁぷぃぷぇぷぉぺぃ")]
		[InlineData("プァプィプェプォペィ")]
		public void ReturnCharsYouonSpecialP(string input)
		{
			const string expectedResult = "papipepopi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("むぁむぃむぇむぉめぃ")]
		[InlineData("ムァムィムェムォメィ")]
		public void ReturnCharsYouonSpecialM(string input)
		{
			const string expectedResult = "mamimemomi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ゆぁゆぃゆぇゆぉ")]
		[InlineData("ユァユィユェユォ")]
		public void ReturnCharsYouonSpecialY(string input)
		{
			const string expectedResult = "yayiyeyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("るぁるぃるぇるぉれぃ")]
		[InlineData("ルァルィルェルォレィ")]
		public void ReturnCharsYouonSpecialR(string input)
		{
			const string expectedResult = "rarirerori";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}
	}
}
