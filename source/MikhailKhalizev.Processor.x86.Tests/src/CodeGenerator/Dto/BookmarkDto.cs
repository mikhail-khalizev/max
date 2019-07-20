using System.Collections.Generic;
using System.Diagnostics;

namespace MikhailKhalizev.Processor.x86.Tests.CodeGenerator
{
    [DebuggerDisplay("Title = {Title}, Page = {PageNumber}")]
    public class BookmarkDto
    {
        public string Title { get; set; }
        public int PageNumber { get; set; }
        public List<BookmarkDto> Children { get; set; }
    }
}