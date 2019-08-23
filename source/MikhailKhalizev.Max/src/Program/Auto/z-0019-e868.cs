using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_e868-14bb36a7")]
        public void Method_0019_e868()
        {
            ii(0x19_e868, 4); enter(0x6, 0);                            /* enter 0x6, 0x0 */
            ii(0x19_e86c, 1); push(di);                                 /* push di */
            ii(0x19_e86d, 1); push(si);                                 /* push si */
            ii(0x19_e86e, 5); mov(memw[ss, bp - 0x6], 0);               /* mov word [bp-0x6], 0x0 */
            ii(0x19_e873, 3); jmp(0x19_e879, 0x3); goto l_0x19_e879;    /* jmp 0xe879 */
        l_0x19_e876:
            ii(0x19_e876, 3); inc(memw[ss, bp - 0x6]);                  /* inc word [bp-0x6] */
        l_0x19_e879:
            ii(0x19_e879, 4); cmp(memw[ss, bp - 0x6], 0xa);             /* cmp word [bp-0x6], 0xa */
            ii(0x19_e87d, 2); if(jl(0x19_e882, 0x3)) goto l_0x19_e882;  /* jl 0xe882 */
            ii(0x19_e87f, 3); jmp(0x19_e8d9, 0x57); goto l_0x19_e8d9;   /* jmp 0xe8d9 */
        l_0x19_e882:
            ii(0x19_e882, 3); mov(bx, memw[ss, bp - 0x6]);              /* mov bx, [bp-0x6] */
            ii(0x19_e885, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x19_e888, 4); push(memw[ds, bx + 0x2d10]);              /* push word [bx+0x2d10] */
            ii(0x19_e88c, 4); push(memw[ds, bx + 0x2d0e]);              /* push word [bx+0x2d0e] */
            ii(0x19_e890, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x19_e893, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_e896, 5); call_far_abs(0x80, 0x5a20);               /* call word 0x80:0x5a20 */
            ii(0x19_e89b, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_e89e, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_e8a1, 3); mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_e8a4, 3); mov(ax, memw[ss, bp - 0x2]);              /* mov ax, [bp-0x2] */
            ii(0x19_e8a7, 3); or(ax, memw[ss, bp - 0x4]);               /* or ax, [bp-0x4] */
            ii(0x19_e8aa, 2); if(jz(0x19_e8af, 0x3)) goto l_0x19_e8af;  /* jz 0xe8af */
            ii(0x19_e8ac, 3); jmp(0x19_e8bf, 0x10); goto l_0x19_e8bf;   /* jmp 0xe8bf */
        l_0x19_e8af:
            ii(0x19_e8af, 4); cmp(memw[ss, bp - 0x6], 0x7);             /* cmp word [bp-0x6], 0x7 */
            ii(0x19_e8b3, 2); if(jl(0x19_e8b8, 0x3)) goto l_0x19_e8b8;  /* jl 0xe8b8 */
            ii(0x19_e8b5, 3); jmp(0x19_e8bf, 0x7); goto l_0x19_e8bf;    /* jmp 0xe8bf */
        l_0x19_e8b8:
            ii(0x19_e8b8, 3); mov(ax, memw[ss, bp - 0x6]);              /* mov ax, [bp-0x6] */
            ii(0x19_e8bb, 1); inc(ax);                                  /* inc ax */
            ii(0x19_e8bc, 3); jmp(0x19_e8ef, 0x30); goto l_0x19_e8ef;   /* jmp 0xe8ef */
        l_0x19_e8bf:
            ii(0x19_e8bf, 3); mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x19_e8c2, 3); mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x19_e8c5, 3); mov(si, memw[ss, bp - 0x6]);              /* mov si, [bp-0x6] */
            ii(0x19_e8c8, 3); shl(si, 0x2);                             /* shl si, 0x2 */
            ii(0x19_e8cb, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x19_e8ce, 4); mov(memw[es, bx + si + 0x4], ax);         /* mov [es:bx+si+0x4], ax */
            ii(0x19_e8d2, 4); mov(memw[es, bx + si + 0x6], dx);         /* mov [es:bx+si+0x6], dx */
            ii(0x19_e8d6, 3); jmp(0x19_e876, -0x63); goto l_0x19_e876;  /* jmp 0xe876 */
        l_0x19_e8d9:
            ii(0x19_e8d9, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x19_e8dc, 3); mov(dx, memw[ss, bp + 0x8]);              /* mov dx, [bp+0x8] */
            ii(0x19_e8df, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x19_e8e2, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x19_e8e5, 4); mov(memw[es, bx + 0x2], dx);              /* mov [es:bx+0x2], dx */
            ii(0x19_e8e9, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_e8ec, 3); jmp(0x19_e8ef, 0); goto l_0x19_e8ef;      /* jmp 0xe8ef */
        l_0x19_e8ef:
            ii(0x19_e8ef, 1); pop(si);                                  /* pop si */
            ii(0x19_e8f0, 1); pop(di);                                  /* pop di */
            ii(0x19_e8f1, 1); leave();                                  /* leave */
            ii(0x19_e8f2, 1); retf();                                   /* retf */
        }
    }
}
