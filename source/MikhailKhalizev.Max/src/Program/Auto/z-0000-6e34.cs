using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c8fde1cb-7a94-49b7-ac68-8f969a238a9e")]
        public void Method_0000_6e34()
        {
            ii(0x6e34, 4);    enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x6e38, 3);    mov(ax, memw_a16[ds, 0xd0e]);             /* mov ax, [0xd0e] */
            ii(0x6e3b, 3);    mov(cx, 0x180);                           /* mov cx, 0x180 */
            ii(0x6e3e, 2);    imul(cx);                                 /* imul cx */
            ii(0x6e40, 3);    add(ax, 0x2a);                            /* add ax, 0x2a */
            ii(0x6e43, 3);    mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x6e46, 5);    cmp(memw_a16[ds, 0xf4e], 0);              /* cmp word [0xf4e], 0x0 */
            ii(0x6e4b, 2);    if(jnzw(0x6e6e, 0x21)) goto l_0x6e6e;     /* jnz 0x6e6e */
            ii(0x6e4d, 6);    mov(memw_a16[ds, 0x11d4], 0x8);           /* mov word [0x11d4], 0x8 */
            ii(0x6e53, 1);    pushw(ax);                                /* push ax */
            ii(0x6e54, 5);    callw_far_abs(0x1a2, 0xb12);              /* call word 0x1a2:0xb12 */
            ii(0x6e59, 1);    popw(bx);                                 /* pop bx */
            ii(0x6e5a, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x6e5d, 3);    callw(0x5a2e, -0x1432);                   /* call 0x5a2e */
            ii(0x6e60, 1);    popw(bx);                                 /* pop bx */
            ii(0x6e61, 3);    mov(memw_a16[ds, 0xf4e], ax);             /* mov [0xf4e], ax */
            ii(0x6e64, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x6e66, 2);    if(jnzw(0x6e6e, 0x6)) goto l_0x6e6e;      /* jnz 0x6e6e */
            ii(0x6e68, 2);    pushw(0x9);                               /* push 0x9 */
            ii(0x6e6a, 3);    callw(0x589d, -0x15d0);                   /* call 0x589d */
            ii(0x6e6d, 1);    popw(bx);                                 /* pop bx */
        l_0x6e6e:
            ii(0x6e6e, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x6e71, 2);    pushw(0);                                 /* push 0x0 */
            ii(0x6e73, 4);    pushw(memw_a16[ds, 0xf4e]);               /* push word [0xf4e] */
            ii(0x6e77, 3);    callw(0x5d66, -0x1114);                   /* call 0x5d66 */
            ii(0x6e7a, 3);    mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x6e7d, 4);    add(ax, memw_a16[ds, 0xf4e]);             /* add ax, [0xf4e] */
            ii(0x6e81, 3);    mov(memw_a16[ds, 0xf4c], ax);             /* mov [0xf4c], ax */
            ii(0x6e84, 3);    sub(ax, 0x2a);                            /* sub ax, 0x2a */
            ii(0x6e87, 3);    mov(memw_a16[ds, 0x996], ax);             /* mov [0x996], ax */
            ii(0x6e8a, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0x6e8c, 4);    mov(cx, memw_a16[ds, 0xf4c]);             /* mov cx, [0xf4c] */
            ii(0x6e90, 2);    mov(memw_a16[ds, bx], cx);                /* mov [bx], cx */
            ii(0x6e92, 5);    mov(memw_a16[ds, bx + 0x18], 0xffff);     /* mov word [bx+0x18], 0xffff */
            ii(0x6e97, 6);    mov(memw_a16[ds, 0x99e], 0);              /* mov word [0x99e], 0x0 */
            ii(0x6e9d, 1);    leavew();                                 /* leave */
            ii(0x6e9e, 1);    retw(); return;                           /* ret */
        }
    }
}
