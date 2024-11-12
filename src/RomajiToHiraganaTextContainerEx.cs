using System.Runtime.CompilerServices;

namespace MyNihongo.KanaConverter;

internal static class RomajiToHiraganaTextContainerEx
{
	public static ConversionResult ConvertToHiragana(this ITextContainer @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, ObjectPool<StringBuilder>? stringBuilderPool)
	{
		if (@this.IsEmpty)
			return ConversionResult.FromValue(string.Empty);

		var capacity = @this.Length / 2;
		var stringBuilder = stringBuilderPool?.Get() ?? new StringBuilder(capacity);
		stringBuilder.Capacity = capacity;

		try
		{
			int charBuilder = 0, stepMultiplier = 2;

			for (int i = 0, lastIndex = @this.Length - 1; i < @this.Length; i++)
			{
				int stepOffset;
				switch (char.ToLower(@this[i]))
				{
					// basic vowels
					case 'a':
						stepOffset = 0;
						goto Vowel;
					case 'i':
						stepOffset = 1;
						goto Vowel;
					case 'u':
						stepOffset = 2;
						goto Vowel;
					case 'e':
						stepOffset = 3;
						goto Vowel;
					case 'o':
						stepOffset = 4;
						goto Vowel;
					// consonants
					case 'k':
						charBuilder = TryAppendSokuon(stringBuilder, 'か', charBuilder);
						continue;
					case 'g':
						charBuilder = TryAppendSokuon(stringBuilder, 'が', charBuilder);
						continue;
					case 's':
						if (charBuilder is 'タ')
							continue;

						charBuilder = TryAppendSokuon(stringBuilder, 'さ', charBuilder);
						continue;
					case 'j':
						if (i < lastIndex)
						{
							// TODO: maybe extract
							switch (@this[i + 1])
							{
								case 'a':
									TryAppendSokuon(stringBuilder, 'ざ', charBuilder);
									charBuilder = 'ゃ';
									goto YouonS;
								case 'i':
									TryAppendSokuon(stringBuilder, 'ざ', charBuilder);
									charBuilder = 'じ';
									goto CustomVowel;
								case 'u':
									TryAppendSokuon(stringBuilder, 'ざ', charBuilder);
									charBuilder = 'ゅ';
									goto YouonS;
								case 'e':
									TryAppendSokuon(stringBuilder, 'ざ', charBuilder);
									charBuilder = 'ぇ';
									goto YouonS;
								case 'o':
									TryAppendSokuon(stringBuilder, 'ざ', charBuilder);
									charBuilder = 'ょ';
									goto YouonS;
								default:
									goto CaseZ;
							}

							YouonS:
							AppendChar(stringBuilder, charBuilder: 'じ', stepOffset: 0, stepMultiplier: 0);
							goto CustomVowel;
						}

						CaseZ:
						goto case 'z';
					case 'z':
						charBuilder = TryAppendSokuon(stringBuilder, 'ざ', charBuilder);
						continue;
					case 'c':
					case 't':
						// `ッ` is in the middle of the t-character, so we need some custom offset
						if (i < lastIndex)
						{
							switch (@this[i + 1])
							{
								case 'u':
									TryAppendSokuon(stringBuilder, 'た', charBuilder);
									charBuilder = 'つ';
									goto CustomVowel;
								case 'e':
									TryAppendSokuon(stringBuilder, 'た', charBuilder);
									charBuilder = 'て';
									goto CustomVowel;
								case 'o':
									TryAppendSokuon(stringBuilder, 'た', charBuilder);
									charBuilder = 'と';
									goto CustomVowel;
								case 's':
									// Here we assume that `ts` is the incomplete `tsu`
									i++;
									goto case 'u';
							}
						}

						charBuilder = TryAppendSokuon(stringBuilder, 'た', charBuilder);
						continue;
					case 'd':
						// `ッ` is in the middle of the d-character, so we need some custom offset
						if (i < lastIndex)
						{
							switch (@this[i + 1])
							{
								case 'u':
									TryAppendSokuon(stringBuilder, 'だ', charBuilder);
									charBuilder = 'づ';
									goto CustomVowel;
								case 'e':
									TryAppendSokuon(stringBuilder, 'だ', charBuilder);
									charBuilder = 'で';
									goto CustomVowel;
								case 'o':
									TryAppendSokuon(stringBuilder, 'だ', charBuilder);
									charBuilder = 'ど';
									goto CustomVowel;
								case 'z':
									// Here we assume that `dz` is the incomplete `dzu`
									i++;
									goto case 'u';
							}
						}

						charBuilder = TryAppendSokuon(stringBuilder, 'だ', charBuilder);
						continue;
					case 'h':
						if (charBuilder is 'さ' or 'ざ')
						{
							// TODO: maybe extract
							if (i < lastIndex)
							{
								switch (@this[i + 1])
								{
									case 'a':
										charBuilder = 'ゃ';
										goto YouonS;
									case 'i':
										charBuilder = 'し';
										goto CustomVowel;
									case 'u':
										charBuilder = 'ゅ';
										goto YouonS;
									case 'e':
										charBuilder = 'ぇ';
										goto YouonS;
									case 'o':
										charBuilder = 'ょ';
										goto YouonS;
									default:
										continue;
								}

								YouonS:
								AppendChar(stringBuilder, charBuilder: 'し', stepOffset: 0, stepMultiplier: 0);
								goto CustomVowel;
							}

							continue;
						}

						if (charBuilder is 'た' or 'だ')
						{
							// TODO: maybe extract
							if (i < lastIndex)
							{
								switch (@this[i + 1])
								{
									case 'a':
										charBuilder = 'ゃ';
										goto YouonS;
									case 'i':
										charBuilder = 'ち';
										goto CustomVowel;
									case 'u':
										charBuilder = 'ゅ';
										goto YouonS;
									case 'e':
										charBuilder = 'ぇ';
										goto YouonS;
									case 'o':
										charBuilder = 'ょ';
										goto YouonS;
									default:
										continue;
								}

								YouonS:
								AppendChar(stringBuilder, charBuilder: 'ち', stepOffset: 0, stepMultiplier: 0);
								goto CustomVowel;
							}

							continue;
						}

						goto case 'f';
					case 'f':
						charBuilder = TryAppendSokuon(stringBuilder, 'は', charBuilder);
						stepMultiplier = 3;
						continue;
					case 'b':
						charBuilder = TryAppendSokuon(stringBuilder, 'ば', charBuilder);
						stepMultiplier = 3;
						continue;
					case 'p':
						charBuilder = TryAppendSokuon(stringBuilder, 'ぱ', charBuilder);
						stepMultiplier = 3;
						continue;
					case 'm':
						charBuilder = TryAppendSokuon(stringBuilder, 'ま', charBuilder);
						stepMultiplier = 1;
						continue;
					case 'r':
					case 'l':
						charBuilder = TryAppendSokuon(stringBuilder, 'ら', charBuilder);
						stepMultiplier = 1;
						continue;
					case 'w':
						if (i < lastIndex)
						{
							switch (@this[i + 1])
							{
								case 'e':
									charBuilder = 'ゑ';
									goto CustomVowel;
								case 'o':
									charBuilder = 'を';
									goto CustomVowel;
							}
						}

						charBuilder = 'わ';
						stepMultiplier = 1;
						continue;
					// special consonant `v`
					case 'v':
						// TODO: extract maybe
						if (i < lastIndex)
						{
							switch (@this[i + 1])
							{
								case 'a':
									charBuilder = 'ぁ';
									goto YouonS;
								case 'i':
									charBuilder = 'ぃ';
									goto YouonS;
								case 'u':
									charBuilder = 'ゔ';
									goto CustomVowel;
								case 'e':
									charBuilder = 'ぇ';
									goto YouonS;
								case 'o':
									charBuilder = 'ぉ';
									goto YouonS;
								default:
									continue;
							}

							YouonS:
							AppendChar(stringBuilder, charBuilder: 'ゔ', stepOffset: 0, stepMultiplier: 0);
							goto CustomVowel;
						}

						charBuilder = 'ゔ';
						continue;
					// special consonant `n`
					case 'n':
						if (i == lastIndex)
							goto VowelN;

						// TODO: do not check the char again
						switch (@this[i + 1])
						{
							case 'a':
							case 'i':
							case 'u':
							case 'e':
							case 'o':
							case 'y':
								charBuilder = 'な';
								stepMultiplier = 1;
								continue;
						}

						VowelN:
						charBuilder = 'ん';
						stepOffset = 0;
						goto Vowel;
					// special consonants with possible 拗音
					case 'y':
						if (charBuilder != 0)
						{
							AppendChar(stringBuilder, charBuilder, stepOffset: 1, stepMultiplier);

							switch (@this[i + 1])
							{
								case 'a':
									charBuilder = 'ゃ';
									goto CustomVowel;
								case 'i':
									charBuilder = 'ぃ';
									goto CustomVowel;
								case 'u':
									charBuilder = 'ゅ';
									goto CustomVowel;
								case 'e':
									charBuilder = 'ぇ';
									goto CustomVowel;
								case 'o':
									charBuilder = 'ょ';
									goto CustomVowel;
							}
						}

						if (i < lastIndex)
						{
							switch (@this[i + 1])
							{
								case 'a':
									charBuilder = 'や';
									goto CustomVowel;
								case 'u':
									charBuilder = 'ゆ';
									goto CustomVowel;
								case 'o':
									charBuilder = 'よ';
									goto CustomVowel;
							}
						}

						charBuilder = 'や';
						continue;
					default:
					{
						switch (unrecognisedCharacterPolicy)
						{
							case UnrecognisedCharacterPolicy.Skip:
								continue;
							case UnrecognisedCharacterPolicy.Append:
								stringBuilder.Append(@this[i]);
								continue;
							default:
								return ConversionResult.FromError($"Invalid kana character \"{@this[i]}\" in \"{@this}\"");
						}
					}
				}

				CustomVowel:
				stepOffset = 0;
				i++;

				Vowel:
				if (charBuilder == 0)
					charBuilder = 'あ';

				AppendChar(stringBuilder, charBuilder, stepOffset, stepMultiplier);
				charBuilder = 0;
				stepMultiplier = 2;
			}

			return ConversionResult.FromValue(stringBuilder.ToString());
		}
		finally
		{
			stringBuilderPool?.Return(stringBuilder);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void AppendChar(in StringBuilder stringBuilder, in int charBuilder, in int stepOffset, in int stepMultiplier)
	{
		var character = (char)(charBuilder + stepOffset * stepMultiplier);
		stringBuilder.Append(character);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static char TryAppendSokuon(in StringBuilder stringBuilder, in char character, in int charBuilder)
	{
		if (character == charBuilder)
			stringBuilder.Append('っ');

		return character;
	}
}
