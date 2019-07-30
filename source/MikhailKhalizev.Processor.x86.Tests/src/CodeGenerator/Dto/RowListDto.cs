using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.Tests.CodeGenerator.Dto
{
    public class RowListDto
    {
        public List<CellListDto> CellList { get; set; }
        public RectangleDto Rectangle { get; set; }
    }
}