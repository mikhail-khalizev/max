using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b4bda471-325d-4fac-b7d7-f8ea24ff5a8e")]
        public void Method_0019_4874()
        {
            ii(0x19_4874, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x19_4878, 1); pushw(ds);                                /* push ds */
            ii(0x19_4879, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_487c, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_487e, 5); mov(memw_a16[ss, bp - 0x6], 0x800);       /* mov word [bp-0x6], 0x800 */
            ii(0x19_4883, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_4886, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x19_4889, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x19_488c, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x19_488f, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x19_4892, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_4895, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_4897, 3); mov(memw_a16[ss, bp + 0x8], ax);          /* mov [bp+0x8], ax */
            ii(0x19_489a, 3); mov(memw_a16[ss, bp + 0x6], ax);          /* mov [bp+0x6], ax */
            ii(0x19_489d, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x19_48a0, 1); pushw(ax);                                /* push ax */
            ii(0x19_48a1, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x19_48a4, 1); pushw(ss);                                /* push ss */
            ii(0x19_48a5, 1); pushw(ax);                                /* push ax */
            ii(0x19_48a6, 2); pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x19_48a8, 1); nop();                                    /* nop */
            ii(0x19_48a9, 1); pushw(cs);                                /* push cs */
            ii(0x19_48aa, 3); callw(0x19_4188, -0x725);                 /* call 0x4188 */
            ii(0x19_48ad, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_48b0, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_48b2, 2); if(jzw(0x19_48ba, 0x6)) goto l_0x19_48ba; /* jz 0x48ba */
            ii(0x19_48b4, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_48b7, 3); mov(memw_a16[ss, bp + 0x8], ax);          /* mov [bp+0x8], ax */
        l_0x19_48ba:
            ii(0x19_48ba, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_48bd, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x19_48c0, 1); popw(ds);                                 /* pop ds */
            ii(0x19_48c1, 1); leavew();                                 /* leave */
            ii(0x19_48c2, 1); retfw(); return;                          /* retf */
        }
    }
}
