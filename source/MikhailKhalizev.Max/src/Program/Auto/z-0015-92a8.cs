using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("76dc0a94-5cc4-4f2a-8592-a14f41e3a522")]
        public void Method_0015_92a8()
        {
            ii(0x15_92a8, 4); enterw(0x18, 0);                          /* enter 0x18, 0x0 */
            ii(0x15_92ac, 1); pushw(di);                                /* push di */
            ii(0x15_92ad, 1); pushw(si);                                /* push si */
            ii(0x15_92ae, 3); mov(ax, memw_a16[ds, 0x1f86]);            /* mov ax, [0x1f86] */
            ii(0x15_92b1, 4); or(ax, memw_a16[ds, 0x1f84]);             /* or ax, [0x1f84] */
            ii(0x15_92b5, 2); if(jnzw(0x15_92c9, 0x12)) goto l_0x15_92c9; /* jnz 0x92c9 */
            ii(0x15_92b7, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_92b9, 1); pushw(ds);                                /* push ds */
            ii(0x15_92ba, 3); pushw(0x1b21);                            /* push 0x1b21 */
            ii(0x15_92bd, 1); nop();                                    /* nop */
            ii(0x15_92be, 1); pushw(cs);                                /* push cs */
            ii(0x15_92bf, 3); callw(0x15_cd5c, 0x3a9a);                 /* call 0xcd5c */
            ii(0x15_92c2, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_92c5, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_92c7, 2); if(jnzw(0x15_92ce, 0x5)) goto l_0x15_92ce; /* jnz 0x92ce */
        l_0x15_92c9:
            ii(0x15_92c9, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_92cb, 3); jmpw(0x15_93d2, 0x104); goto l_0x15_93d2; /* jmp 0x93d2 */
        l_0x15_92ce:
            ii(0x15_92ce, 1); pushw(ds);                                /* push ds */
            ii(0x15_92cf, 3); pushw(0x1b25);                            /* push 0x1b25 */
            ii(0x15_92d2, 3); callw(0x16_1066, 0x7d91);                 /* call 0x1066 */
            ii(0x15_92d5, 1); popw(bx);                                 /* pop bx */
            ii(0x15_92d6, 1); popw(bx);                                 /* pop bx */
            ii(0x15_92d7, 2); pushw(0x3);                               /* push 0x3 */
            ii(0x15_92d9, 5); callw_far_abs(0x80, 0x51ba);              /* call word 0x80:0x51ba */
            ii(0x15_92de, 1); popw(bx);                                 /* pop bx */
            ii(0x15_92df, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x15_92e2, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_92e4, 5); callw_far_abs(0x80, 0x51e8);              /* call word 0x80:0x51e8 */
            ii(0x15_92e9, 1); popw(bx);                                 /* pop bx */
            ii(0x15_92ea, 3); mov(memw_a16[ds, 0x1f84], ax);            /* mov [0x1f84], ax */
            ii(0x15_92ed, 4); mov(memw_a16[ds, 0x1f86], dx);            /* mov [0x1f86], dx */
            ii(0x15_92f1, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x15_92f3, 4); or(ax, memw_a16[ds, 0x1f84]);             /* or ax, [0x1f84] */
            ii(0x15_92f7, 2); if(jnzw(0x15_92fc, 0x3)) goto l_0x15_92fc; /* jnz 0x92fc */
            ii(0x15_92f9, 3); jmpw(0x15_93b9, 0xbd); goto l_0x15_93b9;  /* jmp 0x93b9 */
        l_0x15_92fc:
            ii(0x15_92fc, 4); mov(memb_a16[ss, bp - 0x12], 0);          /* mov byte [bp-0x12], 0x0 */
            ii(0x15_9300, 5); mov(memw_a16[ss, bp - 0x18], 0xffff);     /* mov word [bp-0x18], 0xffff */
            ii(0x15_9305, 4); mov(memb_a16[ss, bp - 0x13], 0x9a);       /* mov byte [bp-0x13], 0x9a */
            ii(0x15_9309, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
        l_0x15_930e:
            ii(0x15_930e, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x15_9311, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x15_9313, 4); add(cx, memw_a16[ds, 0x19ea]);            /* add cx, [0x19ea] */
            ii(0x15_9317, 4); adc(ax, memw_a16[ds, 0x19ec]);            /* adc ax, [0x19ec] */
            ii(0x15_931b, 3); mov(memw_a16[ss, bp - 0xa], cx);          /* mov [bp-0xa], cx */
            ii(0x15_931e, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x15_9321, 5); cmp(memb_a16[ds, 0x19f4], 0);             /* cmp byte [0x19f4], 0x0 */
            ii(0x15_9326, 2); if(jzw(0x15_932e, 0x6)) goto l_0x15_932e; /* jz 0x932e */
            ii(0x15_9328, 3); or(ah, 0xc0);                             /* or ah, 0xc0 */
            ii(0x15_932b, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
        l_0x15_932e:
            ii(0x15_932e, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x15_9330, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x15_9333, 3); mov(al, memb_a16[ss, bp - 0x8]);          /* mov al, [bp-0x8] */
            ii(0x15_9336, 3); mov(memb_a16[ss, bp - 0x14], al);         /* mov [bp-0x14], al */
            ii(0x15_9339, 3); mov(al, memb_a16[ss, bp - 0x7]);          /* mov al, [bp-0x7] */
            ii(0x15_933c, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_933e, 3); mov(memb_a16[ss, bp - 0x11], al);         /* mov [bp-0x11], al */
            ii(0x15_9341, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x15_9344, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x15_9347, 4); les(si, ds, 0x1f84);                      /* les si, [0x1f84] */
            ii(0x15_934b, 1); pushw(ds);                                /* push ds */
            ii(0x15_934c, 2); lea(di, bx + si);                         /* lea di, [bx+si] */
            ii(0x15_934e, 3); lea(si, bp - 0x18);                       /* lea si, [bp-0x18] */
            ii(0x15_9351, 1); pushw(ss);                                /* push ss */
            ii(0x15_9352, 1); popw(ds);                                 /* pop ds */
            ii(0x15_9353, 1); movsw_a16();                              /* movsw */
            ii(0x15_9354, 1); movsw_a16();                              /* movsw */
            ii(0x15_9355, 1); movsw_a16();                              /* movsw */
            ii(0x15_9356, 1); movsw_a16();                              /* movsw */
            ii(0x15_9357, 1); popw(ds);                                 /* pop ds */
            ii(0x15_9358, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
            ii(0x15_935b, 5); cmp(memw_a16[ss, bp - 0x2], 0x2000);      /* cmp word [bp-0x2], 0x2000 */
            ii(0x15_9360, 2); if(jbw(0x15_930e, -0x54)) goto l_0x15_930e; /* jb 0x930e */
            ii(0x15_9362, 5); mov(memw_a16[ss, bp - 0xe], 0);           /* mov word [bp-0xe], 0x0 */
            ii(0x15_9367, 5); mov(memw_a16[ss, bp - 0xc], 0x8);         /* mov word [bp-0xc], 0x8 */
            ii(0x15_936c, 2); mov(ax, es);                              /* mov ax, es */
            ii(0x15_936e, 2); and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x15_9370, 3); mov(dx, 0x8);                             /* mov dx, 0x8 */
            ii(0x15_9373, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_9376, 3); mov(memw_a16[ss, bp - 0x4], dx);          /* mov [bp-0x4], dx */
            ii(0x15_9379, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x15_937b, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_937d, 5); and(memb_a16[es, bx + 0x5], -0x20 /* 0xe0 */); /* and byte [es:bx+0x5], 0xe0 */
            ii(0x15_9382, 3); les(bx, ss, bp - 0x6);                    /* les bx, [bp-0x6] */
            ii(0x15_9385, 5); or(memb_a16[es, bx + 0x5], 0x2);          /* or byte [es:bx+0x5], 0x2 */
            ii(0x15_938a, 3); les(bx, ss, bp - 0xe);                    /* les bx, [bp-0xe] */
            ii(0x15_938d, 3); mov(ax, memw_a16[ds, 0x1f86]);            /* mov ax, [0x1f86] */
            ii(0x15_9390, 2); and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x15_9392, 2); add(bx, ax);                              /* add bx, ax */
            ii(0x15_9394, 2); mov(ax, es);                              /* mov ax, es */
            ii(0x15_9396, 3); mov(si, memw_a16[ss, bp - 0xe]);          /* mov si, [bp-0xe] */
            ii(0x15_9399, 1); pushw(ds);                                /* push ds */
            ii(0x15_939a, 3); lea(di, si + 0x68);                       /* lea di, [si+0x68] */
            ii(0x15_939d, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x15_939f, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_93a1, 1); movsw_a16();                              /* movsw */
            ii(0x15_93a2, 1); movsw_a16();                              /* movsw */
            ii(0x15_93a3, 1); movsw_a16();                              /* movsw */
            ii(0x15_93a4, 1); movsw_a16();                              /* movsw */
            ii(0x15_93a5, 1); popw(ds);                                 /* pop ds */
            ii(0x15_93a6, 3); mov(ax, 0x68);                            /* mov ax, 0x68 */
            ii(0x15_93a9, 1); nop();                                    /* nop */
            ii(0x15_93aa, 1); pushw(cs);                                /* push cs */
            ii(0x15_93ab, 3); callw(0x15_e398, 0x4fea);                 /* call 0xe398 */
            ii(0x15_93ae, 1); pushw(ds);                                /* push ds */
            ii(0x15_93af, 3); pushw(0x1b44);                            /* push 0x1b44 */
            ii(0x15_93b2, 3); callw(0x16_1066, 0x7cb1);                 /* call 0x1066 */
            ii(0x15_93b5, 1); popw(bx);                                 /* pop bx */
            ii(0x15_93b6, 1); popw(bx);                                 /* pop bx */
            ii(0x15_93b7, 2); jmpw(0x15_93c6, 0xd); goto l_0x15_93c6;   /* jmp 0x93c6 */
        l_0x15_93b9:
            ii(0x15_93b9, 1); pushw(ds);                                /* push ds */
            ii(0x15_93ba, 3); pushw(0x1b60);                            /* push 0x1b60 */
            ii(0x15_93bd, 3); pushw(0x900);                             /* push 0x900 */
            ii(0x15_93c0, 3); callw(0x16_104e, 0x7c8b);                 /* call 0x104e */
            ii(0x15_93c3, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x15_93c6:
            ii(0x15_93c6, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x15_93c9, 5); callw_far_abs(0x80, 0x51ba);              /* call word 0x80:0x51ba */
            ii(0x15_93ce, 1); popw(bx);                                 /* pop bx */
            ii(0x15_93cf, 3); jmpw(0x15_92c9, -0x109); goto l_0x15_92c9; /* jmp 0x92c9 */
        l_0x15_93d2:
            ii(0x15_93d2, 1); popw(si);                                 /* pop si */
            ii(0x15_93d3, 1); popw(di);                                 /* pop di */
            ii(0x15_93d4, 1); leavew();                                 /* leave */
            ii(0x15_93d5, 1); retw(); return;                           /* ret */
        }
    }
}
