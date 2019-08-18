using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a7d53814-4ae7-4b83-a6b2-38e5e9ecf83c")]
        public void Method_0017_ef26()
        {
            ii(0x17_ef26, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x17_ef2a, 1); pushw(ds);                                /* push ds */
            ii(0x17_ef2b, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_ef2e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_ef30, 3); lea(ax, bp - 0x8);                        /* lea ax, [bp-0x8] */
            ii(0x17_ef33, 1); pushw(ss);                                /* push ss */
            ii(0x17_ef34, 1); pushw(ax);                                /* push ax */
            ii(0x17_ef35, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_ef38, 1); nop();                                    /* nop */
            ii(0x17_ef39, 1); pushw(cs);                                /* push cs */
            ii(0x17_ef3a, 3); callw(0x17_effa, 0xbd);                   /* call 0xeffa */
            ii(0x17_ef3d, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_ef40, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_ef42, 2); if(jnzw(0x17_ef4a, 0x6)) goto l_0x17_ef4a; /* jnz 0xef4a */
            ii(0x17_ef44, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x17_ef47, 1); popw(ds);                                 /* pop ds */
            ii(0x17_ef48, 1); leavew();                                 /* leave */
            ii(0x17_ef49, 1); retfw(); return;                          /* retf */
        l_0x17_ef4a:
            ii(0x17_ef4a, 3); mov(al, memb_a16[ss, bp - 0x3]);          /* mov al, [bp-0x3] */
            ii(0x17_ef4d, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_ef4f, 1); popw(ds);                                 /* pop ds */
            ii(0x17_ef50, 1); leavew();                                 /* leave */
            ii(0x17_ef51, 1); retfw(); return;                          /* retf */
        }
    }
}
