using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7ae99f62-03b6-4507-80aa-f5fff7c15635")]
        public void sys_int_paging_fault()
        {
            ii(0x13_94f6, 3); if(jmpw_func(0x13_93c8, -0x131)) return;  /* jmp 0x93c8 */
        }
    }
}