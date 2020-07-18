using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_488e-25c829cb")]
        public void Method_0017_488e()
        {
            ii(0x17_488e, 1);  push(ds);                               /* push ds */
            ii(0x17_488f, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_4892, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_4894, 4);  dec(memw[ds, 0xd8]);                    /* dec word [0xd8] */
            ii(0x17_4898, 1);  pop(ds);                                /* pop ds */
            ii(0x17_4899, 1);  retf();                                 /* retf */
        }
    }
}
