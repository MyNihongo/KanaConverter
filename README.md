[![Version](https://img.shields.io/nuget/v/MyNihongo.KanaConverter?style=plastic)](https://www.nuget.org/packages/MyNihongo.KanaConverter/)
[![NuGet downloads](https://img.shields.io/nuget/dt/MyNihongo.KanaConverter?label=nuget%20downloads&logo=nuget&style=plastic)](https://www.nuget.org/packages/MyNihongo.KanaConverter/)   
Extension methods for kana conversion.
- `ToRomaji()` - convert Hiragana (ひらがな) or Katakana (カタカナ) to romaji.
```cs
var romaji = "ひらがな・カタカナ".ToRomaji(); // result "hiraganakatakana"
```
### StringBuilder with `Microsoft.Extensions.ObjectPool`
```cs
using Microsoft.Extensions.ObjectPool;

var stringBuilderPool = new DefaultObjectPoolProvider()
	.CreateStringBuilderPool();

for (var i = 0; i < 1_000_000; i++)
{
	var romaji = "ひらがな・カタカナ".ToRomaji(stringBuilderPool);
}
```

## Benchmark
Convert a kana string of 1,000,000 characters to romaji.
|                 Method |     Mean |    Error |   StdDev |     Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|----------------------- |---------:|---------:|---------:|----------:|---------:|---------:|----------:|
|              MyNihongo | 17.61 ms | 0.349 ms | 0.310 ms |  312.5000 | 312.5000 | 312.5000 |      7 MB |
| WanaKana_Sharp (0.1.1) | 35.95 ms | 0.617 ms | 0.577 ms | 1000.0000 | 714.2857 | 428.5714 |      7 MB |

WanaKana_Net (1.0.0) threw a StackOverflow exception.