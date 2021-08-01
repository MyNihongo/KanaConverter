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
		[InlineData("くぃくぇけぃ")]
		[InlineData("クィクェケィ")]
		public void ReturnCharsYouonSpecialK(string input)
		{
			const string expectedResult = "kikeki";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぐぃぐぇげぃ")]
		[InlineData("グィグェゲィ")]
		public void ReturnCharsYouonSpecialG(string input)
		{
			const string expectedResult = "gigegi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("すぃすぇせぃ")]
		[InlineData("スィスェセィ")]
		public void ReturnCharsYouonSpecialS(string input)
		{
			const string expectedResult = "sisesi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ずぃずぇぜぃ")]
		[InlineData("ズィズェゼィ")]
		public void ReturnCharsYouonSpecialZ(string input)
		{
			const string expectedResult = "zizezi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("つぃつぇてぃ")]
		[InlineData("ツィツェティ")]
		public void ReturnCharsYouonSpecialT(string input)
		{
			const string expectedResult = "tsitseti";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("づぃづぇでぃ")]
		[InlineData("ヅィヅェディ")]
		public void ReturnCharsYouonSpecialD(string input)
		{
			const string expectedResult = "zizedi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぬぃぬぇねぃ")]
		[InlineData("ヌィヌェネィ")]
		public void ReturnCharsYouonSpecialN(string input)
		{
			const string expectedResult = "nineni";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ふぃふぇへぃ")]
		[InlineData("フィフェヘィ")]
		public void ReturnCharsYouonSpecialH(string input)
		{
			const string expectedResult = "fifehi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぶぃぶぇべぃ")]
		[InlineData("ブィブェベィ")]
		public void ReturnCharsYouonSpecialB(string input)
		{
			const string expectedResult = "bibebi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぷぃぷぇぺぃ")]
		[InlineData("プィプェペィ")]
		public void ReturnCharsYouonSpecialP(string input)
		{
			const string expectedResult = "pipepi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("むぃむぇめぃ")]
		[InlineData("ムィムェメィ")]
		public void ReturnCharsYouonSpecialM(string input)
		{
			const string expectedResult = "mimemi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ゆぃゆぇ")]
		[InlineData("ユィユェ")]
		public void ReturnCharsYouonSpecialY(string input)
		{
			const string expectedResult = "yiye";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("るぃるぇれぃ")]
		[InlineData("ルィルェレィ")]
		public void ReturnCharsYouonSpecialR(string input)
		{
			const string expectedResult = "rireri";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}
	}
}
