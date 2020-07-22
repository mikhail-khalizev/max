using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.Tests.CodeGenerator.Dto
{
    public class TableDto
    {
        public List<LinkDto> Links { get; set; }
        public List<RowListDto> RowList { get; set; }
        public RectangleDto Rectangle { get; set; }
        public int PageNum { get; set; }
        public string Id { get; set; }
    }
}