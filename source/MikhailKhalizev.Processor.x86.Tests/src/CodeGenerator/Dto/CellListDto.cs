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

            var middle = " ";
            if (left.EndsWith("/"))
                middle = "";

            return left + middle + right;
        }
    }
}