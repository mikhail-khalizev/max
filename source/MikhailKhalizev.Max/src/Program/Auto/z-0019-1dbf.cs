using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2bb9ed2f-cdf2-4e16-8406-8f0feaf63b8d")]
        public void Method_0019_1dbf()
        {
            ii(0x19_1dbf, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x19_1dc3, 3); mov(ax, 0x3adc);                          /* mov ax, 0x3adc */
            ii(0x19_1dc6, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_1dc9, 3); mov(memw_a16[ss, bp - 0x2], ds);          /* mov [bp-0x2], ds */
            ii(0x19_1dcc, 4); cmp(memw_a16[ss, bp + 0xa], 0);           /* cmp word [bp+0xa], 0x0 */
            ii(0x19_1dd0, 2); if(jzw(0x19_1de4, 0x12)) goto l_0x19_1de4; /* jz 0x1de4 */
            ii(0x19_1dd2, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_1dd5, 1); pushw(ds);                                /* push ds */
            ii(0x19_1dd6, 1); pushw(ax);                                /* push ax */
            ii(0x19_1dd7, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_1dda, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_1ddd, 1); nop();                                    /* nop */
            ii(0x19_1dde, 1); pushw(cs);                                /* push cs */
            ii(0x19_1ddf, 3); callw(0x19_326e, 0x148c);                 /* call 0x326e */
            ii(0x19_1de2, 2); jmpw(0x19_1df6, 0x12); goto l_0x19_1df6;  /* jmp 0x1df6 */
        l_0x19_1de4:
            ii(0x19_1de4, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_1de7, 1); pushw(ds);                                /* push ds */
            ii(0x19_1de8, 3); pushw(0x3adc);                            /* push 0x3adc */
            ii(0x19_1deb, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_1dee, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_1df1, 1); nop();                                    /* nop */
            ii(0x19_1df2, 1); pushw(cs);                                /* push cs */
            ii(0x19_1df3, 3); callw(0x19_3278, 0x1482);                 /* call 0x3278 */
        l_0x19_1df6:
            ii(0x19_1df6, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_1df9, 2); jmpw(0x19_1e0b, 0x10); goto l_0x19_1e0b;  /* jmp 0x1e0b */
        l_0x19_1dfb:
            ii(0x19_1dfb, 2); cmp(al, 0x61);                            /* cmp al, 0x61 */
            ii(0x19_1dfd, 2); if(jlw(0x19_1e08, 0x9)) goto l_0x19_1e08; /* jl 0x1e08 */
            ii(0x19_1dff, 2); cmp(al, 0x66);                            /* cmp al, 0x66 */
            ii(0x19_1e01, 2); if(jgw(0x19_1e08, 0x5)) goto l_0x19_1e08; /* jg 0x1e08 */
            ii(0x19_1e03, 2); sub(al, 0x20);                            /* sub al, 0x20 */
            ii(0x19_1e05, 3); mov(memb_a16[es, bx], al);                /* mov [es:bx], al */
        l_0x19_1e08:
            ii(0x19_1e08, 3); inc(memw_a16[ss, bp - 0x4]);              /* inc word [bp-0x4] */
        l_0x19_1e0b:
            ii(0x19_1e0b, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x19_1e0e, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x19_1e11, 2); or(al, al);                               /* or al, al */
            ii(0x19_1e13, 2); if(jnzw(0x19_1dfb, -0x1a)) goto l_0x19_1dfb; /* jnz 0x1dfb */
            ii(0x19_1e15, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x19_1e17, 3); sub(ax, 0x3adc);                          /* sub ax, 0x3adc */
            ii(0x19_1e1a, 1); leavew();                                 /* leave */
            ii(0x19_1e1b, 1); retw(); return;                           /* ret */
        }
    }
}
