using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("64e85887-74ae-44e3-bc60-75aa418ebcb7")]
        public void Method_0015_6131()
        {
            ii(0x15_6131, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x15_6135, 1); pushw(di);                                /* push di */
            ii(0x15_6136, 1); pushw(si);                                /* push si */
            ii(0x15_6137, 5); cmp(memb_a16[ds, 0xd81], 0);              /* cmp byte [0xd81], 0x0 */
            ii(0x15_613c, 2); if(jzw(0x15_6141, 0x3)) goto l_0x15_6141; /* jz 0x6141 */
            ii(0x15_613e, 3); jmpw(0x15_6147, 0x6); goto l_0x15_6147;   /* jmp 0x6147 */
        l_0x15_6141:
            ii(0x15_6141, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_6144, 3); jmpw(0x15_617f, 0x38); goto l_0x15_617f;  /* jmp 0x617f */
        l_0x15_6147:
            ii(0x15_6147, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_614a, 3); mov(al, memb_a16[ds, 0xd81]);             /* mov al, [0xd81] */
            ii(0x15_614d, 1); cbw();                                    /* cbw */
            ii(0x15_614e, 1); pushw(ax);                                /* push ax */
            ii(0x15_614f, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_6152, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_6155, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_6158, 1); pushw(ds);                                /* push ds */
            ii(0x15_6159, 3); pushw(0x12ac);                            /* push 0x12ac */
            ii(0x15_615c, 3); callw(0x15_1066, -0x50f9);                /* call 0x1066 */
            ii(0x15_615f, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x15_6162, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x15_6165, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x15_6167, 1); pushw(ax);                                /* push ax */
            ii(0x15_6168, 1); pushw(cx);                                /* push cx */
            ii(0x15_6169, 3); callw(0x14_fa6b, -0x6701);                /* call 0xfa6b */
            ii(0x15_616c, 4); cmp(memw_a16[ss, bp + 0xc], 0);           /* cmp word [bp+0xc], 0x0 */
            ii(0x15_6170, 2); if(jnzw(0x15_6175, 0x3)) goto l_0x15_6175; /* jnz 0x6175 */
            ii(0x15_6172, 3); jmpw(0x15_617f, 0xa); goto l_0x15_617f;   /* jmp 0x617f */
        l_0x15_6175:
            ii(0x15_6175, 3); mov(ax, memw_a16[ss, bp + 0xc]);          /* mov ax, [bp+0xc] */
            ii(0x15_6178, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x15_617a, 1); pushw(ax);                                /* push ax */
            ii(0x15_617b, 1); pushw(cx);                                /* push cx */
            ii(0x15_617c, 3); callw(0x14_fa6b, -0x6714);                /* call 0xfa6b */
        l_0x15_617f:
            ii(0x15_617f, 1); popw(si);                                 /* pop si */
            ii(0x15_6180, 1); popw(di);                                 /* pop di */
            ii(0x15_6181, 1); leavew();                                 /* leave */
            ii(0x15_6182, 1); retfw(); return;                          /* retf */
        }
    }
}
