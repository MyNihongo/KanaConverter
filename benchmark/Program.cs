using System;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.Extensions.ObjectPool;

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
		private const int InterationCount = 100;

		private readonly string _kanaString;
		private readonly ObjectPool<StringBuilder> _stringBuilderPool;

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
				'わ', 'を',
			};

			_kanaString = string.Create(1_000_000, true, (span, _) =>
			{
				for (var i = 0; i < span.Length; i++)
				{
					var index = random.Next(0, kana.Length - 1);
					span[i] = kana[index];
				}
			});

			_stringBuilderPool = new DefaultObjectPoolProvider()
				.CreateStringBuilderPool();
		}

		[Benchmark]
		public string MyNihongo() => _kanaString.ToRomaji();

		[Benchmark]
		public void MyNihongoMultiple()
		{
			for (var i = 0; i < InterationCount; i++)
			{
				_kanaString.ToRomaji(stringBuilderPool: _stringBuilderPool);
			}
		}
	}
}
