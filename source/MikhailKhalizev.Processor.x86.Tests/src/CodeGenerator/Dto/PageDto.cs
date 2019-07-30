using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.Tests.CodeGenerator.Dto
{
    public class PageDto
    {
        public string CreationDate { get; set; }
        public string ModDate { get; set; }
        public int Number { get; set; }
        public IList<TableDto> Tables { get; set; }
        public IList<TextDto> Texts { get; set; }
    }
}