using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_d619-b8086f4c")]
        public void Method_0018_d619()
        {
            ii(0x18_d619, 4); enter(0xa, 0);                            /* enter 0xa, 0x0 */
            ii(0x18_d61d, 1); push(si);                                 /* push si */
            ii(0x18_d61e, 3); mov(si, memw[ss, bp + 4]);                /* mov si, [bp+0x4] */
            ii(0x18_d621, 4); xor(si, memw[ds, 0x97c]);                 /* xor si, [0x97c] */
            ii(0x18_d625, 3); and(si, 7);                               /* and si, 0x7 */
            ii(0x18_d628, 4); xor(si, memw[ds, 0x97c]);                 /* xor si, [0x97c] */
            ii(0x18_d62c, 2); jmp(0x18_d662, 0x34); goto l_0x18_d662;   /* jmp 0xd662 */
        l_0x18_d62e:
            ii(0x18_d62e, 3); lea(ax, memw[ss, bp - 0xa]);              /* lea ax, [bp-0xa] */
            ii(0x18_d631, 1); push(ax);                                 /* push ax */
            ii(0x18_d632, 1); push(si);                                 /* push si */
            ii(0x18_d633, 3); call(0x18_dc8e, 0x658);                   /* call 0xdc8e */
            ii(0x18_d636, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d637, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d638, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_d63a, 2); if(jz(0x18_d662, 0x26)) goto l_0x18_d662; /* jz 0xd662 */
            ii(0x18_d63c, 4); test(memb[ss, bp - 2], 0x10);             /* test byte [bp-0x2], 0x10 */
            ii(0x18_d640, 2); if(jz(0x18_d662, 0x20)) goto l_0x18_d662; /* jz 0xd662 */
            ii(0x18_d642, 3); mov(ax, memw[ss, bp - 0xa]);              /* mov ax, [bp-0xa] */
            ii(0x18_d645, 3); mov(dx, memw[ss, bp - 8]);                /* mov dx, [bp-0x8] */
            ii(0x18_d648, 3); sub(ax, memw[ss, bp + 6]);                /* sub ax, [bp+0x6] */
            ii(0x18_d64b, 3); sbb(dx, memw[ss, bp + 8]);                /* sbb dx, [bp+0x8] */
            ii(0x18_d64e, 3); mov(cx, memw[ss, bp + 0xa]);              /* mov cx, [bp+0xa] */
            ii(0x18_d651, 2); sub(bx, bx);                              /* sub bx, bx */
            ii(0x18_d653, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x18_d655, 2); if(ja(0x18_d662, 0xb)) goto l_0x18_d662;  /* ja 0xd662 */
            ii(0x18_d657, 2); if(jb(0x18_d65d, 4)) goto l_0x18_d65d;    /* jb 0xd65d */
            ii(0x18_d659, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x18_d65b, 2); if(ja(0x18_d662, 5)) goto l_0x18_d662;    /* ja 0xd662 */
        l_0x18_d65d:
            ii(0x18_d65d, 1); push(si);                                 /* push si */
            ii(0x18_d65e, 3); call(0x18_dd01, 0x6a0);                   /* call 0xdd01 */
            ii(0x18_d661, 1); pop(bx);                                  /* pop bx */
        l_0x18_d662:
            ii(0x18_d662, 3); sub(si, 8);                               /* sub si, 0x8 */
            ii(0x18_d665, 4); cmp(si, memw[ds, 0xc34]);                 /* cmp si, [0xc34] */
            ii(0x18_d669, 2); if(jae(0x18_d62e, -0x3d)) goto l_0x18_d62e; /* jae 0xd62e */
            ii(0x18_d66b, 1); pop(si);                                  /* pop si */
            ii(0x18_d66c, 1); leave();                                  /* leave */
            ii(0x18_d66d, 1); ret();                                    /* ret */
        }
    }
}
