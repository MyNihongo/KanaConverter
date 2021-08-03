using FluentAssertions;
using Xunit;

namespace MyNihongo.KanaConverter.Tests.StringExTests
{
	public sealed class ToRomajiYouonSpecialShould
	{
		[Theory]
		[InlineData("いぇ")]
		[InlineData("イェ")]
		public void ReturnCharsYouonI(string input)
		{
			const string expectedResult = "ye";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("うぃうぇ")]
		[InlineData("ウィウェ")]
		public void ReturnCharsYouonU(string input)
		{
			const string expectedResult = "wiwe";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ゔぁゔゅ")]
		[InlineData("ヴァヴュ")]
		public void ReturnCharsYouonV(string input)
		{
			const string expectedResult = "vavyu";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("くぁくぃくぅくぇくぉくゎけぃ")]
		[InlineData("クァクィクゥクェクォクヮケィ")]
		public void ReturnCharsYouonSpecialK(string input)
		{
			const string expectedResult = "kakikukekokwaki";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぐぁぐぃぐぅぐぇぐぉぐゎげぃ")]
		[InlineData("グァグィグゥグェグォグヮゲィ")]
		public void ReturnCharsYouonSpecialG(string input)
		{
			const string expectedResult = "gagigugegogwagi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("すぁすぃすぅすぇすぉすゎせぃ")]
		[InlineData("スァスィスゥスェスォスヮセィ")]
		public void ReturnCharsYouonSpecialS(string input)
		{
			const string expectedResult = "sasisusesoswasi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ずぁずぃずぅずぇずぉずゎぜぃ")]
		[InlineData("ズァズィズゥズェズォズヮゼィ")]
		public void ReturnCharsYouonSpecialZ(string input)
		{
			const string expectedResult = "zazizuzezozwazi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("つぁつぃつぅつぇつぉつゎてぃてゅ")]
		[InlineData("ツァツィツゥツェツォツヮティテュ")]
		public void ReturnCharsYouonSpecialT(string input)
		{
			const string expectedResult = "tsatsitsutsetsotswatityu";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("づぁづぃづぅづぇづぉづゎでぃでゅどぅ")]
		[InlineData("ヅァヅィヅゥヅェヅォヅヮディデュドゥ")]
		public void ReturnCharsYouonSpecialD(string input)
		{
			const string expectedResult = "zazizuzezozwadidyudu";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぬぁぬぃぬぅぬぇぬぉぬゎねぃ")]
		[InlineData("ヌァヌィヌゥヌェヌォヌヮネィ")]
		public void ReturnCharsYouonSpecialN(string input)
		{
			const string expectedResult = "naninunenonwani";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ふぁふぃふぅふぇふぉふゎふゅへぃ")]
		[InlineData("ファフィフゥフェフォフヮフュヘィ")]
		public void ReturnCharsYouonSpecialH(string input)
		{
			const string expectedResult = "fafifufefofwafyuhi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぶぁぶぃぶぅぶぇぶぉぶゎべぃ")]
		[InlineData("ブァブィブゥブェブォブヮベィ")]
		public void ReturnCharsYouonSpecialB(string input)
		{
			const string expectedResult = "babibubebobwabi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぷぁぷぃぷぅぷぇぷぉぷゎぺぃ")]
		[InlineData("プァプィプゥプェプォプヮペィ")]
		public void ReturnCharsYouonSpecialP(string input)
		{
			const string expectedResult = "papipupepopwapi";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("むぁむぃむぅむぇむぉむゎめぃ")]
		[InlineData("ムァムィムゥムェムォムヮメィ")]
		public void ReturnCharsYouonSpecialM(string input)
		{
			const string expectedResult = "mamimumemomwami";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ゆぁゆぃゆぅゆぇゆぉゆゎ")]
		[InlineData("ユァユィユゥユェユォユヮ")]
		public void ReturnCharsYouonSpecialY(string input)
		{
			const string expectedResult = "yayiyuyeyoywa";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("るぁるぃるぅるぇるぉるゎれぃ")]
		[InlineData("ルァルィルゥルェルォルヮレィ")]
		public void ReturnCharsYouonSpecialR(string input)
		{
			const string expectedResult = "rarirurerorwari";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("わぁ")]
		[InlineData("ワァ")]
		public void ReturnCharsYouonSpecialW(string input)
		{
			const string expectedResult = "wa";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}
	}
}
