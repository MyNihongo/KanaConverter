﻿using System.Runtime.CompilerServices;

namespace MyNihongo.KanaConverter;

public static class StringExRomajiToKatakana
{
	/// <summary>
	/// Converts a romaji string to katakana.
	/// </summary>
	/// <param name="this">Romaji string to be converted to katakana.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="stringBuilderPool">String builder pool that is useful when many strings are converted in a loop.</param>
	/// <exception cref="InvalidCharacterException"></exception>
	public static string ToKatakana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy = default, ObjectPool<StringBuilder>? stringBuilderPool = null)
	{
		var result = @this.ConvertToKatakana(unrecognisedCharacterPolicy, stringBuilderPool);

		if (result.ErrorMessage != null)
			throw new InvalidCharacterException(result.ErrorMessage);

		return result.Value;
	}

	/// <summary>
	/// Tries to convert a romaji string to katakana.
	/// </summary>
	/// <param name="this">Romaji string to be converted to katakana.</param>
	/// <param name="value">Katakana string after conversion.</param>
	public static bool TryConvertToKatakana(this string @this, out string value) =>
		@this.TryConvertToKatakana(unrecognisedCharacterPolicy: default, stringBuilderPool: null, out value);

	/// <summary>
	/// Tries to convert a romaji string to katakana.
	/// </summary>
	/// <param name="this">Romaji string to be converted to katakana.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="value">Katakana string after conversion.</param>
	public static bool TryConvertToKatakana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, out string value) =>
		@this.TryConvertToKatakana(unrecognisedCharacterPolicy, stringBuilderPool: null, out value);

	/// <summary>
	/// Tries to convert a romaji string to katakana.
	/// </summary>
	/// <param name="this">Romaji string to be converted to katakana.</param>
	/// <param name="unrecognisedCharacterPolicy">Behaviour how unrecognised characters are treated.</param>
	/// <param name="stringBuilderPool">String builder pool that is useful when many strings are converted in a loop.</param>
	/// <param name="value">Katakana string after conversion.</param>
	public static bool TryConvertToKatakana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, ObjectPool<StringBuilder>? stringBuilderPool, out string value)
	{
		var result = @this.ConvertToKatakana(unrecognisedCharacterPolicy, stringBuilderPool);
		value = result.Value;

		if (unrecognisedCharacterPolicy == UnrecognisedCharacterPolicy.Append)
			return result.ErrorMessage == null && value != @this;

		return result.ErrorMessage == null;
	}

	private static ConversionResult ConvertToKatakana(this string @this, UnrecognisedCharacterPolicy unrecognisedCharacterPolicy, ObjectPool<StringBuilder>? stringBuilderPool)
	{
		if (string.IsNullOrEmpty(@this))
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
						charBuilder = TryAppendSokuon(stringBuilder, 'カ', charBuilder);
						continue;
					case 'g':
						charBuilder = TryAppendSokuon(stringBuilder, 'ガ', charBuilder);
						continue;
					case 's':
						if (charBuilder is 'タ')
							continue;

						charBuilder = TryAppendSokuon(stringBuilder, 'サ', charBuilder);
						continue;
					case 'j':
						if (i < lastIndex)
						{
							// TODO: maybe extract
							switch (@this[i + 1])
							{
								case 'a':
									TryAppendSokuon(stringBuilder, 'ザ', charBuilder);
									charBuilder = 'ャ';
									goto YouonS;
								case 'i':
									TryAppendSokuon(stringBuilder, 'ザ', charBuilder);
									charBuilder = 'ジ';
									goto CustomVowel;
								case 'u':
									TryAppendSokuon(stringBuilder, 'ザ', charBuilder);
									charBuilder = 'ュ';
									goto YouonS;
								case 'e':
									TryAppendSokuon(stringBuilder, 'ザ', charBuilder);
									charBuilder = 'ェ';
									goto YouonS;
								case 'o':
									TryAppendSokuon(stringBuilder, 'ザ', charBuilder);
									charBuilder = 'ョ';
									goto YouonS;
								default:
									goto CaseZ;
							}

							YouonS:
							AppendChar(stringBuilder, charBuilder: 'ジ', stepOffset: 0, stepMultiplier: 0);
							goto CustomVowel;
						}

						CaseZ:
						goto case 'z';
					case 'z':
						charBuilder = TryAppendSokuon(stringBuilder, 'ザ', charBuilder);
						continue;
					case 'c':
					case 't':
						// `ッ` is in the middle of the t-character, so we need some custom offset
						if (i < lastIndex)
						{
							switch (@this[i + 1])
							{
								case 'u':
									TryAppendSokuon(stringBuilder, 'タ', charBuilder);
									charBuilder = 'ツ';
									goto CustomVowel;
								case 'e':
									TryAppendSokuon(stringBuilder, 'タ', charBuilder);
									charBuilder = 'テ';
									goto CustomVowel;
								case 'o':
									TryAppendSokuon(stringBuilder, 'タ', charBuilder);
									charBuilder = 'ト';
									goto CustomVowel;
								case 's':
									// Here we assume that `ts` is the incomplete `tsu`
									i++;
									goto case 'u';
							}
						}

						charBuilder = TryAppendSokuon(stringBuilder, 'タ', charBuilder);
						continue;
					case 'd':
						// `ッ` is in the middle of the d-character, so we need some custom offset
						if (i < lastIndex)
						{
							switch (@this[i + 1])
							{
								case 'u':
									TryAppendSokuon(stringBuilder, 'ダ', charBuilder);
									charBuilder = 'ヅ';
									goto CustomVowel;
								case 'e':
									TryAppendSokuon(stringBuilder, 'ダ', charBuilder);
									charBuilder = 'デ';
									goto CustomVowel;
								case 'o':
									TryAppendSokuon(stringBuilder, 'ダ', charBuilder);
									charBuilder = 'ド';
									goto CustomVowel;
								case 'z':
									// Here we assume that `dz` is the incomplete `dzu`
									i++;
									goto case 'u';
							}
						}

						charBuilder = TryAppendSokuon(stringBuilder, 'ダ', charBuilder);
						continue;
					case 'h':
						if (charBuilder is 'サ' or 'ザ')
						{
							// TODO: maybe extract
							if (i < lastIndex)
							{
								switch (@this[i + 1])
								{
									case 'a':
										charBuilder = 'ャ';
										goto YouonS;
									case 'i':
										charBuilder = 'シ';
										goto CustomVowel;
									case 'u':
										charBuilder = 'ュ';
										goto YouonS;
									case 'e':
										charBuilder = 'ェ';
										goto YouonS;
									case 'o':
										charBuilder = 'ョ';
										goto YouonS;
									default:
										continue;
								}

								YouonS:
								AppendChar(stringBuilder, charBuilder: 'シ', stepOffset: 0, stepMultiplier: 0);
								goto CustomVowel;
							}

							continue;
						}

						if (charBuilder is 'タ' or 'ダ')
						{
							// TODO: maybe extract
							if (i < lastIndex)
							{
								switch (@this[i + 1])
								{
									case 'a':
										charBuilder = 'ャ';
										goto YouonS;
									case 'i':
										charBuilder = 'チ';
										goto CustomVowel;
									case 'u':
										charBuilder = 'ュ';
										goto YouonS;
									case 'e':
										charBuilder = 'ェ';
										goto YouonS;
									case 'o':
										charBuilder = 'ョ';
										goto YouonS;
									default:
										continue;
								}

								YouonS:
								AppendChar(stringBuilder, charBuilder: 'チ', stepOffset: 0, stepMultiplier: 0);
								goto CustomVowel;
							}

							continue;
						}

						goto case 'f';
					case 'f':
						charBuilder = TryAppendSokuon(stringBuilder, 'ハ', charBuilder);
						stepMultiplier = 3;
						continue;
					case 'b':
						charBuilder = TryAppendSokuon(stringBuilder, 'バ', charBuilder);
						stepMultiplier = 3;
						continue;
					case 'p':
						charBuilder = TryAppendSokuon(stringBuilder, 'パ', charBuilder);
						stepMultiplier = 3;
						continue;
					case 'm':
						charBuilder = TryAppendSokuon(stringBuilder, 'マ', charBuilder);
						stepMultiplier = 1;
						continue;
					case 'r':
					case 'l':
						charBuilder = TryAppendSokuon(stringBuilder, 'ラ', charBuilder);
						stepMultiplier = 1;
						continue;
					case 'w':
						if (i < lastIndex)
						{
							switch (@this[i + 1])
							{
								case 'e':
									charBuilder = 'ヱ';
									goto CustomVowel;
								case 'o':
									charBuilder = 'ヲ';
									goto CustomVowel;
							}
						}

						charBuilder = 'ワ';
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
									charBuilder = 'ァ';
									goto YouonS;
								case 'i':
									charBuilder = 'ィ';
									goto YouonS;
								case 'u':
									charBuilder = 'ヴ';
									goto CustomVowel;
								case 'e':
									charBuilder = 'ェ';
									goto YouonS;
								case 'o':
									charBuilder = 'ォ';
									goto YouonS;
								default:
									continue;
							}

							YouonS:
							AppendChar(stringBuilder, charBuilder: 'ヴ', stepOffset: 0, stepMultiplier: 0);
							goto CustomVowel;
						}

						charBuilder = 'ヴ';
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
								charBuilder = 'ナ';
								stepMultiplier = 1;
								continue;
						}

						VowelN:
						charBuilder = 'ン';
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
									charBuilder = 'ャ';
									goto CustomVowel;
								case 'i':
									charBuilder = 'ィ';
									goto CustomVowel;
								case 'u':
									charBuilder = 'ュ';
									goto CustomVowel;
								case 'e':
									charBuilder = 'ェ';
									goto CustomVowel;
								case 'o':
									charBuilder = 'ョ';
									goto CustomVowel;
							}
						}

						if (i < lastIndex)
						{
							switch (@this[i + 1])
							{
								case 'a':
									charBuilder = 'ヤ';
									goto CustomVowel;
								case 'u':
									charBuilder = 'ユ';
									goto CustomVowel;
								case 'o':
									charBuilder = 'ヨ';
									goto CustomVowel;
							}
						}

						charBuilder = 'ヤ';
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
					charBuilder = 'ア';

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
			stringBuilder.Append('ッ');

		return character;
	}
}
