using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_967c-dfa201c5")]
        public void Method_0017_967c()
        {
            ii(0x17_967c, 1); cli();                                    /* cli */
            ii(0x17_967d, 1); cld();                                    /* cld */
            ii(0x17_967e, 1); push(ds);                                 /* push ds */
            ii(0x17_967f, 1); push(bx);                                 /* push bx */
            ii(0x17_9680, 3); push(0x3e68);                             /* push 0x3e68 */
            ii(0x17_9683, 1); pop(ds);                                  /* pop ds */
            ii(0x17_9684, 4); mov(memw[ds, 0x5196], ss);                /* mov [0x5196], ss */
            ii(0x17_9688, 5); mov(memd[ds, 0x1fd8], esp);               /* mov [0x1fd8], esp */
            ii(0x17_968d, 1); nop();                                    /* nop */
            ii(0x17_968e, 1); push(cs);                                 /* push cs */
            ii(0x17_968f, 3); call(0x17_7582, -0x2110);                 /* call 0x7582 */
            ii(0x17_9692, 6); mov(eax, 0x3fe);                          /* mov eax, 0x3fe */
            ii(0x17_9698, 2); mov(ss, dx);                              /* mov ss, dx */
            ii(0x17_969a, 3); mov(esp, eax);                            /* mov esp, eax */
            ii(0x17_969d, 1); cld();                                    /* cld */
            ii(0x17_969e, 1); nop();                                    /* nop */
            ii(0x17_969f, 1); push(cs);                                 /* push cs */
            ii(0x17_96a0, 3); call(0x17_4ac4, -0x4bdf);                 /* call 0x4ac4 */
            ii(0x17_96a3, 1); cli();                                    /* cli */
            ii(0x17_96a4, 2); mov(bx, ss);                              /* mov bx, ss */
            ii(0x17_96a6, 4); mov(ss, memw[ds, 0x5196]);                /* mov ss, [0x5196] */
            ii(0x17_96aa, 5); mov(esp, memd[ds, 0x1fd8]);               /* mov esp, [0x1fd8] */
            ii(0x17_96af, 1); pop(bx);                                  /* pop bx */
            ii(0x17_96b0, 1); pop(ds);                                  /* pop ds */
            ii(0x17_96b1, 1); retf();                                   /* retf */
        }
    }
}
