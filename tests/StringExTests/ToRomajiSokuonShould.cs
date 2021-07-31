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
		[InlineData("っかっきっくっけっこっきゃっきゅっきょ")]
		[InlineData("ッカッキックッケッコッキャッキュッキョ")]
		public void ReturnCharsSokuonK(string input)
		{
			const string expectedResult = "kkakkikkukkekkokkyakkyukkyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っがっぎっぐっげっごっぎゃっぎゅっぎょ")]
		[InlineData("ッガッギッグッゲッゴッギャッギュッギョ")]
		public void ReturnCharsSokuonG(string input)
		{
			const string expectedResult = "ggaggigguggeggoggyaggyuggyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っさっしっすっせっそっしゃっしゅっしょ")]
		[InlineData("ッサッシッスッセッソッシャッシュッショ")]
		public void ReturnCharsSokuonS(string input)
		{
			const string expectedResult = "ssasshissussessosshasshussho";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っざっじっずっぜっぞっじゃっじゅっじょ")]
		[InlineData("ッザッジッズッゼッゾッジャッジュッジョ")]
		public void ReturnCharsSokuonZ(string input)
		{
			const string expectedResult = "zzajjizzuzzezzojjajjujjo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ったっちっつってっとっちゃっちゅっちょ")]
		[InlineData("ッタッチッツッテットッチャッチュッチョ")]
		public void ReturnCharsSokuonT(string input)
		{
			const string expectedResult = "ttatchittsuttettotchatchutcho";

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
		[InlineData("っなっにっぬっねっのっにゃっにゅっにょ")]
		[InlineData("ッナッニッヌッネッノッニャッニュッニョ")]
		public void ReturnCharsSokuonN(string input)
		{
			const string expectedResult = "nnanninnunnennonnyannyunnyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っはっひっふっへっほっひゃっひゅっひょ")]
		[InlineData("ッハッヒッフッヘッホッヒャッヒュッヒョ")]
		public void ReturnCharsSokuonH(string input)
		{
			const string expectedResult = "hhahhiffuhhehhohhyahhyuhhyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っばっびっぶっべっぼっびゃっびゅっびょ")]
		[InlineData("ッバッビッブッベッボッビャッビュッビョ")]
		public void ReturnCharsSokuonB(string input)
		{
			const string expectedResult = "bbabbibbubbebbobbyabbyubbyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っぱっぴっぷっぺっぽっぴゃっぴゅっぴょ")]
		[InlineData("ッパッピップッペッポッピャッピュッピョ")]
		public void ReturnCharsSokuonP(string input)
		{
			const string expectedResult = "ppappippuppeppoppyappyuppyo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("っまっみっむっめっもっみゃっみゅっみょ")]
		[InlineData("ッマッミッムッメッモッミャッミュッミョ")]
		public void ReturnCharsSokuonM(string input)
		{
			const string expectedResult = "mmammimmummemmommyammyummyo";

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
		[InlineData("っらっりっるっれっろっりゃっりゅっりょ")]
		[InlineData("ッラッリッルッレッロッリャッリュッリョ")]
		public void ReturnCharsSokuonR(string input)
		{
			const string expectedResult = "rrarrirrurrerrorryarryurryo";

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
