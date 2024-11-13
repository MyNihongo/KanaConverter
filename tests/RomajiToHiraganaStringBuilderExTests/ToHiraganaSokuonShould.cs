namespace MyNihongo.KanaConverter.Tests.RomajiToHiraganaStringBuilderExTests;

public sealed class ToHiraganaSokuonShould
{
	[Fact]
	public void ReturnCharsSokuonNSingle()
	{
		const string input = "nn",
			expected = "んん";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsSokuonK()
	{
		const string input = "kkakkikkukkekkokkyakkyikkyukkyekkyo",
			expected = "っかっきっくっけっこっきゃっきぃっきゅっきぇっきょ";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsSokuonG()
	{
		const string input = "ggaggigguggeggoggyaggyiggyuggyeggyo",
			expected = "っがっぎっぐっげっごっぎゃっぎぃっぎゅっぎぇっぎょ";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsSokuonS()
	{
		const string input = "ssasshissussessosshyasshyisshyusshyesshyo",
			expected = "っさっしっすっせっそっしゃっしぃっしゅっしぇっしょ";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("zzajjizzuzzezzojjajjujjejjo")]
	[InlineData("zzazzizzuzzezzojjajjujjejjo")]
	public void ReturnCharsSokuonZ(string input)
	{
		const string expected = "っざっじっずっぜっぞっじゃっじゅっじぇっじょ";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("ttatchittsuttettotchatchitchutchetcho")]
	[InlineData("ccacchiccsucceccocchacchicchuccheccho")]
	public void ReturnCharsSokuonT(string input)
	{
		const string expected = "ったっちっつってっとっちゃっちっちゅっちぇっちょ";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsSokuonD()
	{
		const string input = "ddajjizzuddeddo",
			expected = "っだっじっずっでっど";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsSokuonN()
	{
		const string input = "nnanninnunnennonnyannyinnyunnyennyo",
			expected = "んなんにんぬんねんのんにゃんにぃんにゅんにぇんにょ";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("hhahhiffuhhehhohhyahhyihhyuhhyehhyo")]
	[InlineData("ffaffiffuffeffoffyaffyiffyuffyeffyo")]
	public void ReturnCharsSokuonH(string input)
	{
		const string expected = "っはっひっふっへっほっひゃっひぃっひゅっひぇっひょ";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsSokuonB()
	{
		const string input = "bbabbibbubbebbobbyabbyibbyubbyebbyo",
			expected = "っばっびっぶっべっぼっびゃっびぃっびゅっびぇっびょ";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsSokuonP()
	{
		const string input = "ppappippuppeppoppyappyippyuppyeppyo",
			expected = "っぱっぴっぷっぺっぽっぴゃっぴぃっぴゅっぴぇっぴょ";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void ReturnCharsSokuonM()
	{
		const string input = "mmammimmummemmommyammyimmyummyemmyo",
			expected = "っまっみっむっめっもっみゃっみぃっみゅっみぇっみょ";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}

	[Theory]
	[InlineData("rrarrirrurrerrorryarryirryurryerryo")]
	[InlineData("llallillullellollyallyillyullyellyo")]
	public void ReturnCharsSokuonR(string input)
	{
		const string expected = "っらっりっるっれっろっりゃっりぃっりゅっりぇっりょ";

		var result = new StringBuilder(input)
			.ToHiragana();

		result
			.Should()
			.Be(expected);
	}
}
