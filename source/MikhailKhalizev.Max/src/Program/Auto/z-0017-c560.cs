using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_c560-accc3a6e")]
        public void Method_0017_c560()
        {
            ii(0x17_c560, 4); enterw(0x10, 0);                          /* enter 0x10, 0x0 */
            ii(0x17_c564, 1); pushw(di);                                /* push di */
            ii(0x17_c565, 1); pushw(si);                                /* push si */
            ii(0x17_c566, 1); pushw(ds);                                /* push ds */
            ii(0x17_c567, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_c56a, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_c56c, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_c56e, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x17_c571, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x17_c574, 2); jmpw(0x17_c586, 0x10); goto l_0x17_c586;  /* jmp 0xc586 */
        l_0x17_c576:
            ii(0x17_c576, 4); add(memw_a16[ss, bp - 0xc], 0x1);         /* add word [bp-0xc], 0x1 */
            ii(0x17_c57a, 4); adc(memw_a16[ss, bp - 0xa], 0);           /* adc word [bp-0xa], 0x0 */
            ii(0x17_c57e, 4); add(memw_a16[ss, bp + 0x6], 0x1);         /* add word [bp+0x6], 0x1 */
            ii(0x17_c582, 4); adc(memw_a16[ss, bp + 0x8], 0);           /* adc word [bp+0x8], 0x0 */
        l_0x17_c586:
            ii(0x17_c586, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x17_c589, 3); mov(dx, memw_a16[ss, bp + 0xc]);          /* mov dx, [bp+0xc] */
            ii(0x17_c58c, 3); cmp(memw_a16[ss, bp - 0xa], dx);          /* cmp [bp-0xa], dx */
            ii(0x17_c58f, 2); if(jbew(0x17_c594, 0x3)) goto l_0x17_c594; /* jbe 0xc594 */
            ii(0x17_c591, 3); jmpw(0x17_c6a8, 0x114); goto l_0x17_c6a8; /* jmp 0xc6a8 */
        l_0x17_c594:
            ii(0x17_c594, 2); if(jbw(0x17_c59e, 0x8)) goto l_0x17_c59e; /* jb 0xc59e */
            ii(0x17_c596, 3); cmp(memw_a16[ss, bp - 0xc], ax);          /* cmp [bp-0xc], ax */
            ii(0x17_c599, 2); if(jbw(0x17_c59e, 0x3)) goto l_0x17_c59e; /* jb 0xc59e */
            ii(0x17_c59b, 3); jmpw(0x17_c6a8, 0x10a); goto l_0x17_c6a8; /* jmp 0xc6a8 */
        l_0x17_c59e:
            ii(0x17_c59e, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_c5a1, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_c5a4, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_c5a8, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_c5ac, 3); callw(0x17_9208, -0x33a7);                /* call 0x9208 */
            ii(0x17_c5af, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_c5b2, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x17_c5b5, 3); mov(memw_a16[ss, bp - 0xe], dx);          /* mov [bp-0xe], dx */
            ii(0x17_c5b8, 4); test(memb_a16[ss, bp - 0x10], 0x1);       /* test byte [bp-0x10], 0x1 */
            ii(0x17_c5bc, 2); if(jzw(0x17_c5e0, 0x22)) goto l_0x17_c5e0; /* jz 0xc5e0 */
            ii(0x17_c5be, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_c5c0, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_c5c2, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_c5c4, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_c5c6, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_c5c8, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_c5ca, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_c5cc, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_c5ce, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_c5d0, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_c5d2, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_c5d4, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_c5d6, 1); pushw(dx);                                /* push dx */
            ii(0x17_c5d7, 1); pushw(ax);                                /* push ax */
            ii(0x17_c5d8, 1); nop();                                    /* nop */
            ii(0x17_c5d9, 1); pushw(cs);                                /* push cs */
            ii(0x17_c5da, 3); callw(0x17_7f3a, -0x46a3);                /* call 0x7f3a */
            ii(0x17_c5dd, 3); add(sp, 0x4);                             /* add sp, 0x4 */
        l_0x17_c5e0:
            ii(0x17_c5e0, 4); and(memb_a16[ss, bp - 0x10], -0x2 /* 0xfe */); /* and byte [bp-0x10], 0xfe */
            ii(0x17_c5e4, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x17_c5e7, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x17_c5ea, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x17_c5ed, 5); mov(memw_a16[ss, bp - 0xe], 0);           /* mov word [bp-0xe], 0x0 */
            ii(0x17_c5f2, 4); and(memb_a16[ss, bp - 0xf], -0xf /* 0xf1 */); /* and byte [bp-0xf], 0xf1 */
            ii(0x17_c5f6, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_c5f8, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_c5fb, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_c5fe, 4); pushw(memw_a16[ds, 0x4ff6]);              /* push word [0x4ff6] */
            ii(0x17_c602, 4); pushw(memw_a16[ds, 0x4ff4]);              /* push word [0x4ff4] */
            ii(0x17_c606, 3); callw(0x17_91e3, -0x3426);                /* call 0x91e3 */
            ii(0x17_c609, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_c60c, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_c60e, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_c611, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_c614, 4); pushw(memw_a16[ds, 0x1fa6]);              /* push word [0x1fa6] */
            ii(0x17_c618, 4); pushw(memw_a16[ds, 0x1fa4]);              /* push word [0x1fa4] */
            ii(0x17_c61c, 3); callw(0x17_91e3, -0x343c);                /* call 0x91e3 */
            ii(0x17_c61f, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_c622, 3); mov(ax, memw_a16[ds, 0x1a]);              /* mov ax, [0x1a] */
            ii(0x17_c625, 4); or(ax, memw_a16[ds, 0x18]);               /* or ax, [0x18] */
            ii(0x17_c629, 2); if(jnzw(0x17_c63a, 0xf)) goto l_0x17_c63a; /* jnz 0xc63a */
            ii(0x17_c62b, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_c62e, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_c631, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_c634, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x17_c637, 2); jmpw(0x17_c675, 0x3c); goto l_0x17_c675;  /* jmp 0xc675 */
        //  ii(0x17_c639, 1); Недостижимый код.
        l_0x17_c63a:
            ii(0x17_c63a, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_c63d, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_c640, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x17_c643, 3); adc(dx, 0x1);                             /* adc dx, 0x1 */
            ii(0x17_c646, 1); pushw(dx);                                /* push dx */
            ii(0x17_c647, 1); pushw(ax);                                /* push ax */
            ii(0x17_c648, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_c64a, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_c64c, 3); callw(0x17_8f06, -0x3749);                /* call 0x8f06 */
            ii(0x17_c64f, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_c652, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_c655, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x17_c658, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_c65b, 2); if(jnzw(0x17_c675, 0x18)) goto l_0x17_c675; /* jnz 0xc675 */
            ii(0x17_c65d, 4); cmp(dx, 0xfff);                           /* cmp dx, 0xfff */
            ii(0x17_c661, 2); if(jnzw(0x17_c675, 0x12)) goto l_0x17_c675; /* jnz 0xc675 */
            ii(0x17_c663, 4); or(di, 0x8000);                           /* or di, 0x8000 */
            ii(0x17_c667, 1); pushw(di);                                /* push di */
            ii(0x17_c668, 1); pushw(si);                                /* push si */
            ii(0x17_c669, 3); callw(0x17_8f06, -0x3766);                /* call 0x8f06 */
            ii(0x17_c66c, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_c66f, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_c672, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
        l_0x17_c675:
            ii(0x17_c675, 4); cmp(memw_a16[ss, bp - 0x8], -0x1 /* 0xff */); /* cmp word [bp-0x8], 0xffff */
            ii(0x17_c679, 2); if(jnzw(0x17_c681, 0x6)) goto l_0x17_c681; /* jnz 0xc681 */
            ii(0x17_c67b, 4); cmp(memw_a16[ss, bp - 0x6], -0x1 /* 0xff */); /* cmp word [bp-0x6], 0xffff */
            ii(0x17_c67f, 2); if(jzw(0x17_c6a5, 0x24)) goto l_0x17_c6a5; /* jz 0xc6a5 */
        l_0x17_c681:
            ii(0x17_c681, 5); mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x17_c686, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x17_c68b, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x17_c68e, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_c691, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x17_c694, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x17_c697, 4); pushw(memw_a16[ds, 0x4fb6]);              /* push word [0x4fb6] */
            ii(0x17_c69b, 4); pushw(memw_a16[ds, 0x4fb4]);              /* push word [0x4fb4] */
            ii(0x17_c69f, 3); callw(0x17_9235, -0x346d);                /* call 0x9235 */
            ii(0x17_c6a2, 3); add(sp, 0xc);                             /* add sp, 0xc */
        l_0x17_c6a5:
            ii(0x17_c6a5, 3); jmpw(0x17_c576, -0x132); goto l_0x17_c576; /* jmp 0xc576 */
        l_0x17_c6a8:
            ii(0x17_c6a8, 3); mov(eax, cr3);                            /* mov eax, cr3 */
            ii(0x17_c6ab, 3); mov(cr3, eax);                            /* mov cr3, eax */
            ii(0x17_c6ae, 1); popw(ds);                                 /* pop ds */
            ii(0x17_c6af, 1); popw(si);                                 /* pop si */
            ii(0x17_c6b0, 1); popw(di);                                 /* pop di */
            ii(0x17_c6b1, 1); leavew();                                 /* leave */
            ii(0x17_c6b2, 1); retfw(); return;                          /* retf */
        }
    }
}
