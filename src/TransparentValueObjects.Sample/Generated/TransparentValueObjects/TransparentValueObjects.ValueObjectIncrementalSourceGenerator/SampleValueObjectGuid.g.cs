﻿// <auto-generated/>
#nullable enable
namespace TransparentValueObjects.Sample;

[global::System.Diagnostics.DebuggerDisplay("{Value}")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage(Justification = "Auto-generated.")]
[global::System.Text.Json.Serialization.JsonConverter(typeof(SystemTextJsonConverter))]
readonly partial struct SampleValueObjectGuid :
	global::TransparentValueObjects.Augments.IValueObject<global::System.Guid>,
	global::System.IEquatable<SampleValueObjectGuid>,
	global::System.IEquatable<global::System.Guid>,
	global::System.IComparable<SampleValueObjectGuid>
{
	public readonly global::System.Guid Value;

	public SampleValueObjectGuid()
	{
		Value = DefaultValue.Value;
	}

	private SampleValueObjectGuid(global::System.Guid value)
	{
		Value = value;
	}

	public static SampleValueObjectGuid From(global::System.Guid value) => new(value);

	public override int GetHashCode() => Value.GetHashCode();

	public override string ToString() => Value.ToString();

	public bool Equals(SampleValueObjectGuid other) => Equals(other.Value);
	public bool Equals(global::System.Guid other) => Value.Equals(other);
	public bool Equals(SampleValueObjectGuid other, global::System.Collections.Generic.IEqualityComparer<global::System.Guid> comparer) => comparer.Equals(Value, other.Value);
	public override bool Equals(object? obj)
	{
		if (obj is null) return false;
		if (obj is SampleValueObjectGuid value) return Equals(value);
		if (obj is global::System.Guid innerValue) return Equals(innerValue);
		return false;
	}

	public static bool operator ==(SampleValueObjectGuid left, SampleValueObjectGuid right) => left.Equals(right);
	public static bool operator !=(SampleValueObjectGuid left, SampleValueObjectGuid right) => !left.Equals(right);

	public static bool operator ==(SampleValueObjectGuid left, global::System.Guid right) => left.Equals(right);
	public static bool operator !=(SampleValueObjectGuid left, global::System.Guid right) => !left.Equals(right);

	public static bool operator ==(global::System.Guid left, SampleValueObjectGuid right) => right.Equals(left);
	public static bool operator !=(global::System.Guid left, SampleValueObjectGuid right) => !right.Equals(left);

	public static explicit operator SampleValueObjectGuid(global::System.Guid value) => From(value);
	public static explicit operator global::System.Guid(SampleValueObjectGuid value) => value.Value;

	public static global::System.Type SystemTextJsonConverterType => typeof(SystemTextJsonConverter);
	public class SystemTextJsonConverter : global::System.Text.Json.Serialization.JsonConverter<SampleValueObjectGuid>
	{
		private static global::System.Text.Json.Serialization.JsonConverter<global::System.Guid> GetInnerValueConverter(global::System.Text.Json.JsonSerializerOptions options)
		{
			var innerValueConverter = options.GetConverter(typeof(global::System.Guid));
			if (innerValueConverter is null) throw new global::System.Text.Json.JsonException($"Unable to find converter for type {typeof(global::System.Guid)}");
			return (global::System.Text.Json.Serialization.JsonConverter<global::System.Guid>) innerValueConverter;
		}

		public override SampleValueObjectGuid Read(ref global::System.Text.Json.Utf8JsonReader reader, global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options)
		{
			var innerValueConverter = GetInnerValueConverter(options);
			var innerValue = innerValueConverter.Read(ref reader, typeof(global::System.Guid), options);
			return innerValue == default ? DefaultValue : From(innerValue);
		}

		public override void Write(global::System.Text.Json.Utf8JsonWriter writer, SampleValueObjectGuid value, global::System.Text.Json.JsonSerializerOptions options)
		{
			var innerValueConverter = GetInnerValueConverter(options);
			innerValueConverter.Write(writer, value.Value, options);
		}

		public override SampleValueObjectGuid ReadAsPropertyName(ref global::System.Text.Json.Utf8JsonReader reader, global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options)
		{
			var innerValueConverter = GetInnerValueConverter(options);
			var innerValue = innerValueConverter.ReadAsPropertyName(ref reader, typeof(global::System.Guid), options);
			return From(innerValue);
		}

		public override void WriteAsPropertyName(global::System.Text.Json.Utf8JsonWriter writer, SampleValueObjectGuid value, global::System.Text.Json.JsonSerializerOptions options)
		{
			var innerValueConverter = GetInnerValueConverter(options);
			innerValueConverter.WriteAsPropertyName(writer, value.Value, options);
		}

	}

	public global::System.Int32 CompareTo(SampleValueObjectGuid other) => Value.CompareTo(other);
	public static bool operator <(SampleValueObjectGuid left, SampleValueObjectGuid right) => left.Value.CompareTo(right.Value) < 0;
	public static bool operator >(SampleValueObjectGuid left, SampleValueObjectGuid right) => left.Value.CompareTo(right.Value) > 0;
	public static bool operator <=(SampleValueObjectGuid left, SampleValueObjectGuid right) => left.Value.CompareTo(right.Value) <= 0;
	public static bool operator >=(SampleValueObjectGuid left, SampleValueObjectGuid right) => left.Value.CompareTo(right.Value) >= 0;

	public static bool operator <(global::System.Guid left, SampleValueObjectGuid right) => left.CompareTo(right.Value) < 0;
	public static bool operator >(global::System.Guid left, SampleValueObjectGuid right) => left.CompareTo(right.Value) > 0;
	public static bool operator <=(global::System.Guid left, SampleValueObjectGuid right) => left.CompareTo(right.Value) <= 0;
	public static bool operator >=(global::System.Guid left, SampleValueObjectGuid right) => left.CompareTo(right.Value) >= 0;

	public static bool operator <(SampleValueObjectGuid left, global::System.Guid right) => left.Value.CompareTo(right) < 0;
	public static bool operator >(SampleValueObjectGuid left, global::System.Guid right) => left.Value.CompareTo(right) > 0;
	public static bool operator <=(SampleValueObjectGuid left, global::System.Guid right) => left.Value.CompareTo(right) <= 0;
	public static bool operator >=(SampleValueObjectGuid left, global::System.Guid right) => left.Value.CompareTo(right) >= 0;

	public static SampleValueObjectGuid NewId() => From(global::System.Guid.NewGuid());

}

