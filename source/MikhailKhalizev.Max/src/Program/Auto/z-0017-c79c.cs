using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_c79c-19047fec")]
        public void Method_0017_c79c()
        {
            ii(0x17_c79c, 4); enter(0x4, 0);                            /* enter 0x4, 0x0 */
            ii(0x17_c7a0, 1); push(ds);                                 /* push ds */
            ii(0x17_c7a1, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_c7a4, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_c7a6, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_c7a8, 3); mov(memw[ss, bp - 0x2], ax);              /* mov [bp-0x2], ax */
            ii(0x17_c7ab, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
        l_0x17_c7ae:
            ii(0x17_c7ae, 3); mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x17_c7b1, 3); mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x17_c7b4, 4); cmp(memw[ds, 0x4fd2], dx);                /* cmp [0x4fd2], dx */
            ii(0x17_c7b8, 2); if(jb(0x17_c7ea, 0x30)) goto l_0x17_c7ea; /* jb 0xc7ea */
            ii(0x17_c7ba, 2); if(ja(0x17_c7c2, 0x6)) goto l_0x17_c7c2;  /* ja 0xc7c2 */
            ii(0x17_c7bc, 4); cmp(memw[ds, 0x4fd0], ax);                /* cmp [0x4fd0], ax */
            ii(0x17_c7c0, 2); if(jbe(0x17_c7ea, 0x28)) goto l_0x17_c7ea; /* jbe 0xc7ea */
        l_0x17_c7c2:
            ii(0x17_c7c2, 1); push(dx);                                 /* push dx */
            ii(0x17_c7c3, 1); push(ax);                                 /* push ax */
            ii(0x17_c7c4, 4); push(memw[ds, 0x4ff6]);                   /* push word [0x4ff6] */
            ii(0x17_c7c8, 4); push(memw[ds, 0x4ff4]);                   /* push word [0x4ff4] */
            ii(0x17_c7cc, 3); call(0x17_90c4, -0x370b);                 /* call 0x90c4 */
            ii(0x17_c7cf, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_c7d2, 3); cmp(ax, memw[ss, bp + 0x6]);              /* cmp ax, [bp+0x6] */
            ii(0x17_c7d5, 2); if(jnz(0x17_c7e0, 0x9)) goto l_0x17_c7e0; /* jnz 0xc7e0 */
            ii(0x17_c7d7, 3); mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x17_c7da, 3); mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x17_c7dd, 1); pop(ds);                                  /* pop ds */
            ii(0x17_c7de, 1); leave();                                  /* leave */
            ii(0x17_c7df, 1); retf(); return;                           /* retf */
        l_0x17_c7e0:
            ii(0x17_c7e0, 4); add(memw[ss, bp - 0x4], 0x1);             /* add word [bp-0x4], 0x1 */
            ii(0x17_c7e4, 4); adc(memw[ss, bp - 0x2], 0);               /* adc word [bp-0x2], 0x0 */
            ii(0x17_c7e8, 2); jmp(0x17_c7ae, -0x3c); goto l_0x17_c7ae;  /* jmp 0xc7ae */
        l_0x17_c7ea:
            ii(0x17_c7ea, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x17_c7ed, 1); cwd();                                    /* cwd */
            ii(0x17_c7ee, 1); pop(ds);                                  /* pop ds */
            ii(0x17_c7ef, 1); leave();                                  /* leave */
            ii(0x17_c7f0, 1); retf();                                   /* retf */
        }
    }
}
