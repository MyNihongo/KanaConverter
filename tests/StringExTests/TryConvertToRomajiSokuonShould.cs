namespace MyNihongo.KanaConverter.Tests.StringExTests;

public sealed class TryConvertToRomajiSokuonShould
{
	[Theory]
	[InlineData("っあ")]
	[InlineData("っい")]
	[InlineData("っう")]
	[InlineData("っえ")]
	[InlineData("っお")]
	[InlineData("ッア")]
	[InlineData("ッイ")]
	[InlineData("ッウ")]
	[InlineData("ッエ")]
	[InlineData("ッオ")]
	public void ReturnFalseForSokuonWithVowels(string input)
	{
		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeFalse();

		valueResult
			.Should()
			.BeEmpty();
	}

	[Theory]
	[InlineData("っん")]
	[InlineData("ッン")]
	public void ReturnCharsSokuon(string input)
	{
		const string expected = "nn";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("っかっきっくっけっこっきゃっきぃっきゅっきぇっきょ")]
	[InlineData("ッカッキックッケッコッキャッキィッキュッキェッキョ")]
	public void ReturnCharsSokuonK(string input)
	{
		const string expected = "kkakkikkukkekkokkyakkyikkyukkyekkyo";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("っがっぎっぐっげっごっぎゃっぎぃっぎゅっぎぇっぎょ")]
	[InlineData("ッガッギッグッゲッゴッギャッギィッギュッギェッギョ")]
	public void ReturnCharsSokuonG(string input)
	{
		const string expected = "ggaggigguggeggoggyaggyiggyuggyeggyo";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("っさっしっすっせっそっしゃっしぃっしゅっしぇっしょ")]
	[InlineData("ッサッシッスッセッソッシャッシィッシュッシェッショ")]
	public void ReturnCharsSokuonS(string input)
	{
		const string expected = "ssasshissussessosshasshisshusshessho";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("っざっじっずっぜっぞっじゃっじぃっじゅっじぇっじょ")]
	[InlineData("ッザッジッズッゼッゾッジャッジィッジュッジェッジョ")]
	public void ReturnCharsSokuonZ(string input)
	{
		const string expected = "zzajjizzuzzezzojjajjijjujjejjo";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ったっちっつってっとっちゃっちぃっちゅっちぇっちょ")]
	[InlineData("ッタッチッツッテットッチャッチィッチュッチェッチョ")]
	public void ReturnCharsSokuonT(string input)
	{
		const string expected = "ttatchittsuttettotchatchitchutchetcho";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("っだっぢっづっでっど")]
	[InlineData("ッダッヂッヅッデッド")]
	public void ReturnCharsSokuonD(string input)
	{
		const string expected = "ddajjizzuddeddo";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("っなっにっぬっねっのっにゃっにぃっにゅっにぇっにょ")]
	[InlineData("ッナッニッヌッネッノッニャッニィッニュッニェッニョ")]
	public void ReturnCharsSokuonN(string input)
	{
		const string expected = "nnanninnunnennonnyannyinnyunnyennyo";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("っはっひっふっへっほっひゃっひぃっひゅっひぇっひょ")]
	[InlineData("ッハッヒッフッヘッホッヒャッヒィッヒュッヒェッヒョ")]
	public void ReturnCharsSokuonH(string input)
	{
		const string expected = "hhahhiffuhhehhohhyahhyihhyuhhyehhyo";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("っばっびっぶっべっぼっびゃっびぃっびゅっびぇっびょ")]
	[InlineData("ッバッビッブッベッボッビャッビィッビュッビェッビョ")]
	public void ReturnCharsSokuonB(string input)
	{
		const string expected = "bbabbibbubbebbobbyabbyibbyubbyebbyo";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("っぱっぴっぷっぺっぽっぴゃっぴぃっぴゅっぴぇっぴょ")]
	[InlineData("ッパッピップッペッポッピャッピィッピュッピェッピョ")]
	public void ReturnCharsSokuonP(string input)
	{
		const string expected = "ppappippuppeppoppyappyippyuppyeppyo";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("っまっみっむっめっもっみゃっみぃっみゅっみぇっみょ")]
	[InlineData("ッマッミッムッメッモッミャッミィッミュッミェッミョ")]
	public void ReturnCharsSokuonM(string input)
	{
		const string expected = "mmammimmummemmommyammyimmyummyemmyo";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("っやっゆっよ")]
	[InlineData("ッヤッユッヨ")]
	public void ReturnCharsSokuonY(string input)
	{
		const string expected = "yyayyuyyo";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("っらっりっるっれっろっりゃっりぃっりゅっりぇっりょ")]
	[InlineData("ッラッリッルッレッロッリャッリィッリュッリェッリョ")]
	public void ReturnCharsSokuonR(string input)
	{
		const string expected = "rrarrirrurrerrorryarryirryurryerryo";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("っわっを")]
	[InlineData("ッワッヲ")]
	public void ReturnCharsSokuonW(string input)
	{
		const string expected = "wwawwo";

		var result = input.TryConvertToRomaji(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}
}
