namespace MyNihongo.KanaConverter;

/// <summary>
/// This model is created for try-convert methods so that expensive operations of throwing and catching exceptions are avoided.
/// </summary>
internal readonly ref struct ConversionResult
{
	public readonly string Value;
	public readonly string? ErrorMessage;

	private ConversionResult(string value, string? errorMessage)
	{
		Value = value;
		ErrorMessage = errorMessage;
	}

	public static ConversionResult Create(StringBuilder stringBuilder, string? errorMessage)
	{
		return string.IsNullOrEmpty(errorMessage)
			? new ConversionResult(value: stringBuilder.ToString(), errorMessage: null)
			: new ConversionResult(value: string.Empty, errorMessage);
	}

	public static ConversionResult FromValue(string value) =>
		new(value, null);

	public static ConversionResult FromError(string errorMessage) =>
		new(string.Empty, errorMessage);
}
