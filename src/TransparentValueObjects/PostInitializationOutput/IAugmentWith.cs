using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace TransparentValueObjects.PostInitializationOutput;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class IAugmentWith
{
    private const int TypeParameterCount = 10;

    public const string Name = nameof(IAugmentWith);
    public const string GlobalName = $"global::{Constants.Namespace}.{Name}";
    public const string HintName = $"{Name}.g.cs";

    public static string Generate()
    {
        var cw = new CodeWriter();

        cw.AppendLine(Constants.AutoGeneratedHeader);
        cw.AppendLine();

        cw.AppendLine($"namespace {Constants.Namespace}");
        using (cw.AddBlock())
        {
            for (var i = 0; i < TypeParameterCount; i++)
            {
                cw.AppendLine("/// <summary>");
                cw.AppendLine("/// Augment the value object with additional functionality.");
                cw.AppendLine("/// </summary>");

                for (var j = 0; j <= i; j++)
                {
                    cw.AppendLine($"/// <typeparam name=\"T{j.ToString(CultureInfo.InvariantCulture)}\">The type of augment you want to apply to the value object.</typeparam>");
                }

                cw.Append($"public interface {Name}<");
                for (var j = 0; j <= i; j++)
                {
                    if (j != 0) cw.Append(",");
                    cw.Append($"T{j.ToString(CultureInfo.InvariantCulture)}");
                }
                cw.AppendLine(">");

                for (var j = 0; j <= i; j++)
                {
                    cw.AppendLine($"\twhere T{j.ToString(CultureInfo.InvariantCulture)} : {IAugment.GlobalName}");
                }

                cw.AppendLine("{ }");
                cw.AppendLine();
            }
        }

        return cw.ToString();
    }
}
