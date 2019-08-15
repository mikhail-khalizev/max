using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("716e019f-26c8-4e01-ba38-ae711ebce342")]
        public void Method_0014_b5fc()
        {
            ii(0x14_b5fc, 2); cmp(al, 0);                               /* cmp al, 0x0 */
            ii(0x14_b5fe, 2); if(jzw_func(0x14_b5b2, -0x4e)) return;    /* jz 0xb5b2 */
            ii(0x14_b600, 1); pusha();                                  /* pusha */
            ii(0x14_b601, 1); pushw(es);                                /* push es */
            ii(0x14_b602, 1); pushw(ds);                                /* push ds */
            ii(0x14_b603, 2); xor(dx, dx);                              /* xor dx, dx */
            ii(0x14_b605, 1); pushw(dx);                                /* push dx */
            ii(0x14_b606, 1); pushw(dx);                                /* push dx */
            ii(0x14_b607, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x14_b609, 5); mov(ds, memw_a16[cs, 0x5680]);            /* mov ds, [cs:0x5680] */
            ii(0x14_b60e, 2); xor(al, al);                              /* xor al, al */
            ii(0x14_b610, 2); @int(0x10);                               /* int 0x10 */
            ii(0x14_b612, 2); mov(cx, bx);                              /* mov cx, bx */
            ii(0x14_b614, 3); shl(cx, 0x6);                             /* shl cx, 0x6 */
            ii(0x14_b617, 3); mov(ax, memw_a16[ss, bp + 0x16]);         /* mov ax, [bp+0x16] */
            ii(0x14_b61a, 2); cmp(al, 0x1);                             /* cmp al, 0x1 */
            ii(0x14_b61c, 2); if(jzw(0x14_b642, 0x24)) goto l_0x14_b642; /* jz 0xb642 */
            ii(0x14_b61e, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x14_b621, 1); popw(es);                                 /* pop es */
            ii(0x14_b622, 3); mov(si, memw_a16[ss, bp + 0x10]);         /* mov si, [bp+0x10] */
            ii(0x14_b625, 3); callw(0x14_b55c, -0xcc);                  /* call 0xb55c */
            ii(0x14_b628, 3); mov(ax, memw_a16[ss, bp + 0x16]);         /* mov ax, [bp+0x16] */
            ii(0x14_b62b, 3); mov(cx, memw_a16[ss, bp + 0x14]);         /* mov cx, [bp+0x14] */
            ii(0x14_b62e, 4); mov(bx, memw_a16[ds, 0xa]);               /* mov bx, [0xa] */
            ii(0x14_b632, 1); pushw(ds);                                /* push ds */
            ii(0x14_b633, 1); popw(es);                                 /* pop es */
            ii(0x14_b634, 3); callw(0x14_b58c, -0xab);                  /* call 0xb58c */
        l_0x14_b637:
            ii(0x14_b637, 3); mov(memw_a16[ss, bp + 0x16], ax);         /* mov [bp+0x16], ax */
            ii(0x14_b63a, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x14_b63d, 1); popw(ds);                                 /* pop ds */
            ii(0x14_b63e, 1); popw(es);                                 /* pop es */
            ii(0x14_b63f, 1); popa();                                   /* popa */
            ii(0x14_b640, 2); iretd(); return;                          /* iretd */
        l_0x14_b642:
            ii(0x14_b642, 1); pushw(cx);                                /* push cx */
            ii(0x14_b643, 3); mov(cx, memw_a16[ss, bp + 0x14]);         /* mov cx, [bp+0x14] */
            ii(0x14_b646, 1); pushw(ds);                                /* push ds */
            ii(0x14_b647, 1); popw(es);                                 /* pop es */
            ii(0x14_b648, 4); mov(bx, memw_a16[ds, 0xa]);               /* mov bx, [0xa] */
            ii(0x14_b64c, 3); callw(0x14_b58c, -0xc3);                  /* call 0xb58c */
            ii(0x14_b64f, 1); popw(cx);                                 /* pop cx */
            ii(0x14_b650, 1); pushw(ax);                                /* push ax */
            ii(0x14_b651, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x14_b654, 1); popw(es);                                 /* pop es */
            ii(0x14_b655, 3); mov(si, memw_a16[ss, bp + 0x10]);         /* mov si, [bp+0x10] */
            ii(0x14_b658, 3); callw(0x14_b577, -0xe4);                  /* call 0xb577 */
            ii(0x14_b65b, 1); popw(ax);                                 /* pop ax */
            ii(0x14_b65c, 2); jmpw(0x14_b637, -0x27); goto l_0x14_b637; /* jmp 0xb637 */
        }
    }
}
