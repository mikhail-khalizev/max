using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xe0da-f55b8fa9")]
        public void Method_0000_e0da()
        {
            ii(0xe0da, 1);    int3();                                   /* int3 */
            ii(0xe0db, 3);    mov(ax, 0x4c00);                          /* mov ax, 0x4c00 */
            ii(0xe0de, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xe0e0, 5);    mov(memb_a16[ds, 0x10f0], 0);             /* mov byte [0x10f0], 0x0 */
            ii(0xe0e5, 1);    pusha();                                  /* pusha */
            ii(0xe0e6, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xe0e8, 1);    pushw(ss);                                /* push ss */
            ii(0xe0e9, 3);    lea(ax, bp + 0x40);                       /* lea ax, [bp+0x40] */
            ii(0xe0ec, 1);    pushw(ax);                                /* push ax */
            ii(0xe0ed, 3);    callw(0xe08c, -0x64);                     /* call 0xe08c */
            ii(0xe0f0, 2);    mov(si, cx);                              /* mov si, cx */
            ii(0xe0f2, 1);    pushw(dx);                                /* push dx */
            ii(0xe0f3, 1);    pushw(ax);                                /* push ax */
            ii(0xe0f4, 4);    callw_a16_far_ind(ds, 0x16);              /* call far word [0x16] */
            ii(0xe0f8, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0xe0fb, 2);    or(si, si);                               /* or si, si */
            ii(0xe0fd, 2);    if(jzw(0xe107, 0x8)) goto l_0xe107;       /* jz 0xe107 */
            ii(0xe0ff, 4);    mov(cx, memw_a16[ss, si + 0x4]);          /* mov cx, [ss:si+0x4] */
            ii(0xe103, 4);    mov(si, memw_a16[ss, si + 0x6]);          /* mov si, [ss:si+0x6] */
        l_0xe107:
            ii(0xe107, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xe109, 3);    sub(ax, 0x1c);                            /* sub ax, 0x1c */
            ii(0xe10c, 2);    or(cx, cx);                               /* or cx, cx */
            ii(0xe10e, 2);    if(jzw(0xe116, 0x6)) goto l_0xe116;       /* jz 0xe116 */
            ii(0xe110, 3);    mov(memw_a16[ss, bp + 0x32], cx);         /* mov [bp+0x32], cx */
            ii(0xe113, 3);    mov(memw_a16[ss, bp + 0x34], si);         /* mov [bp+0x34], si */
        l_0xe116:
            ii(0xe116, 3);    mov(memw_a16[ss, bp + 0x3c], ax);         /* mov [bp+0x3c], ax */
            ii(0xe119, 3);    mov(memw_a16[ss, bp + 0x3e], dx);         /* mov [bp+0x3e], dx */
            ii(0xe11c, 5);    mov(memw_a16[ss, bp + 0x36], 0x657);      /* mov word [bp+0x36], 0x657 */
            ii(0xe121, 3);    mov(memw_a16[ss, bp + 0x38], cs);         /* mov [bp+0x38], cs */
            ii(0xe124, 1);    popa();                                   /* popa */
            ii(0xe125, 1);    popw(di);                                 /* pop di */
            ii(0xe126, 1);    popw(si);                                 /* pop si */
            ii(0xe127, 1);    popw(dx);                                 /* pop dx */
            ii(0xe128, 1);    popw(bp);                                 /* pop bp */
            ii(0xe129, 3);    add(sp, 0xc);                             /* add sp, 0xc */
            ii(0xe12c, 2);    @int(0x24);                               /* int 0x24 */
            ii(0xe12e, 1);    pusha();                                  /* pusha */
            ii(0xe12f, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xe131, 1);    pushw(ss);                                /* push ss */
            ii(0xe132, 3);    lea(ax, bp + 0x10);                       /* lea ax, [bp+0x10] */
            ii(0xe135, 1);    pushw(ax);                                /* push ax */
            ii(0xe136, 3);    pushw(memw_a16[ss, bp + 0x2a]);           /* push word [bp+0x2a] */
            ii(0xe139, 3);    pushw(memw_a16[ss, bp + 0x28]);           /* push word [bp+0x28] */
            ii(0xe13c, 4);    callw_a16_far_ind(ds, 0x16);              /* call far word [0x16] */
            ii(0xe140, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0xe143, 1);    popa();                                   /* popa */
            ii(0xe144, 3);    if(jmpw_func(0xe05a, -0xed)) return;      /* jmp 0xe05a */
        }
    }
}
