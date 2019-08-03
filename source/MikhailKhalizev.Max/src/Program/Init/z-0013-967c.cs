using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9c78db23-1832-405f-8302-14c0dc22ed7e")]
        public void Method_0013_967c()
        {
            ii(0x13_967c, 1); cli();                                    /* cli */
            ii(0x13_967d, 1); cld();                                    /* cld */
            ii(0x13_967e, 1); pushw(ds);                                /* push ds */
            ii(0x13_967f, 1); pushw(bx);                                /* push bx */
            ii(0x13_9680, 3); pushw(0x3e68);                            /* push 0x3e68 */
            ii(0x13_9683, 1); popw(ds);                                 /* pop ds */
            ii(0x13_9684, 4); mov(memw_a16[ds, 0x5196], ss);            /* mov [0x5196], ss */
            ii(0x13_9688, 5); mov(memd_a16[ds, 0x1fd8], esp);           /* mov [0x1fd8], esp */
            ii(0x13_968d, 1); nop();                                    /* nop */
            ii(0x13_968e, 1); pushw(cs);                                /* push cs */
            ii(0x13_968f, 3); callw(0x13_7582, -0x2110);                /* call 0x7582 */
            ii(0x13_9692, 6); mov(eax, 0x3fe);                          /* mov eax, 0x3fe */
            ii(0x13_9698, 2); mov(ss, dx);                              /* mov ss, dx */
            ii(0x13_969a, 3); mov(esp, eax);                            /* mov esp, eax */
            ii(0x13_969d, 1); cld();                                    /* cld */
            ii(0x13_969e, 1); nop();                                    /* nop */
            ii(0x13_969f, 1); pushw(cs);                                /* push cs */
            ii(0x13_96a0, 3); callw(0x13_4ac4, -0x4bdf);                /* call 0x4ac4 */
            ii(0x13_96a3, 1); cli();                                    /* cli */
            ii(0x13_96a4, 2); mov(bx, ss);                              /* mov bx, ss */
            ii(0x13_96a6, 4); mov(ss, memw_a16[ds, 0x5196]);            /* mov ss, [0x5196] */
            ii(0x13_96aa, 5); mov(esp, memd_a16[ds, 0x1fd8]);           /* mov esp, [0x1fd8] */
            ii(0x13_96af, 1); popw(bx);                                 /* pop bx */
            ii(0x13_96b0, 1); popw(ds);                                 /* pop ds */
            ii(0x13_96b1, 1); retfw(); return;                          /* retf */
        }
    }
}
