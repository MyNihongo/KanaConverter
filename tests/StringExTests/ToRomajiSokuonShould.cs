using System;
using FluentAssertions;
using MyNihongo.KanaConverter.Exceptions;
using Xunit;

namespace MyNihongo.KanaConverter.Tests.StringExTests
{
	public sealed class ToRomajiSokuonShould
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
		public void ThrowExceptionForSokuonWithVowels(string input)
		{
			Action action = () => input.ToRomaji();

			action
				.Should()
				.ThrowExactly<InvalidKanaException>();
		}

		[Theory]
		[InlineData("っん")]
		[InlineData("ッン")]
		public void ReturnCharsSokuon(string input)
		{
			const string expectedResult = "nn";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っかっきっくっけっこっきゃっきぃっきゅっきぇっきょ")]
		[InlineData("ッカッキックッケッコッキャッキィッキュッキェッキョ")]
		public void ReturnCharsSokuonK(string input)
		{
			const string expectedResult = "kkakkikkukkekkokkyakkyikkyukkyekkyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っがっぎっぐっげっごっぎゃっぎぃっぎゅっぎぇっぎょ")]
		[InlineData("ッガッギッグッゲッゴッギャッギィッギュッギェッギョ")]
		public void ReturnCharsSokuonG(string input)
		{
			const string expectedResult = "ggaggigguggeggoggyaggyiggyuggyeggyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っさっしっすっせっそっしゃっしぃっしゅっしぇっしょ")]
		[InlineData("ッサッシッスッセッソッシャッシィッシュッシェッショ")]
		public void ReturnCharsSokuonS(string input)
		{
			const string expectedResult = "ssasshissussessosshasshisshusshessho";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っざっじっずっぜっぞっじゃっじぃっじゅっじぇっじょ")]
		[InlineData("ッザッジッズッゼッゾッジャッジィッジュッジェッジョ")]
		public void ReturnCharsSokuonZ(string input)
		{
			const string expectedResult = "zzajjizzuzzezzojjajjijjujjejjo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ったっちっつってっとっちゃっちぃっちゅっちぇっちょ")]
		[InlineData("ッタッチッツッテットッチャッチィッチュッチェッチョ")]
		public void ReturnCharsSokuonT(string input)
		{
			const string expectedResult = "ttatchittsuttettotchatchitchutchetcho";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っだっぢっづっでっど")]
		[InlineData("ッダッヂッヅッデッド")]
		public void ReturnCharsSokuonD(string input)
		{
			const string expectedResult = "ddajjizzuddeddo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っなっにっぬっねっのっにゃっにぃっにゅっにぇっにょ")]
		[InlineData("ッナッニッヌッネッノッニャッニィッニュッニェッニョ")]
		public void ReturnCharsSokuonN(string input)
		{
			const string expectedResult = "nnanninnunnennonnyannyinnyunnyennyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っはっひっふっへっほっひゃっひぃっひゅっひぇっひょ")]
		[InlineData("ッハッヒッフッヘッホッヒャッヒィッヒュッヒェッヒョ")]
		public void ReturnCharsSokuonH(string input)
		{
			const string expectedResult = "hhahhiffuhhehhohhyahhyihhyuhhyehhyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っばっびっぶっべっぼっびゃっびぃっびゅっびぇっびょ")]
		[InlineData("ッバッビッブッベッボッビャッビィッビュッビェッビョ")]
		public void ReturnCharsSokuonB(string input)
		{
			const string expectedResult = "bbabbibbubbebbobbyabbyibbyubbyebbyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っぱっぴっぷっぺっぽっぴゃっぴぃっぴゅっぴぇっぴょ")]
		[InlineData("ッパッピップッペッポッピャッピィッピュッピェッピョ")]
		public void ReturnCharsSokuonP(string input)
		{
			const string expectedResult = "ppappippuppeppoppyappyippyuppyeppyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っまっみっむっめっもっみゃっみぃっみゅっみぇっみょ")]
		[InlineData("ッマッミッムッメッモッミャッミィッミュッミェッミョ")]
		public void ReturnCharsSokuonM(string input)
		{
			const string expectedResult = "mmammimmummemmommyammyimmyummyemmyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っやっゆっよ")]
		[InlineData("ッヤッユッヨ")]
		public void ReturnCharsSokuonY(string input)
		{
			const string expectedResult = "yyayyuyyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っらっりっるっれっろっりゃっりぃっりゅっりぇっりょ")]
		[InlineData("ッラッリッルッレッロッリャッリィッリュッリェッリョ")]
		public void ReturnCharsSokuonR(string input)
		{
			const string expectedResult = "rrarrirrurrerrorryarryirryurryerryo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っわ")]
		[InlineData("っを")]
		[InlineData("ッワ")]
		[InlineData("ッヲ")]
		public void ThrowExceptionForSokuonW(string input)
		{
			Action action = () => input.ToRomaji();

			action
				.Should()
				.ThrowExactly<InvalidKanaException>();
		}
	}
}
