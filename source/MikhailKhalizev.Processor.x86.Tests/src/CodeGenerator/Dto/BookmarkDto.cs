using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.Tests.CodeGenerator
{
    public class BookmarkDto
    {
        public string Title { get; set; }
        public int PageNumber { get; set; }
        public List<BookmarkDto> Children { get; set; }
    }
}