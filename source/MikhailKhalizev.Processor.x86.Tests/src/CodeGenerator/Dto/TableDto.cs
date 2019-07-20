using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.Tests.CodeGenerator
{
    public class TableDto
    {
        public IList<LinkDto> Links { get; set; }
        public IList<RowListDto> RowList { get; set; }
        public RectangleDto Rectangle { get; set; }
        public int PageNum { get; set; }
        public string Id { get; set; }
    }
}