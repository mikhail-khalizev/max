using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7726-44704334")]
        public void Method_0000_7726()
        {
            ii(0x7726, 1);    pushw(di);                                /* push di */
            ii(0x7727, 1);    pushw(si);                                /* push si */
            ii(0x7728, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x772a, 3);    mov(memw_a16[ds, 0x11d0], ax);            /* mov [0x11d0], ax */
            ii(0x772d, 3);    mov(memw_a16[ds, 0x1208], ax);            /* mov [0x1208], ax */
            ii(0x7730, 4);    cmp(memw_a16[ds, 0xa], ax);               /* cmp [0xa], ax */
            ii(0x7734, 2);    if(jnzw(0x77b0, 0x7a)) goto l_0x77b0;     /* jnz 0x77b0 */
            ii(0x7736, 4);    mov(si, memw_a16[ds, 0xe]);               /* mov si, [0xe] */
            ii(0x773a, 4);    cmp(memw_a16[ds, 0x11d6], ax);            /* cmp [0x11d6], ax */
            ii(0x773e, 2);    if(jzw(0x7744, 0x4)) goto l_0x7744;       /* jz 0x7744 */
            ii(0x7740, 4);    mov(si, memw_a16[ds, 0x11d6]);            /* mov si, [0x11d6] */
        l_0x7744:
            ii(0x7744, 2);    or(si, si);                               /* or si, si */
            ii(0x7746, 2);    if(jnzw(0x774b, 0x3)) goto l_0x774b;      /* jnz 0x774b */
            ii(0x7748, 3);    mov(si, 0x800);                           /* mov si, 0x800 */
        l_0x774b:
            ii(0x774b, 4);    cmp(si, 0x400);                           /* cmp si, 0x400 */
            ii(0x774f, 2);    if(jaew(0x7754, 0x3)) goto l_0x7754;      /* jae 0x7754 */
            ii(0x7751, 3);    mov(si, 0x400);                           /* mov si, 0x400 */
        l_0x7754:
            ii(0x7754, 3);    mov(ax, memw_a16[ds, 0x9b8]);             /* mov ax, [0x9b8] */
            ii(0x7757, 1);    dec(ax);                                  /* dec ax */
            ii(0x7758, 2);    sub(bx, bx);                              /* sub bx, bx */
            ii(0x775a, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x775c, 4);    cmp(memb_a16[es, bx], 0x4d);              /* cmp byte [es:bx], 0x4d */
            ii(0x7760, 2);    if(jnzw(0x777b, 0x19)) goto l_0x777b;     /* jnz 0x777b */
            ii(0x7762, 3);    mov(ax, memw_a16[ds, 0xcec]);             /* mov ax, [0xcec] */
            ii(0x7765, 4);    cmp(memw_a16[es, bx + 0x1], ax);          /* cmp [es:bx+0x1], ax */
            ii(0x7769, 2);    if(jnzw(0x777b, 0x10)) goto l_0x777b;     /* jnz 0x777b */
            ii(0x776b, 4);    mov(di, memw_a16[es, bx + 0x3]);          /* mov di, [es:bx+0x3] */
            ii(0x776f, 3);    add(di, 0x20);                            /* add di, 0x20 */
            ii(0x7772, 3);    shl(di, 0x4);                             /* shl di, 0x4 */
            ii(0x7775, 2);    cmp(di, si);                              /* cmp di, si */
            ii(0x7777, 2);    if(jbew(0x777b, 0x2)) goto l_0x777b;      /* jbe 0x777b */
            ii(0x7779, 2);    mov(si, di);                              /* mov si, di */
        l_0x777b:
            ii(0x777b, 4);    cmp(si, 0x8200);                          /* cmp si, 0x8200 */
            ii(0x777f, 2);    if(jbew(0x7784, 0x3)) goto l_0x7784;      /* jbe 0x7784 */
            ii(0x7781, 3);    mov(si, 0x8200);                          /* mov si, 0x8200 */
        l_0x7784:
            ii(0x7784, 3);    add(si, 0xf);                             /* add si, 0xf */
            ii(0x7787, 1);    pushw(si);                                /* push si */
            ii(0x7788, 5);    callw_far_abs(0x1a2, 0xb12);              /* call word 0x1a2:0xb12 */
            ii(0x778d, 1);    popw(bx);                                 /* pop bx */
            ii(0x778e, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x7790, 2);    if(jnzw(0x7798, 0x6)) goto l_0x7798;      /* jnz 0x7798 */
        l_0x7792:
            ii(0x7792, 2);    pushw(0xd);                               /* push 0xd */
            ii(0x7794, 3);    callw(0x604d, -0x174a);                   /* call 0x604d */
            ii(0x7797, 1);    popw(bx);                                 /* pop bx */
        l_0x7798:
            ii(0x7798, 1);    pushw(si);                                /* push si */
            ii(0x7799, 3);    callw(0x61de, -0x15be);                   /* call 0x61de */
            ii(0x779c, 1);    popw(bx);                                 /* pop bx */
            ii(0x779d, 3);    add(ax, 0xf);                             /* add ax, 0xf */
            ii(0x77a0, 2);    and(al, 0xf0);                            /* and al, 0xf0 */
            ii(0x77a2, 3);    mov(memw_a16[ds, 0xa], ax);               /* mov [0xa], ax */
            ii(0x77a5, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x77a7, 2);    if(jzw(0x7792, -0x17)) goto l_0x7792;     /* jz 0x7792 */
            ii(0x77a9, 2);    mov(ax, si);                              /* mov ax, si */
            ii(0x77ab, 2);    and(al, 0xf0);                            /* and al, 0xf0 */
            ii(0x77ad, 3);    mov(memw_a16[ds, 0xe], ax);               /* mov [0xe], ax */
        l_0x77b0:
            ii(0x77b0, 1);    popw(si);                                 /* pop si */
            ii(0x77b1, 1);    popw(di);                                 /* pop di */
            ii(0x77b2, 1);    retw(); return;                           /* ret */
        }
    }
}
