using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2efbac76-08c7-48fc-9ebb-5b91e26ddad0")]
        public void Method_0000_51e1()
        {
            ii(0x51e1, 4);    mov(bx, memw_a16[ds, 0x8b2]);             /* mov bx, [0x8b2] */
            ii(0x51e5, 4);    cmp(bx, 0x80);                            /* cmp bx, 0x80 */
            ii(0x51e9, 2);    if(jbw(0x5236, 0x4b)) goto l_0x5236;      /* jb 0x5236 */
            ii(0x51eb, 3);    mov(ax, memw_a16[ds, 0x8aa]);             /* mov ax, [0x8aa] */
            ii(0x51ee, 3);    cmp(ax, 0x80);                            /* cmp ax, 0x80 */
            ii(0x51f1, 2);    if(jbw(0x5236, 0x43)) goto l_0x5236;      /* jb 0x5236 */
            ii(0x51f3, 3);    callw(0x4030, -0x11c6);                   /* call 0x4030 */
            ii(0x51f6, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0x51f8, 3);    lar(cx, bx);                              /* lar cx, bx */
            ii(0x51fb, 3);    and(ch, 0x18);                            /* and ch, 0x18 */
            ii(0x51fe, 3);    cmp(ch, 0x18);                            /* cmp ch, 0x18 */
            ii(0x5201, 2);    if(jnzw(0x5233, 0x30)) goto l_0x5233;     /* jnz 0x5233 */
            ii(0x5203, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0x5205, 3);    lar(cx, ax);                              /* lar cx, ax */
            ii(0x5208, 3);    and(ch, 0x18);                            /* and ch, 0x18 */
            ii(0x520b, 3);    cmp(ch, 0x10);                            /* cmp ch, 0x10 */
            ii(0x520e, 2);    if(jnzw(0x5233, 0x23)) goto l_0x5233;     /* jnz 0x5233 */
            ii(0x5210, 4);    mov(memw_a16[ds, 0xf50], sp);             /* mov [0xf50], sp */
            ii(0x5214, 2);    mov(ss, ax);                              /* mov ss, ax */
            ii(0x5216, 4);    mov(sp, memw_a16[ds, 0x8a8]);             /* mov sp, [0x8a8] */
            ii(0x521a, 2);    pushw(0x20);                              /* push 0x20 */
            ii(0x521c, 4);    pushw(memw_a16[ds, 0x996]);               /* push word [0x996] */
            ii(0x5220, 4);    mov(ds, memw_a16[ds, 0x8ae]);             /* mov ds, [0x8ae] */
            ii(0x5224, 5);    callw_a16_far_ind(es, 0x8b0);             /* call far word [es:0x8b0] */
            ii(0x5229, 2);    pushw(0x20);                              /* push 0x20 */
            ii(0x522b, 1);    popw(ds);                                 /* pop ds */
            ii(0x522c, 2);    pushw(0x20);                              /* push 0x20 */
            ii(0x522e, 1);    popw(ss);                                 /* pop ss */
            ii(0x522f, 4);    mov(sp, memw_a16[ds, 0xf50]);             /* mov sp, [0xf50] */
        l_0x5233:
            ii(0x5233, 3);    callw(0x46c9, -0xb6d);                    /* call 0x46c9 */
        l_0x5236:
            ii(0x5236, 1);    retw(); return;                           /* ret */
        }
    }
}
