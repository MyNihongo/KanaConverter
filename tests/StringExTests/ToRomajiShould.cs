using System;
using FluentAssertions;
using MyNihongo.KanaConverter.Exceptions;
using Xunit;

namespace MyNihongo.KanaConverter.Tests.StringExTests
{
	public sealed class ToRomajiShould
	{
		[Theory]
		[InlineData(null)]
		[InlineData("")]
		public void ReturnEmptyIfNullOrEmpty(string input)
		{
			var result = input.ToRomaji();

			result
				.Should()
				.BeEmpty();
		}

		[Theory]
		[InlineData("あいうえおん")]
		[InlineData("アイウエオン")]
		public void ReturnChars(string input)
		{
			const string expectedResult = "aiueon";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

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
		[InlineData("かきくけこ")]
		[InlineData("カキクケコ")]
		public void ReturnCharsK(string input)
		{
			const string expectedResult = "kakikukeko";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("きゃきゅきょ")]
		[InlineData("キャキュキョ")]
		public void ReturnCharsYouonK(string input)
		{
			const string expectedResult = "kyakyukyo";

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
		[InlineData("がぎぐげご")]
		[InlineData("ガギグゲゴ")]
		public void ReturnCharsG(string input)
		{
			const string expectedResult = "gagigugego";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぎゃぎゅぎょ")]
		[InlineData("ギャギュギョ")]
		public void ReturnCharsYouonG(string input)
		{
			const string expectedResult = "gyagyugyo";

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
		[InlineData("さしすせそ")]
		[InlineData("サシスセソ")]
		public void ReturnCharsS(string input)
		{
			const string expectedResult = "sashisuseso";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("しゃしゅしょ")]
		[InlineData("シャシュショ")]
		public void ReturnCharsYouonS(string input)
		{
			const string expectedResult = "shashusho";

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
		[InlineData("ざじずぜぞ")]
		[InlineData("ザジズゼゾ")]
		public void ReturnCharsZ(string input)
		{
			const string expectedResult = "zajizuzezo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("じゃじゅジョ")]
		[InlineData("ジャジュジョ")]
		public void ReturnCharsYouonZ(string input)
		{
			const string expectedResult = "jajujo";

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
		[InlineData("たちつてと")]
		[InlineData("タチツテト")]
		public void ReturnCharsT(string input)
		{
			const string expectedResult = "tachitsuteto";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ちゃちゅちょ")]
		[InlineData("チャチュチョ")]
		public void ReturnCharsYouonT(string input)
		{
			const string expectedResult = "chachucho";

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
		[InlineData("だぢづでど")]
		[InlineData("ダヂヅデド")]
		public void ReturnCharsD(string input)
		{
			const string expectedResult = "dajizudedo";

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
		[InlineData("なにぬねの")]
		[InlineData("ナニヌネノ")]
		public void ReturnCharsN(string input)
		{
			const string expectedResult = "naninuneno";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("にゃにゅにょ")]
		[InlineData("ニャニュニョ")]
		public void ReturnCharsYouonＮ(string input)
		{
			const string expectedResult = "nyanyunyo";

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
		[InlineData("はひふへほ")]
		[InlineData("ハヒフヘホ")]
		public void ReturnCharsH(string input)
		{
			const string expectedResult = "hahifuheho";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ひゃひゅひょ")]
		[InlineData("ヒャヒュヒョ")]
		public void ReturnCharsYouonH(string input)
		{
			const string expectedResult = "hyahyuhyo";

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
		[InlineData("ばびぶべぼ")]
		[InlineData("バビブベボ")]
		public void ReturnCharsB(string input)
		{
			const string expectedResult = "babibubebo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("びゃびゅびょ")]
		[InlineData("ビャビュビョ")]
		public void ReturnCharsYouonB(string input)
		{
			const string expectedResult = "byabyubyo";

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
		[InlineData("ぱぴぷぺぽ")]
		[InlineData("パピプペポ")]
		public void ReturnCharsP(string input)
		{
			const string expectedResult = "papipupepo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("ぴゃぴゅぴょ")]
		[InlineData("ピャピュピョ")]
		public void ReturnCharsYouonP(string input)
		{
			const string expectedResult = "pyapyupyo";

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
		[InlineData("まみむめも")]
		[InlineData("マミムメモ")]
		public void ReturnCharsM(string input)
		{
			const string expectedResult = "mamimumemo";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("みゃみゅみょ")]
		[InlineData("ミャミュミョ")]
		public void ReturnCharsYouonM(string input)
		{
			const string expectedResult = "myamyumyo";

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
		[InlineData("やゆよ")]
		[InlineData("ヤユヨ")]
		public void ReturnCharsY(string input)
		{
			const string expectedResult = "yayuyo";

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
		[InlineData("らりるれろ")]
		[InlineData("ラリルレロ")]
		public void ReturnCharsR(string input)
		{
			const string expectedResult = "rarirurero";

			var result = input.ToRomaji();

			result
				.Should()
				.Be(expectedResult);
		}

		[Theory]
		[InlineData("りゃりゅりょ")]
		[InlineData("リャリュリョ")]
		public void ReturnCharsYouonR(string input)
		{
			const string expectedResult = "ryaryuryo";

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
		[InlineData("わを")]
		[InlineData("ワヲ")]
		public void ReturnCharsW(string input)
		{
			const string expectedResult = "wawo";

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
