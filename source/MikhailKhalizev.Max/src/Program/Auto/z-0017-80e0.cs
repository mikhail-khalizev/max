using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_80e0-c8d62f9f")]
        public void Method_0017_80e0()
        {
            ii(0x17_80e0, 1); push(bp);                                 /* push bp */
            ii(0x17_80e1, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_80e3, 1); push(ds);                                 /* push ds */
            ii(0x17_80e4, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_80e7, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_80e9, 5); cmp(memb[ds, 0xa2a], 0);                  /* cmp byte [0xa2a], 0x0 */
            ii(0x17_80ee, 2); if(jz(0x17_80fc, 0xc)) goto l_0x17_80fc;  /* jz 0x80fc */
            ii(0x17_80f0, 4); les(bx, memw[ds, 0xa26]);                 /* les bx, [0xa26] */
            ii(0x17_80f4, 4); mov(ax, memw[es, bx + 16]);               /* mov ax, [es:bx+0x10] */
            ii(0x17_80f8, 1); pop(ds);                                  /* pop ds */
            ii(0x17_80f9, 1); leave();                                  /* leave */
            ii(0x17_80fa, 1); retf(); return;                           /* retf */
        //  ii(0x17_80fb, 1); Недостижимый код.
        l_0x17_80fc:
            ii(0x17_80fc, 2); mov(ah, 0x51);                            /* mov ah, 0x51 */
            ii(0x17_80fe, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_8100, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x17_8102, 1); pop(ds);                                  /* pop ds */
            ii(0x17_8103, 1); leave();                                  /* leave */
            ii(0x17_8104, 1); retf();                                   /* retf */
        }
    }
}
