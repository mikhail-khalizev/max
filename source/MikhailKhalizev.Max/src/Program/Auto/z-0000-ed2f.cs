using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c966a08f-98c2-4c99-a5c9-34270856bdf6")]
        public void Method_0000_ed2f()
        {
            ii(0xed2f, 5);    cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0xed34, 2);    if(jzw(0xed77, 0x41)) goto l_0xed77;      /* jz 0xada7 */
            ii(0xed36, 3);    mov(ax, memw_a16[ds, 0xc10]);             /* mov ax, [0xc10] */
            ii(0xed39, 4);    mov(dx, memw_a16[ds, 0xc12]);             /* mov dx, [0xc12] */
        l_0xed3d:
            ii(0xed3d, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0xed3f, 2);    or(bx, dx);                               /* or bx, dx */
            ii(0xed41, 2);    if(jzw(0xed5c, 0x19)) goto l_0xed5c;      /* jz 0xad8c */
            ii(0xed43, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0xed45, 2);    mov(si, dx);                              /* mov si, dx */
            ii(0xed47, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xed49, 1);    pushw(dx);                                /* push dx */
            ii(0xed4a, 1);    pushw(ax);                                /* push ax */
            ii(0xed4b, 3);    callw(0x1_1b21, 0x2dd3);                  /* call 0xdb51 */
            ii(0xed4e, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xed51, 1);    pushw(dx);                                /* push dx */
            ii(0xed52, 1);    pushw(ax);                                /* push ax */
            ii(0xed53, 3);    mov(ax, 0x502);                           /* mov ax, 0x502 */
            ii(0xed56, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xed58, 1);    popw(ax);                                 /* pop ax */
            ii(0xed59, 1);    popw(dx);                                 /* pop dx */
            ii(0xed5a, 2);    jmpw(0xed3d, -0x1f); goto l_0xed3d;       /* jmp 0xad6d */
        l_0xed5c:
            ii(0xed5c, 3);    callw(0xed08, -0x57);                     /* call 0xad38 */
            ii(0xed5f, 6);    mov(memw_a16[ds, 0x99e], 0);              /* mov word [0x99e], 0x0 */
            ii(0xed65, 4);    sub(memw_a16[ss, bp + 0x1e], 0x2);        /* sub word [bp+0x1e], 0x2 */
            ii(0xed69, 3);    lea(sp, bp + 0x4);                        /* lea sp, [bp+0x4] */
            ii(0xed6c, 1);    popw(ds);                                 /* pop ds */
            ii(0xed6d, 1);    popw(es);                                 /* pop es */
            ii(0xed6e, 1);    popa();                                   /* popa */
            ii(0xed6f, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xed72, 5);    if(jmpw_far_abs(0x18, 0x10ee)) return;    /* jmp word 0x18:0x10ee */
        l_0xed77:
            ii(0xed77, 3);    mov(ax, memw_a16[ss, bp + 0x16]);         /* mov ax, [bp+0x16] */
            ii(0xed7a, 1);    pushw(ax);                                /* push ax */
            ii(0xed7b, 1);    pushw(ax);                                /* push ax */
            ii(0xed7c, 4);    pushw(memw_a16[ds, 0xc26]);               /* push word [0xc26] */
            ii(0xed80, 3);    pushw(0x71fc);                            /* push 0x71fc */
            ii(0xed83, 1);    retfw(); return;                          /* retf */
        }
    }
}
