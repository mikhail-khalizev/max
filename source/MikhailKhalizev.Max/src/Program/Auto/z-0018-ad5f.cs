using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("37a02f10-07ea-495b-9054-d9e20bc2f656")]
        public void Method_0018_ad5f()
        {
            ii(0x18_ad5f, 5); cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0x18_ad64, 2); if(jzw(0x18_ada7, 0x41)) goto l_0x18_ada7; /* jz 0xada7 */
            ii(0x18_ad66, 3); mov(ax, memw_a16[ds, 0xc10]);             /* mov ax, [0xc10] */
            ii(0x18_ad69, 4); mov(dx, memw_a16[ds, 0xc12]);             /* mov dx, [0xc12] */
        l_0x18_ad6d:
            ii(0x18_ad6d, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x18_ad6f, 2); or(bx, dx);                               /* or bx, dx */
            ii(0x18_ad71, 2); if(jzw(0x18_ad8c, 0x19)) goto l_0x18_ad8c; /* jz 0xad8c */
            ii(0x18_ad73, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x18_ad75, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x18_ad77, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_ad79, 1); pushw(dx);                                /* push dx */
            ii(0x18_ad7a, 1); pushw(ax);                                /* push ax */
            ii(0x18_ad7b, 3); callw(0x18_db51, 0x2dd3);                 /* call 0xdb51 */
            ii(0x18_ad7e, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_ad81, 1); pushw(dx);                                /* push dx */
            ii(0x18_ad82, 1); pushw(ax);                                /* push ax */
            ii(0x18_ad83, 3); mov(ax, 0x502);                           /* mov ax, 0x502 */
            ii(0x18_ad86, 2); @int(0x31);                               /* int 0x31 */
            ii(0x18_ad88, 1); popw(ax);                                 /* pop ax */
            ii(0x18_ad89, 1); popw(dx);                                 /* pop dx */
            ii(0x18_ad8a, 2); jmpw(0x18_ad6d, -0x1f); goto l_0x18_ad6d; /* jmp 0xad6d */
        l_0x18_ad8c:
            ii(0x18_ad8c, 3); callw(0x18_ad38, -0x57);                  /* call 0xad38 */
            ii(0x18_ad8f, 6); mov(memw_a16[ds, 0x99e], 0);              /* mov word [0x99e], 0x0 */
            ii(0x18_ad95, 4); sub(memw_a16[ss, bp + 0x1e], 0x2);        /* sub word [bp+0x1e], 0x2 */
            ii(0x18_ad99, 3); lea(sp, bp + 0x4);                        /* lea sp, [bp+0x4] */
            ii(0x18_ad9c, 1); popw(ds);                                 /* pop ds */
            ii(0x18_ad9d, 1); popw(es);                                 /* pop es */
            ii(0x18_ad9e, 1); popa();                                   /* popa */
            ii(0x18_ad9f, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_ada2, 5); if(jmpw_far_abs(0x18, 0x10ee)) return;    /* jmp word 0x18:0x10ee */
        l_0x18_ada7:
            ii(0x18_ada7, 3); mov(ax, memw_a16[ss, bp + 0x16]);         /* mov ax, [bp+0x16] */
            ii(0x18_adaa, 1); pushw(ax);                                /* push ax */
            ii(0x18_adab, 1); pushw(ax);                                /* push ax */
            ii(0x18_adac, 4); pushw(memw_a16[ds, 0xc26]);               /* push word [0xc26] */
            ii(0x18_adb0, 3); pushw(0x71fc);                            /* push 0x71fc */
            ii(0x18_adb3, 1); retfw(); return;                          /* retf */
        }
    }
}
