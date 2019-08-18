using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7e8ec295-8626-4b12-af3f-661093c6e614")]
        public void Method_0017_e276()
        {
            ii(0x17_e276, 1); pushw(bp);                                /* push bp */
            ii(0x17_e277, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_e279, 1); pushw(di);                                /* push di */
            ii(0x17_e27a, 1); pushw(si);                                /* push si */
            ii(0x17_e27b, 1); pushw(ds);                                /* push ds */
            ii(0x17_e27c, 1); popw(es);                                 /* pop es */
            ii(0x17_e27d, 3); mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x17_e280, 2); if(jcxzw(0x17_e2a8, 0x26)) goto l_0x17_e2a8; /* jcxz 0xe2a8 */
            ii(0x17_e282, 2); mov(bx, cx);                              /* mov bx, cx */
            ii(0x17_e284, 3); mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0x17_e287, 2); mov(si, di);                              /* mov si, di */
            ii(0x17_e289, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_e28b, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x17_e28d, 2); neg(cx);                                  /* neg cx */
            ii(0x17_e28f, 2); add(cx, bx);                              /* add cx, bx */
            ii(0x17_e291, 2); mov(di, si);                              /* mov di, si */
            ii(0x17_e293, 3); mov(si, memw_a16[ss, bp + 0x8]);          /* mov si, [bp+0x8] */
            ii(0x17_e296, 2); repe_a16(() => cmpsb_a16());              /* repe cmpsb */
            ii(0x17_e298, 3); mov(al, memb_a16[ds, si - 0x1]);          /* mov al, [si-0x1] */
            ii(0x17_e29b, 2); xor(cx, cx);                              /* xor cx, cx */
            ii(0x17_e29d, 3); cmp(al, memb_a16[ds, di - 0x1]);          /* cmp al, [di-0x1] */
            ii(0x17_e2a0, 2); if(jaw(0x17_e2a6, 0x4)) goto l_0x17_e2a6; /* ja 0xe2a6 */
            ii(0x17_e2a2, 2); if(jzw(0x17_e2a8, 0x4)) goto l_0x17_e2a8; /* jz 0xe2a8 */
            ii(0x17_e2a4, 1); dec(cx);                                  /* dec cx */
            ii(0x17_e2a5, 1); dec(cx);                                  /* dec cx */
        l_0x17_e2a6:
            ii(0x17_e2a6, 2); not(cx);                                  /* not cx */
        l_0x17_e2a8:
            ii(0x17_e2a8, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x17_e2aa, 1); popw(si);                                 /* pop si */
            ii(0x17_e2ab, 1); popw(di);                                 /* pop di */
            ii(0x17_e2ac, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x17_e2ae, 1); popw(bp);                                 /* pop bp */
            ii(0x17_e2af, 1); retfw(); return;                          /* retf */
        }
    }
}
