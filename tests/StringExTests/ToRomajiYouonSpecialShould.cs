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
		[InlineData("えぃ")]
		[InlineData("おぃ")]
		[InlineData("かぃ")]
		[InlineData("けぃ")]
		[InlineData("こぃ")]
		[InlineData("がぃ")]
		[InlineData("げぃ")]
		[InlineData("ごぃ")]
		[InlineData("さぃ")]
		[InlineData("せぃ")]
		[InlineData("そぃ")]
		[InlineData("ざぃ")]
		[InlineData("ぜぃ")]
		[InlineData("ぞぃ")]
		[InlineData("たぃ")]
		[InlineData("てぃ")]
		[InlineData("とぃ")]
		[InlineData("だぃ")]
		[InlineData("でぃ")]
		[InlineData("どぃ")]
		[InlineData("なぃ")]
		[InlineData("ねぃ")]
		[InlineData("のぃ")]
		[InlineData("はぃ")]
		[InlineData("へぃ")]
		[InlineData("ほぃ")]
		[InlineData("ばぃ")]
		[InlineData("べぃ")]
		[InlineData("ぼぃ")]
		[InlineData("ぱぃ")]
		[InlineData("ぺぃ")]
		[InlineData("ぽぃ")]
		[InlineData("まぃ")]
		[InlineData("めぃ")]
		[InlineData("もぃ")]
		[InlineData("らぃ")]
		[InlineData("れぃ")]
		[InlineData("ろぃ")]
		[InlineData("アィ")]
		[InlineData("エィ")]
		[InlineData("オィ")]
		[InlineData("カィ")]
		[InlineData("ケィ")]
		[InlineData("コィ")]
		[InlineData("ガィ")]
		[InlineData("ゲィ")]
		[InlineData("ゴィ")]
		[InlineData("サィ")]
		[InlineData("セィ")]
		[InlineData("ソィ")]
		[InlineData("ザィ")]
		[InlineData("ゼィ")]
		[InlineData("ゾィ")]
		[InlineData("タィ")]
		[InlineData("ティ")]
		[InlineData("トィ")]
		[InlineData("ダィ")]
		[InlineData("ディ")]
		[InlineData("ドィ")]
		[InlineData("ナィ")]
		[InlineData("ネィ")]
		[InlineData("ノィ")]
		[InlineData("ハィ")]
		[InlineData("ヘィ")]
		[InlineData("ホィ")]
		[InlineData("バィ")]
		[InlineData("ベィ")]
		[InlineData("ボィ")]
		[InlineData("パィ")]
		[InlineData("ポィ")]
		[InlineData("マィ")]
		[InlineData("メィ")]
		[InlineData("モィ")]
		[InlineData("ラィ")]
		[InlineData("レィ")]
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
		[InlineData("くぃくぇ")]
		[InlineData("クィクェ")]
		public void ReturnCharsYouonSpecialK(string input)
		{
			const string expectedResult = "kike";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぐぃぐぇ")]
		[InlineData("グィグェ")]
		public void ReturnCharsYouonSpecialG(string input)
		{
			const string expectedResult = "gige";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("すぃすぇ")]
		[InlineData("スィスェ")]
		public void ReturnCharsYouonSpecialS(string input)
		{
			const string expectedResult = "sise";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ずぃずぇ")]
		[InlineData("ズィズェ")]
		public void ReturnCharsYouonSpecialZ(string input)
		{
			const string expectedResult = "zize";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}
	}
}
