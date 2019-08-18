using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b73c6b14-4b14-435a-b0d3-32aade186df4")]
        public void Method_0017_e7a8()
        {
            ii(0x17_e7a8, 4); enterw(0x18, 0);                          /* enter 0x18, 0x0 */
            ii(0x17_e7ac, 1); pushw(ds);                                /* push ds */
            ii(0x17_e7ad, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_e7b0, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_e7b2, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_e7b5, 1); dec(ax);                                  /* dec ax */
            ii(0x17_e7b6, 3); shr(ax, 0x4);                             /* shr ax, 0x4 */
            ii(0x17_e7b9, 1); inc(ax);                                  /* inc ax */
            ii(0x17_e7ba, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_e7bd, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_e7bf, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x17_e7c2, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x17_e7c5, 1); pushw(ax);                                /* push ax */
            ii(0x17_e7c6, 1); pushw(ax);                                /* push ax */
            ii(0x17_e7c7, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x17_e7ca, 1); pushw(ss);                                /* push ss */
            ii(0x17_e7cb, 1); pushw(ax);                                /* push ax */
            ii(0x17_e7cc, 3); pushw(0x4800);                            /* push 0x4800 */
            ii(0x17_e7cf, 1); nop();                                    /* nop */
            ii(0x17_e7d0, 1); pushw(cs);                                /* push cs */
            ii(0x17_e7d1, 3); callw(0x17_eb40, 0x36c);                  /* call 0xeb40 */
            ii(0x17_e7d4, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_e7d7, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_e7d9, 2); if(jzw(0x17_e7e1, 0x6)) goto l_0x17_e7e1; /* jz 0xe7e1 */
            ii(0x17_e7db, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x17_e7de, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
        l_0x17_e7e1:
            ii(0x17_e7e1, 3); mov(ax, memw_a16[ss, bp - 0x18]);         /* mov ax, [bp-0x18] */
            ii(0x17_e7e4, 3); mov(dx, memw_a16[ss, bp - 0x16]);         /* mov dx, [bp-0x16] */
            ii(0x17_e7e7, 1); popw(ds);                                 /* pop ds */
            ii(0x17_e7e8, 1); leavew();                                 /* leave */
            ii(0x17_e7e9, 1); retfw(); return;                          /* retf */
        }
    }
}
