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
| Method                 | Mean         | Error      | StdDev     | Gen0       | Gen1       | Gen2       | Allocated |
|----------------------- |-------------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|
| MyNihongo              |     9.756 ms |  0.1463 ms |  0.1368 ms |   984.3750 |   984.3750 |   984.3750 |   7.54 MB |
| MyNihongoMultiple      |   962.581 ms |  7.2602 ms |  6.7912 ms | 99000.0000 | 99000.0000 | 99000.0000 | 754.29 MB |
| WanaKana_Sharp         |    11.545 ms |  0.1239 ms |  0.1159 ms |   796.8750 |   781.2500 |   484.3750 |   7.62 MB |
| WanaKana_SharpMultiple | 1,147.683 ms | 14.6285 ms | 12.9678 ms | 80000.0000 | 79000.0000 | 49000.0000 | 761.87 MB |

WanaKana_Net (1.0.0) threw a StackOverflow exception.