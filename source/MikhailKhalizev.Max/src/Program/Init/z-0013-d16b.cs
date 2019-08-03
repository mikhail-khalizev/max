using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ccb95b07-e298-414d-9a7f-5f0ccad76a27")]
        public void Method_0013_d16b()
        {
            ii(0x13_d16b, 1); pushw(ax);                                /* push ax */
            ii(0x13_d16c, 1); pushw(cs);                                /* push cs */
            ii(0x13_d16d, 3); callw(0x13_d612, 0x4a2);                  /* call 0xd612 */
            ii(0x13_d170, 1); pushw(cs);                                /* push cs */
            ii(0x13_d171, 3); callw(0x13_d86f, 0x6fb);                  /* call 0xd86f */
            ii(0x13_d174, 7); cmp(memw_a16[ss, 0x1dac], 0xd6d6);        /* cmp word [ss:0x1dac], 0xd6d6 */
            ii(0x13_d17b, 2); if(jnzw(0x13_d184, 0x7)) goto l_0x13_d184; /* jnz 0xd184 */
            ii(0x13_d17d, 1); popw(ax);                                 /* pop ax */
            ii(0x13_d17e, 1); pushw(ax);                                /* push ax */
            ii(0x13_d17f, 5); callw_abs(memw_a16[ss, 0x1db0]);          /* call word [ss:0x1db0] */
        l_0x13_d184:
            ii(0x13_d184, 3); mov(ax, 0xff);                            /* mov ax, 0xff */
            ii(0x13_d187, 1); pushw(ax);                                /* push ax */
            ii(0x13_d188, 1); pushw(cs);                                /* push cs */
            ii(0x13_d189, 4); callw_abs(memw_a16[ds, 0x13f2]);          /* call word [0x13f2] */
            ii(0x13_d18d, 3); pushw(0x3e);                              /* push 0x3e */
            ii(0x13_d190, 2); add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0x13_d192, 1); pushw(es);                                /* push es */
            ii(0x13_d193, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x13_d196, 2); mov(dh, 0x5);                             /* mov dh, 0x5 */
            ii(0x13_d198, 2); mov(bx, cs);                              /* mov bx, cs */
            ii(0x13_d19a, 2); @int(0x21);                               /* int 0x21 */
            ii(0x13_d19c, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x13_d19e, 7); mov(memw_a16[es, -0x7674], 0x9090);       /* mov word [es:0x898c], 0x9090 */
            ii(0x13_d1a5, 4); mov(memw_a16[es, -0x7690], ax);           /* mov [es:0x8970], ax */
            ii(0x13_d1a9, 1); popw(es);                                 /* pop es */
            ii(0x13_d1aa, 2); jmpw(0x13_d1ae, 0x2); goto l_0x13_d1ae;   /* jmp 0xd1ae */
        //  ii(0x13_d1ac, 2); Недостижимый код.
l_0x13_d1ae:
            ii(0x13_d1ae, 1); pushw(bp);                                /* push bp */
            ii(0x13_d1af, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_d1b1, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_d1b3, 1); pushw(si);                                /* push si */
            ii(0x13_d1b4, 1); pushw(di);                                /* push di */
            ii(0x13_d1b5, 1); pushw(es);                                /* push es */
            ii(0x13_d1b6, 1); pushw(ds);                                /* push ds */
            ii(0x13_d1b7, 1); pushfw();                                 /* pushfw */
            ii(0x13_d1b8, 1); pushw(bp);                                /* push bp */
            ii(0x13_d1b9, 2); mov(bx, ss);                              /* mov bx, ss */
            ii(0x13_d1bb, 2); mov(ds, bx);                              /* mov ds, bx */
            ii(0x13_d1bd, 3); mov(bx, memw_a16[ss, bp + 0x8]);          /* mov bx, [bp+0x8] */
            ii(0x13_d1c0, 2); pushw(memw_a16[ds, bx]);                  /* push word [bx] */
            ii(0x13_d1c2, 3); pushw(memw_a16[ds, bx + 0x2]);            /* push word [bx+0x2] */
            ii(0x13_d1c5, 3); pushw(memw_a16[ds, bx + 0x4]);            /* push word [bx+0x4] */
            ii(0x13_d1c8, 3); mov(dx, memw_a16[ds, bx + 0x6]);          /* mov dx, [bx+0x6] */
            ii(0x13_d1cb, 3); mov(si, memw_a16[ds, bx + 0x8]);          /* mov si, [bx+0x8] */
            ii(0x13_d1ce, 3); mov(di, memw_a16[ds, bx + 0xa]);          /* mov di, [bx+0xa] */
            ii(0x13_d1d1, 3); mov(bx, memw_a16[ss, bp + 0xc]);          /* mov bx, [bp+0xc] */
            ii(0x13_d1d4, 2); mov(cx, memw_a16[ds, bx]);                /* mov cx, [bx] */
            ii(0x13_d1d6, 2); xchg(bx, bx);                             /* xchg bx, bx */
            ii(0x13_d1d8, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x13_d1da, 3); lar(ax, cx);                              /* lar ax, cx */
            ii(0x13_d1dd, 2); jmpw(0x13_d1df, 0); goto l_0x13_d1df;     /* jmp 0xd1df */
        l_0x13_d1df:
            ii(0x13_d1df, 3); test(ah, 0x10);                           /* test ah, 0x10 */
            ii(0x13_d1e2, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x13_d1e5, 2); if(jzw(0x13_d1e9, 0x2)) goto l_0x13_d1e9; /* jz 0xd1e9 */
            ii(0x13_d1e7, 2); mov(ax, cx);                              /* mov ax, cx */
        l_0x13_d1e9:
            ii(0x13_d1e9, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x13_d1eb, 3); mov(al, memb_a16[ss, bp + 0x6]);          /* mov al, [bp+0x6] */
            ii(0x13_d1ee, 1); cli();                                    /* cli */
            ii(0x13_d1ef, 3); mov(cx, memw_a16[ds, bx + 0x6]);          /* mov cx, [bx+0x6] */
            ii(0x13_d1f2, 5); mov(ds, memw_a16[cs, -0x7690]);           /* mov ds, [cs:0x8970] */
            ii(0x13_d1f7, 3); mov(memb_a16[ds, -0x760d], al);           /* mov [0x89f3], al */
            ii(0x13_d1fa, 2); xchg(bx, bx);                             /* xchg bx, bx */
            ii(0x13_d1fc, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x13_d1fe, 3); lar(ax, cx);                              /* lar ax, cx */
            ii(0x13_d201, 2); jmpw(0x13_d203, 0); goto l_0x13_d203;     /* jmp 0xd203 */
        l_0x13_d203:
            ii(0x13_d203, 3); test(ah, 0x10);                           /* test ah, 0x10 */
            ii(0x13_d206, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x13_d209, 2); if(jzw(0x13_d20d, 0x2)) goto l_0x13_d20d; /* jz 0xd20d */
            ii(0x13_d20b, 2); mov(ax, cx);                              /* mov ax, cx */
        l_0x13_d20d:
            ii(0x13_d20d, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_d20f, 1); popw(cx);                                 /* pop cx */
            ii(0x13_d210, 1); popw(bx);                                 /* pop bx */
            ii(0x13_d211, 1); popw(ax);                                 /* pop ax */
            ii(0x13_d212, 2); @int(0);                                  /* int 0x0 */
            ii(0x13_d214, 1); popw(bp);                                 /* pop bp */
            ii(0x13_d215, 1); pushfw();                                 /* pushfw */
            ii(0x13_d216, 1); pushw(ds);                                /* push ds */
            ii(0x13_d217, 1); pushw(bx);                                /* push bx */
            ii(0x13_d218, 1); pushfw();                                 /* pushfw */
            ii(0x13_d219, 2); mov(bx, ss);                              /* mov bx, ss */
            ii(0x13_d21b, 2); mov(ds, bx);                              /* mov ds, bx */
            ii(0x13_d21d, 3); mov(bx, memw_a16[ss, bp + 0xa]);          /* mov bx, [bp+0xa] */
            ii(0x13_d220, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x13_d222, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x13_d225, 1); popw(ax);                                 /* pop ax */
            ii(0x13_d226, 3); and(ax, 0x1);                             /* and ax, 0x1 */
            ii(0x13_d229, 3); mov(memw_a16[ds, bx + 0xc], ax);          /* mov [bx+0xc], ax */
            ii(0x13_d22c, 3); mov(memw_a16[ds, bx + 0x4], cx);          /* mov [bx+0x4], cx */
            ii(0x13_d22f, 3); mov(memw_a16[ds, bx + 0x6], dx);          /* mov [bx+0x6], dx */
            ii(0x13_d232, 3); mov(memw_a16[ds, bx + 0x8], si);          /* mov [bx+0x8], si */
            ii(0x13_d235, 3); mov(memw_a16[ds, bx + 0xa], di);          /* mov [bx+0xa], di */
            ii(0x13_d238, 3); popw(memw_a16[ds, bx + 0x2]);             /* pop word [bx+0x2] */
            ii(0x13_d23b, 3); mov(bx, memw_a16[ss, bp + 0xc]);          /* mov bx, [bp+0xc] */
            ii(0x13_d23e, 2); mov(memw_a16[ds, bx], es);                /* mov [bx], es */
            ii(0x13_d240, 1); popw(cx);                                 /* pop cx */
            ii(0x13_d241, 3); mov(memw_a16[ds, bx + 0x6], cx);          /* mov [bx+0x6], cx */
            ii(0x13_d244, 1); popw(ax);                                 /* pop ax */
            ii(0x13_d245, 1); popw(cx);                                 /* pop cx */
            ii(0x13_d246, 3); test(ch, 0x2);                            /* test ch, 0x2 */
            ii(0x13_d249, 2); if(jzw(0x13_d24c, 0x1)) goto l_0x13_d24c; /* jz 0xd24c */
            ii(0x13_d24b, 1); sti();                                    /* sti */
        l_0x13_d24c:
            ii(0x13_d24c, 1); popw(ds);                                 /* pop ds */
            ii(0x13_d24d, 1); popw(es);                                 /* pop es */
            ii(0x13_d24e, 3); mov(memw_a16[ds, 0x1432], ax);            /* mov [0x1432], ax */
            ii(0x13_d251, 1); popw(di);                                 /* pop di */
            ii(0x13_d252, 1); popw(si);                                 /* pop si */
            ii(0x13_d253, 1); popw(ax);                                 /* pop ax */
            ii(0x13_d254, 1); popw(bp);                                 /* pop bp */
            ii(0x13_d255, 1); retfw(); return;                          /* retf */
        }
    }
}
