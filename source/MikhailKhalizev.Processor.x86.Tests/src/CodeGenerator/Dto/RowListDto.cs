﻿using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.Tests.CodeGenerator
{
    public class RowListDto
    {
        public IList<CellListDto> CellList { get; set; }
        public RectangleDto Rectangle { get; set; }
    }
}