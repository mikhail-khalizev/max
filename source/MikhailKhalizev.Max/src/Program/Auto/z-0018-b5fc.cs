using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b5fc-baf5d560")]
        public void Method_0018_b5fc()
        {
            ii(0x18_b5fc, 2); cmp(al, 0);                               /* cmp al, 0x0 */
            ii(0x18_b5fe, 2); if(jz_func(0x18_b5b2, -0x4e)) return;     /* jz 0xb5b2 */
            ii(0x18_b600, 1); pusha();                                  /* pusha */
            ii(0x18_b601, 1); push(es);                                 /* push es */
            ii(0x18_b602, 1); push(ds);                                 /* push ds */
            ii(0x18_b603, 2); xor(dx, dx);                              /* xor dx, dx */
            ii(0x18_b605, 1); push(dx);                                 /* push dx */
            ii(0x18_b606, 1); push(dx);                                 /* push dx */
            ii(0x18_b607, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_b609, 5); mov(ds, memw[cs, 0x5680]);                /* mov ds, [cs:0x5680] */
            ii(0x18_b60e, 2); xor(al, al);                              /* xor al, al */
            ii(0x18_b610, 2); @int(0x10);                               /* int 0x10 */
            ii(0x18_b612, 2); mov(cx, bx);                              /* mov cx, bx */
            ii(0x18_b614, 3); shl(cx, 6);                               /* shl cx, 0x6 */
            ii(0x18_b617, 3); mov(ax, memw[ss, bp + 0x16]);             /* mov ax, [bp+0x16] */
            ii(0x18_b61a, 2); cmp(al, 1);                               /* cmp al, 0x1 */
            ii(0x18_b61c, 2); if(jz(0x18_b642, 0x24)) goto l_0x18_b642; /* jz 0xb642 */
            ii(0x18_b61e, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x18_b621, 1); pop(es);                                  /* pop es */
            ii(0x18_b622, 3); mov(si, memw[ss, bp + 0x10]);             /* mov si, [bp+0x10] */
            ii(0x18_b625, 3); call(0x18_b55c, -0xcc);                   /* call 0xb55c */
            ii(0x18_b628, 3); mov(ax, memw[ss, bp + 0x16]);             /* mov ax, [bp+0x16] */
            ii(0x18_b62b, 3); mov(cx, memw[ss, bp + 0x14]);             /* mov cx, [bp+0x14] */
            ii(0x18_b62e, 4); mov(bx, memw[ds, 0xa]);                   /* mov bx, [0xa] */
            ii(0x18_b632, 1); push(ds);                                 /* push ds */
            ii(0x18_b633, 1); pop(es);                                  /* pop es */
            ii(0x18_b634, 3); call(0x18_b58c, -0xab);                   /* call 0xb58c */
        l_0x18_b637:
            ii(0x18_b637, 3); mov(memw[ss, bp + 0x16], ax);             /* mov [bp+0x16], ax */
            ii(0x18_b63a, 3); add(sp, 4);                               /* add sp, 0x4 */
            ii(0x18_b63d, 1); pop(ds);                                  /* pop ds */
            ii(0x18_b63e, 1); pop(es);                                  /* pop es */
            ii(0x18_b63f, 1); popa();                                   /* popa */
            ii(0x18_b640, 2); iretd(); return;                          /* iretd */
        l_0x18_b642:
            ii(0x18_b642, 1); push(cx);                                 /* push cx */
            ii(0x18_b643, 3); mov(cx, memw[ss, bp + 0x14]);             /* mov cx, [bp+0x14] */
            ii(0x18_b646, 1); push(ds);                                 /* push ds */
            ii(0x18_b647, 1); pop(es);                                  /* pop es */
            ii(0x18_b648, 4); mov(bx, memw[ds, 0xa]);                   /* mov bx, [0xa] */
            ii(0x18_b64c, 3); call(0x18_b58c, -0xc3);                   /* call 0xb58c */
            ii(0x18_b64f, 1); pop(cx);                                  /* pop cx */
            ii(0x18_b650, 1); push(ax);                                 /* push ax */
            ii(0x18_b651, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x18_b654, 1); pop(es);                                  /* pop es */
            ii(0x18_b655, 3); mov(si, memw[ss, bp + 0x10]);             /* mov si, [bp+0x10] */
            ii(0x18_b658, 3); call(0x18_b577, -0xe4);                   /* call 0xb577 */
            ii(0x18_b65b, 1); pop(ax);                                  /* pop ax */
            ii(0x18_b65c, 2); jmp(0x18_b637, -0x27); goto l_0x18_b637;  /* jmp 0xb637 */
        }
    }
}
