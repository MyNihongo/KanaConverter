namespace MyNihongo.KanaConverter.Tests.StringExRomajiToKatakanaTests;

public sealed class ToKatakanaSokuonShould
{
	[Fact]
	public void ReturnCharsSokuonNSingle()
	{
		const string input = "nn",
			expected = "ンン";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsSokuonK()
	{
		const string input = "kkakkikkukkekkokkyakkyikkyukkyekkyo",
			expected = "ッカッキックッケッコッキャッキィッキュッキェッキョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsSokuonG()
	{
		const string input = "ggaggigguggeggoggyaggyiggyuggyeggyo",
			expected = "ッガッギッグッゲッゴッギャッギィッギュッギェッギョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsSokuonS()
	{
		const string input = "ssasshissussessosshyasshyisshyusshyesshyo",
			expected = "ッサッシッスッセッソッシャッシィッシュッシェッショ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("zzajjizzuzzezzojjajjujjejjo")]
	[InlineData("zzazzizzuzzezzojjajjujjejjo")]
	public void ReturnCharsSokuonZ(string input)
	{
		const string expected = "ッザッジッズッゼッゾッジャッジュッジェッジョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ttatchittsuttettotchatchitchutchetcho")]
	[InlineData("ccacchiccsucceccocchacchicchuccheccho")]
	public void ReturnCharsSokuonT(string input)
	{
		const string expected = "ッタッチッツッテットッチャッチッチュッチェッチョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsSokuonD()
	{
		const string input = "ddajjizzuddeddo",
			expected = "ッダッジッズッデッド";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsSokuonN()
	{
		const string input = "nnanninnunnennonnyannyinnyunnyennyo",
			expected = "ンナンニンヌンネンノンニャンニィンニュンニェンニョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("hhahhiffuhhehhohhyahhyihhyuhhyehhyo")]
	[InlineData("ffaffiffuffeffoffyaffyiffyuffyeffyo")]
	public void ReturnCharsSokuonH(string input)
	{
		const string expected = "ッハッヒッフッヘッホッヒャッヒィッヒュッヒェッヒョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsSokuonB()
	{
		const string input = "bbabbibbubbebbobbyabbyibbyubbyebbyo",
			expected = "ッバッビッブッベッボッビャッビィッビュッビェッビョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsSokuonP()
	{
		const string input = "ppappippuppeppoppyappyippyuppyeppyo",
			expected = "ッパッピップッペッポッピャッピィッピュッピェッピョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsSokuonM()
	{
		const string input = "mmammimmummemmommyammyimmyummyemmyo",
			expected = "ッマッミッムッメッモッミャッミィッミュッミェッミョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("rrarrirrurrerrorryarryirryurryerryo")]
	[InlineData("llallillullellollyallyillyullyellyo")]
	public void ReturnCharsSokuonR(string input)
	{
		const string expected = "ッラッリッルッレッロッリャッリィッリュッリェッリョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}
}
