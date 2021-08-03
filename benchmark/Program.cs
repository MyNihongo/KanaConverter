using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace MyNihongo.KanaConverter.Benchmark
{
	internal class Program
	{
		private static void Main()
		{
			BenchmarkRunner.Run<RomajiConvertor>();
		}
	}

	[SimpleJob]
	[MemoryDiagnoser]
	public class RomajiConvertor
	{
		private readonly string _kanaString;

		public RomajiConvertor()
		{
			var random = new Random();
			var kana = new[]
			{
				'あ', 'い', 'う', 'え', 'お',
				'か', 'き', 'く', 'け', 'こ',
				'さ', 'し', 'す', 'せ', 'そ',
				'た', 'ち', 'つ', 'て', 'と',
				'な', 'に', 'ぬ', 'ね', 'の',
				'は', 'ひ', 'ふ', 'へ', 'ほ',
				'ま', 'み', 'む', 'め', 'も',
				'や', 'ゆ', 'よ',
				'ら', 'り', 'る', 'れ', 'ろ',
				'わ', 'を'
			};

			_kanaString = string.Create(1_000_000, true, (span, _) =>
			{
				for (var i = 0; i < span.Length; i++)
				{
					var index = random.Next(0, kana.Length - 1);
					span[i] = kana[index];
				}
			});
		}

		[Benchmark]
		public string MyNihongo() => _kanaString.ToRomaji();

		// STACK OVERFLOW exception
		//[Benchmark]
		//public string WanaKana_Net() => WanaKanaNet.WanaKana.ToRomaji(_kanaString);

		[Benchmark]
		public string WanaKana_Sharp() => WanaKanaSharp.WanaKana.ToRomaji(_kanaString);
	}
}
