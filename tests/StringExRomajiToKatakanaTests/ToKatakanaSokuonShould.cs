namespace MyNihongo.KanaConverter.Tests.StringExRomajiToKatakanaTests;

public sealed class ToKatakanaSokuonShould
{
	[Fact]
	public void ReturnCharsSokuonN()
	{
		const string input = "nn",
			expected = "ンン";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnKatakanaSokuonK()
	{
		const string input = "kkakkikkukkekkokkyakkyikkyukkyekkyo",
			expected = "ッカッキックッケッコッキャッキィッキュッキェッキョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnKatakanaSokuonG()
	{
		const string input = "ggaggigguggeggoggyaggyiggyuggyeggyo",
			expected = "ッガッギッグッゲッゴッギャッギィッギュッギェッギョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnKatakanaSokuonS()
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
	public void ReturnKatakanaSokuonZ(string input)
	{
		const string expected = "ッザッジッズッゼッゾッジャッジュッジェッジョ";

		var result = input.ToKatakana();

		result
			.Should()
			.Be(expected);
	}
}
