[![Version](https://img.shields.io/nuget/v/MyNihongo.KanaConverter?style=plastic)](https://www.nuget.org/packages/MyNihongo.KanaConverter/)
[![NuGet downloads](https://img.shields.io/nuget/dt/MyNihongo.KanaConverter?label=nuget%20downloads&logo=nuget&style=plastic)](https://www.nuget.org/packages/MyNihongo.KanaConverter/)   
Extension methods for kana conversion.
- `ToRomaji()` - convert Hiragana (ひらがな) or Katakana (カタカナ) to romaji.
- `ToHiragana()` - convert romaji to Hiragana (ひらがな).
- `ToKatakana()` - convert romaji to Katakana (カタカナ).
- `KanaToHiragana()` - convert Hiragana (ひらがな) or Katakana (カタカナ) to Hiragana (ひらがな).
- `KanaToKatakana()` - convert Hiragana (ひらがな) or Katakana (カタカナ) to Katakana (カタカナ).
```cs
var romaji = "ひらがな・カタカナ".ToRomaji(); // result "hiraganakatakana"
var hiragana = "hiragana".ToHiragana(); // result "ひらがな"
var katakana = "katakana".ToKatakana(); // result "カタカナ"
var kanaToHiragana = "ひらがな・カタカナ".KanaToHiragana(UnrecognisedCharacterPolicy.Append); // result "ひらがな・かたかな"
var kanaToKatakana = "ひらがな・カタカナ".KanaToKatakana(UnrecognisedCharacterPolicy.Append); // result "ヒラガナ・カタカナ"
```
### StringBuilder with `Microsoft.Extensions.ObjectPool`
```cs
using Microsoft.Extensions.ObjectPool;

var stringBuilderPool = new DefaultObjectPoolProvider()
	.CreateStringBuilderPool();

for (var i = 0; i < 1_000_000; i++)
{
	var romaji = "ひらがな・カタカナ".ToRomaji(stringBuilderPool: stringBuilderPool);
}
```

## Handling unrecognised characters
When an unexpected character is encountered in the supplied character sequence the following options are available:
- ThrowException (default): `InvalidCharacterException` will be thrown.
- Skip: characters will not be processed (just ignored).
- Append: characters will be added to the result string (appended).
