using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_c975-68f8f6fe")]
        public void Method_0019_c975()
        {
            ii(0x19_c975, 4); enter(0xa, 0);                            /* enter 0xa, 0x0 */
            ii(0x19_c979, 1); push(si);                                 /* push si */
            ii(0x19_c97a, 5); cmp(memw[ds, 0x2162], 0);                 /* cmp word [0x2162], 0x0 */
            ii(0x19_c97f, 2); if(jnz(0x19_c998, 0x17)) goto l_0x19_c998; /* jnz 0xc998 */
            ii(0x19_c981, 6); cmp(memw[ds, 0x2160], 0x80);              /* cmp word [0x2160], 0x80 */
            ii(0x19_c987, 2); if(jae(0x19_c998, 0xf)) goto l_0x19_c998; /* jae 0xc998 */
            ii(0x19_c989, 3); mov(ax, memw[ds, 0x2160]);                /* mov ax, [0x2160] */
            ii(0x19_c98c, 5); add(memw[ds, 0x2160], 1);                 /* add word [0x2160], 0x1 */
            ii(0x19_c991, 5); adc(memw[ds, 0x2162], 0);                 /* adc word [0x2162], 0x0 */
            ii(0x19_c996, 2); jmp(0x19_c9aa, 0x12); goto l_0x19_c9aa;   /* jmp 0xc9aa */
        l_0x19_c998:
            ii(0x19_c998, 1); push(ds);                                 /* push ds */
            ii(0x19_c999, 3); push(0x2829);                             /* push 0x2829 */
            ii(0x19_c99c, 3); push(0x8ff);                              /* push 0x8ff */
            ii(0x19_c99f, 3); call(0x1a_104e, 0x46ac);                  /* call 0x104e */
            ii(0x19_c9a2, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_c9a5, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_c9a7, 1); cwd();                                    /* cwd */
            ii(0x19_c9a8, 2); jmp(0x19_c9e2, 0x38); goto l_0x19_c9e2;   /* jmp 0xc9e2 */
        l_0x19_c9aa:
            ii(0x19_c9aa, 3); push(memw[ss, bp + 14]);                  /* push word [bp+0xe] */
            ii(0x19_c9ad, 3); push(memw[ss, bp + 12]);                  /* push word [bp+0xc] */
            ii(0x19_c9b0, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x19_c9b3, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_c9b6, 3); push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x19_c9b9, 3); imul(ax, ax, 0xc);                        /* imul ax, ax, 0xc */
            ii(0x19_c9bc, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x19_c9be, 3); add(ax, 0x2164);                          /* add ax, 0x2164 */
            ii(0x19_c9c1, 1); push(ds);                                 /* push ds */
            ii(0x19_c9c2, 1); push(ax);                                 /* push ax */
            ii(0x19_c9c3, 2); mov(si, cx);                              /* mov si, cx */
            ii(0x19_c9c5, 3); call(0x19_c860, -0x168);                  /* call 0xc860 */
            ii(0x19_c9c8, 3); mov(memw[ss, bp - 10], ax);               /* mov [bp-0xa], ax */
            ii(0x19_c9cb, 3); mov(memw[ss, bp - 8], dx);                /* mov [bp-0x8], dx */
            ii(0x19_c9ce, 3); mov(ax, memw[ss, bp + 4]);                /* mov ax, [bp+0x4] */
            ii(0x19_c9d1, 3); mov(dx, memw[ss, bp + 6]);                /* mov dx, [bp+0x6] */
            ii(0x19_c9d4, 4); mov(memw[ds, si + 8552], ax);             /* mov [si+0x2168], ax */
            ii(0x19_c9d8, 4); mov(memw[ds, si + 8554], dx);             /* mov [si+0x216a], dx */
            ii(0x19_c9dc, 3); mov(ax, memw[ss, bp - 10]);               /* mov ax, [bp-0xa] */
            ii(0x19_c9df, 3); mov(dx, memw[ss, bp - 8]);                /* mov dx, [bp-0x8] */
        l_0x19_c9e2:
            ii(0x19_c9e2, 1); pop(si);                                  /* pop si */
            ii(0x19_c9e3, 1); leave();                                  /* leave */
            ii(0x19_c9e4, 3); ret(0xc);                                 /* ret 0xc */
        }
    }
}
