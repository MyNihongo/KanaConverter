namespace MyNihongo.KanaConverter.Tests.KanaToHiraganaStringExTests;

public sealed class TryConvertKanaToHiraganaSokuonShould
{
	[Fact]
	public void ReturnCharsSokuon()
	{
		const string input = "ッン",
			expected = "っん";

		var result = input.TryConvertKanaToHiragana(out var valueResult);

		result
			.Should()
			.BeTrue();

		valueResult
			.Should()
			.Be(expected);
	}
}
