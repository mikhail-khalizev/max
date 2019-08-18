using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9fd0-60fed836")]
        public void Method_0000_9fd0()
        {
            ii(0x9fd0, 1);    pushw(si);                                /* push si */
            ii(0x9fd1, 1);    pushw(di);                                /* push di */
            ii(0x9fd2, 2);    xor(si, si);                              /* xor si, si */
            ii(0x9fd4, 3);    callw(0x9fb7, -0x20);                     /* call 0x9fb7 */
            ii(0x9fd7, 2);    if(jnzw(0xa019, 0x40)) goto l_0xa019;     /* jnz 0xa019 */
            ii(0x9fd9, 1);    pushw(dx);                                /* push dx */
            ii(0x9fda, 2);    xor(al, 0x2);                             /* xor al, 0x2 */
            ii(0x9fdc, 1);    pushw(ax);                                /* push ax */
            ii(0x9fdd, 2);    outb(0x92, al);                           /* out 0x92, al */
            ii(0x9fdf, 3);    callw(0x9fb7, -0x2b);                     /* call 0x9fb7 */
            ii(0x9fe2, 1);    popw(cx);                                 /* pop cx */
            ii(0x9fe3, 1);    popw(bx);                                 /* pop bx */
            ii(0x9fe4, 2);    mov(ch, al);                              /* mov ch, al */
            ii(0x9fe6, 4);    and(cx, 0x303);                           /* and cx, 0x303 */
            ii(0x9fea, 2);    cmp(ch, cl);                              /* cmp ch, cl */
            ii(0x9fec, 2);    if(jnzw(0xa019, 0x2b)) goto l_0xa019;     /* jnz 0xa019 */
            ii(0x9fee, 2);    xor(al, 0x2);                             /* xor al, 0x2 */
            ii(0x9ff0, 2);    outb(0x92, al);                           /* out 0x92, al */
            ii(0x9ff2, 2);    xor(dx, bx);                              /* xor dx, bx */
            ii(0x9ff4, 2);    if(jzw(0xa019, 0x23)) goto l_0xa019;      /* jz 0xa019 */
            ii(0x9ff6, 3);    callw(0x9fb7, -0x42);                     /* call 0x9fb7 */
            ii(0x9ff9, 2);    if(jnzw(0xa019, 0x1e)) goto l_0xa019;     /* jnz 0xa019 */
            ii(0x9ffb, 1);    pushw(cs);                                /* push cs */
            ii(0x9ffc, 1);    popw(ds);                                 /* pop ds */
            ii(0x9ffd, 1);    pushw(cs);                                /* push cs */
            ii(0x9ffe, 1);    popw(es);                                 /* pop es */
            ii(0x9fff, 3);    mov(si, 0x69b5);                          /* mov si, 0x69b5 */
            ii(0xa002, 3);    mov(di, 0xbe9);                           /* mov di, 0xbe9 */
            ii(0xa005, 3);    mov(cx, 0x9);                             /* mov cx, 0x9 */
            ii(0xa008, 2);    rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0xa00a, 3);    mov(di, 0xbfb);                           /* mov di, 0xbfb */
            ii(0xa00d, 3);    mov(cx, 0x9);                             /* mov cx, 0x9 */
            ii(0xa010, 2);    rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0xa012, 1);    pushw(ss);                                /* push ss */
            ii(0xa013, 1);    popw(ds);                                 /* pop ds */
            ii(0xa014, 5);    mov(memb_a16[ds, 0x3f], 0xff);            /* mov byte [0x3f], 0xff */
        l_0xa019:
            ii(0xa019, 1);    sti();                                    /* sti */
            ii(0xa01a, 1);    popw(di);                                 /* pop di */
            ii(0xa01b, 1);    popw(si);                                 /* pop si */
            ii(0xa01c, 1);    retw(); return;                           /* ret */
        }
    }
}
