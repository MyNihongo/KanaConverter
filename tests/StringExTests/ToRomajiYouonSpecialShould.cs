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
		[InlineData("くぁくぃくぅくぇくぉけぃ")]
		[InlineData("クァクィクゥクェクォケィ")]
		public void ReturnCharsYouonSpecialK(string input)
		{
			const string expectedResult = "kakikukekoki";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぐぁぐぃぐぅぐぇぐぉげぃ")]
		[InlineData("グァグィグゥグェグォゲィ")]
		public void ReturnCharsYouonSpecialG(string input)
		{
			const string expectedResult = "gagigugegogi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("すぁすぃすぅすぇすぉせぃ")]
		[InlineData("スァスィスゥスェスォセィ")]
		public void ReturnCharsYouonSpecialS(string input)
		{
			const string expectedResult = "sasisusesosi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ずぁずぃずぅずぇずぉぜぃ")]
		[InlineData("ズァズィズゥズェズォゼィ")]
		public void ReturnCharsYouonSpecialZ(string input)
		{
			const string expectedResult = "zazizuzezozi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("つぁつぃつぅつぇつぉてぃ")]
		[InlineData("ツァツィツゥツェツォティ")]
		public void ReturnCharsYouonSpecialT(string input)
		{
			const string expectedResult = "tsatsitsutsetsoti";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("づぁづぃづぅづぇづぉでぃでゅ")]
		[InlineData("ヅァヅィヅゥヅェヅォディデュ")]
		public void ReturnCharsYouonSpecialD(string input)
		{
			const string expectedResult = "zazizuzezodidyu";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぬぁぬぃぬぅぬぇぬぉねぃ")]
		[InlineData("ヌァヌィヌゥヌェヌォネィ")]
		public void ReturnCharsYouonSpecialN(string input)
		{
			const string expectedResult = "naninunenoni";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ふぁふぃふぅふぇふぉへぃ")]
		[InlineData("ファフィフゥフェフォヘィ")]
		public void ReturnCharsYouonSpecialH(string input)
		{
			const string expectedResult = "fafifufefohi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぶぁぶぃぶぅぶぇぶぉべぃ")]
		[InlineData("ブァブィブゥブェブォベィ")]
		public void ReturnCharsYouonSpecialB(string input)
		{
			const string expectedResult = "babibubebobi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぷぁぷぃぷぅぷぇぷぉぺぃ")]
		[InlineData("プァプィプゥプェプォペィ")]
		public void ReturnCharsYouonSpecialP(string input)
		{
			const string expectedResult = "papipupepopi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("むぁむぃむぅむぇむぉめぃ")]
		[InlineData("ムァムィムゥムェムォメィ")]
		public void ReturnCharsYouonSpecialM(string input)
		{
			const string expectedResult = "mamimumemomi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ゆぁゆぃゆぅゆぇゆぉ")]
		[InlineData("ユァユィユゥユェユォ")]
		public void ReturnCharsYouonSpecialY(string input)
		{
			const string expectedResult = "yayiyuyeyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("るぁるぃるぅるぇるぉれぃ")]
		[InlineData("ルァルィルゥルェルォレィ")]
		public void ReturnCharsYouonSpecialR(string input)
		{
			const string expectedResult = "rarirurerori";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}
	}
}
