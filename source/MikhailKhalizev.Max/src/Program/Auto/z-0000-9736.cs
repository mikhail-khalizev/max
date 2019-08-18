using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9736-44704334")]
        public void Method_0000_9736()
        {
            ii(0x9736, 1);    pushw(di);                                /* push di */
            ii(0x9737, 1);    pushw(si);                                /* push si */
            ii(0x9738, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x973a, 3);    mov(memw_a16[ds, 0x11d0], ax);            /* mov [0x11d0], ax */
            ii(0x973d, 3);    mov(memw_a16[ds, 0x1208], ax);            /* mov [0x1208], ax */
            ii(0x9740, 4);    cmp(memw_a16[ds, 0xa], ax);               /* cmp [0xa], ax */
            ii(0x9744, 2);    if(jnzw(0x97c0, 0x7a)) goto l_0x97c0;     /* jnz 0x97c0 */
            ii(0x9746, 4);    mov(si, memw_a16[ds, 0xe]);               /* mov si, [0xe] */
            ii(0x974a, 4);    cmp(memw_a16[ds, 0x11d6], ax);            /* cmp [0x11d6], ax */
            ii(0x974e, 2);    if(jzw(0x9754, 0x4)) goto l_0x9754;       /* jz 0x9754 */
            ii(0x9750, 4);    mov(si, memw_a16[ds, 0x11d6]);            /* mov si, [0x11d6] */
        l_0x9754:
            ii(0x9754, 2);    or(si, si);                               /* or si, si */
            ii(0x9756, 2);    if(jnzw(0x975b, 0x3)) goto l_0x975b;      /* jnz 0x975b */
            ii(0x9758, 3);    mov(si, 0x800);                           /* mov si, 0x800 */
        l_0x975b:
            ii(0x975b, 4);    cmp(si, 0x400);                           /* cmp si, 0x400 */
            ii(0x975f, 2);    if(jaew(0x9764, 0x3)) goto l_0x9764;      /* jae 0x9764 */
            ii(0x9761, 3);    mov(si, 0x400);                           /* mov si, 0x400 */
        l_0x9764:
            ii(0x9764, 3);    mov(ax, memw_a16[ds, 0x9b8]);             /* mov ax, [0x9b8] */
            ii(0x9767, 1);    dec(ax);                                  /* dec ax */
            ii(0x9768, 2);    sub(bx, bx);                              /* sub bx, bx */
            ii(0x976a, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x976c, 4);    cmp(memb_a16[es, bx], 0x4d);              /* cmp byte [es:bx], 0x4d */
            ii(0x9770, 2);    if(jnzw(0x978b, 0x19)) goto l_0x978b;     /* jnz 0x978b */
            ii(0x9772, 3);    mov(ax, memw_a16[ds, 0xcec]);             /* mov ax, [0xcec] */
            ii(0x9775, 4);    cmp(memw_a16[es, bx + 0x1], ax);          /* cmp [es:bx+0x1], ax */
            ii(0x9779, 2);    if(jnzw(0x978b, 0x10)) goto l_0x978b;     /* jnz 0x978b */
            ii(0x977b, 4);    mov(di, memw_a16[es, bx + 0x3]);          /* mov di, [es:bx+0x3] */
            ii(0x977f, 3);    add(di, 0x20);                            /* add di, 0x20 */
            ii(0x9782, 3);    shl(di, 0x4);                             /* shl di, 0x4 */
            ii(0x9785, 2);    cmp(di, si);                              /* cmp di, si */
            ii(0x9787, 2);    if(jbew(0x978b, 0x2)) goto l_0x978b;      /* jbe 0x978b */
            ii(0x9789, 2);    mov(si, di);                              /* mov si, di */
        l_0x978b:
            ii(0x978b, 4);    cmp(si, 0x8200);                          /* cmp si, 0x8200 */
            ii(0x978f, 2);    if(jbew(0x9794, 0x3)) goto l_0x9794;      /* jbe 0x9794 */
            ii(0x9791, 3);    mov(si, 0x8200);                          /* mov si, 0x8200 */
        l_0x9794:
            ii(0x9794, 3);    add(si, 0xf);                             /* add si, 0xf */
            ii(0x9797, 1);    pushw(si);                                /* push si */
            ii(0x9798, 5);    callw_far_abs(0x1a2, 0xb12);              /* call word 0x1a2:0xb12 */
            ii(0x979d, 1);    popw(bx);                                 /* pop bx */
            ii(0x979e, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x97a0, 2);    if(jnzw(0x97a8, 0x6)) goto l_0x97a8;      /* jnz 0x97a8 */
        l_0x97a2:
            ii(0x97a2, 2);    pushw(0xd);                               /* push 0xd */
            ii(0x97a4, 3);    callw(0x805d, -0x174a);                   /* call 0x805d */
            ii(0x97a7, 1);    popw(bx);                                 /* pop bx */
        l_0x97a8:
            ii(0x97a8, 1);    pushw(si);                                /* push si */
            ii(0x97a9, 3);    callw(0x81ee, -0x15be);                   /* call 0x81ee */
            ii(0x97ac, 1);    popw(bx);                                 /* pop bx */
            ii(0x97ad, 3);    add(ax, 0xf);                             /* add ax, 0xf */
            ii(0x97b0, 2);    and(al, 0xf0);                            /* and al, 0xf0 */
            ii(0x97b2, 3);    mov(memw_a16[ds, 0xa], ax);               /* mov [0xa], ax */
            ii(0x97b5, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x97b7, 2);    if(jzw(0x97a2, -0x17)) goto l_0x97a2;     /* jz 0x97a2 */
            ii(0x97b9, 2);    mov(ax, si);                              /* mov ax, si */
            ii(0x97bb, 2);    and(al, 0xf0);                            /* and al, 0xf0 */
            ii(0x97bd, 3);    mov(memw_a16[ds, 0xe], ax);               /* mov [0xe], ax */
        l_0x97c0:
            ii(0x97c0, 1);    popw(si);                                 /* pop si */
            ii(0x97c1, 1);    popw(di);                                 /* pop di */
            ii(0x97c2, 1);    retw(); return;                           /* ret */
        }
    }
}
