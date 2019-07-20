using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;

namespace MikhailKhalizev.Processor.x86.Tests.CodeGenerator
{
    [DebuggerDisplay("Text = {Text}")]
    public class CellListDto
    {
        public TextRectsDto TextRects { get; set; }
        public RectangleDto Rectangle { get; set; }

        [JsonIgnore]
        public string Text => TextRects.List.Aggregate("", (s, dto) => CombineString(s, dto.Text)).Trim();

        public static string CombineString(string a, string b)
        {
            var left = a.TrimEnd();
            var right = b.TrimStart();

            var middle = 
                left.EndsWith("/") || left.EndsWith("-") ||
                right.StartsWith("-") || right.StartsWith(",") || right.StartsWith("*") ? "" : " ";

            var result = left + middle + right;

            result = result
                .Replace("Val id", "Valid")
                .Replace("Comp are", "Compare")
                .Replace("Mov e", "Move");

            return result;
        }
    }
}