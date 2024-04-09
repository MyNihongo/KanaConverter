namespace MyNihongo.KanaConverter.Tests.StringExTests;

public sealed class TryConvertToRomajiYouonSpecialShould
{
	[Theory]
	[InlineData("いぇ")]
	[InlineData("イェ")]
	public void ReturnCharsYouonI(string input)
	{
		const string expected = "ye";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("うぃうぇ")]
	[InlineData("ウィウェ")]
	public void ReturnCharsYouonU(string input)
	{
		const string expected = "wiwe";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ゔぁゔゅ")]
	[InlineData("ヴァヴュ")]
	public void ReturnCharsYouonV(string input)
	{
		const string expected = "vavyu";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("くぁくぃくぅくぇくぉくゎけぃ")]
	[InlineData("クァクィクゥクェクォクヮケィ")]
	public void ReturnCharsYouonSpecialK(string input)
	{
		const string expected = "kakikukekokwaki";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ぐぁぐぃぐぅぐぇぐぉぐゎげぃ")]
	[InlineData("グァグィグゥグェグォグヮゲィ")]
	public void ReturnCharsYouonSpecialG(string input)
	{
		const string expected = "gagigugegogwagi";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("すぁすぃすぅすぇすぉすゎせぃ")]
	[InlineData("スァスィスゥスェスォスヮセィ")]
	public void ReturnCharsYouonSpecialS(string input)
	{
		const string expected = "sasisusesoswasi";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ずぁずぃずぅずぇずぉずゎぜぃ")]
	[InlineData("ズァズィズゥズェズォズヮゼィ")]
	public void ReturnCharsYouonSpecialZ(string input)
	{
		const string expected = "zazizuzezozwazi";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("つぁつぃつぅつぇつぉつゎてぃてゅ")]
	[InlineData("ツァツィツゥツェツォツヮティテュ")]
	public void ReturnCharsYouonSpecialT(string input)
	{
		const string expected = "tsatsitsutsetsotswatityu";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("づぁづぃづぅづぇづぉづゎでぃでゅどぅ")]
	[InlineData("ヅァヅィヅゥヅェヅォヅヮディデュドゥ")]
	public void ReturnCharsYouonSpecialD(string input)
	{
		const string expected = "zazizuzezozwadidyudu";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ぬぁぬぃぬぅぬぇぬぉぬゎねぃ")]
	[InlineData("ヌァヌィヌゥヌェヌォヌヮネィ")]
	public void ReturnCharsYouonSpecialN(string input)
	{
		const string expected = "naninunenonwani";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ふぁふぃふぅふぇふぉふゎふゅへぃ")]
	[InlineData("ファフィフゥフェフォフヮフュヘィ")]
	public void ReturnCharsYouonSpecialH(string input)
	{
		const string expected = "fafifufefofwafyuhi";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ぶぁぶぃぶぅぶぇぶぉぶゎべぃ")]
	[InlineData("ブァブィブゥブェブォブヮベィ")]
	public void ReturnCharsYouonSpecialB(string input)
	{
		const string expected = "babibubebobwabi";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ぷぁぷぃぷぅぷぇぷぉぷゎぺぃ")]
	[InlineData("プァプィプゥプェプォプヮペィ")]
	public void ReturnCharsYouonSpecialP(string input)
	{
		const string expected = "papipupepopwapi";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("むぁむぃむぅむぇむぉむゎめぃ")]
	[InlineData("ムァムィムゥムェムォムヮメィ")]
	public void ReturnCharsYouonSpecialM(string input)
	{
		const string expected = "mamimumemomwami";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ゆぁゆぃゆぅゆぇゆぉゆゎ")]
	[InlineData("ユァユィユゥユェユォユヮ")]
	public void ReturnCharsYouonSpecialY(string input)
	{
		const string expected = "yayiyuyeyoywa";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("るぁるぃるぅるぇるぉるゎれぃ")]
	[InlineData("ルァルィルゥルェルォルヮレィ")]
	public void ReturnCharsYouonSpecialR(string input)
	{
		const string expected = "rarirurerorwari";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("わぁ")]
	[InlineData("ワァ")]
	public void ReturnCharsYouonSpecialW(string input)
	{
		const string expected = "wa";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}
}
