using Newtonsoft.Json.Linq;

namespace MikhailKhalizev.Processor.x86.Tests.CodeGenerator
{
    public class PageRawDto
    {
        public string CreationDate { get; set; }
        public string ModDate { get; set; }
        public int Number { get; set; }
        public JToken Tables { get; set; }
        public JToken Texts { get; set; }
    }
}