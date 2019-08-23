using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_92a8-877078a0")]
        public void Method_0019_92a8()
        {
            ii(0x19_92a8, 4); enter(0x18, 0);                           /* enter 0x18, 0x0 */
            ii(0x19_92ac, 1); push(di);                                 /* push di */
            ii(0x19_92ad, 1); push(si);                                 /* push si */
            ii(0x19_92ae, 3); mov(ax, memw[ds, 0x1f86]);                /* mov ax, [0x1f86] */
            ii(0x19_92b1, 4); or(ax, memw[ds, 0x1f84]);                 /* or ax, [0x1f84] */
            ii(0x19_92b5, 2); if(jnz(0x19_92c9, 0x12)) goto l_0x19_92c9; /* jnz 0x92c9 */
            ii(0x19_92b7, 2); push(0);                                  /* push 0x0 */
            ii(0x19_92b9, 1); push(ds);                                 /* push ds */
            ii(0x19_92ba, 3); push(0x1b21);                             /* push 0x1b21 */
            ii(0x19_92bd, 1); nop();                                    /* nop */
            ii(0x19_92be, 1); push(cs);                                 /* push cs */
            ii(0x19_92bf, 3); call(0x19_cd5c, 0x3a9a);                  /* call 0xcd5c */
            ii(0x19_92c2, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_92c5, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_92c7, 2); if(jnz(0x19_92ce, 0x5)) goto l_0x19_92ce; /* jnz 0x92ce */
        l_0x19_92c9:
            ii(0x19_92c9, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_92cb, 3); jmp(0x19_93d2, 0x104); goto l_0x19_93d2;  /* jmp 0x93d2 */
        l_0x19_92ce:
            ii(0x19_92ce, 1); push(ds);                                 /* push ds */
            ii(0x19_92cf, 3); push(0x1b25);                             /* push 0x1b25 */
            ii(0x19_92d2, 3); call(0x1a_1066, 0x7d91);                  /* call 0x1066 */
            ii(0x19_92d5, 1); pop(bx);                                  /* pop bx */
            ii(0x19_92d6, 1); pop(bx);                                  /* pop bx */
            ii(0x19_92d7, 2); push(0x3);                                /* push 0x3 */
            ii(0x19_92d9, 5); call_far_abs(0x80, 0x51ba);               /* call word 0x80:0x51ba */
            ii(0x19_92de, 1); pop(bx);                                  /* pop bx */
            ii(0x19_92df, 3); mov(memw[ss, bp - 0x10], ax);             /* mov [bp-0x10], ax */
            ii(0x19_92e2, 2); push(0);                                  /* push 0x0 */
            ii(0x19_92e4, 5); call_far_abs(0x80, 0x51e8);               /* call word 0x80:0x51e8 */
            ii(0x19_92e9, 1); pop(bx);                                  /* pop bx */
            ii(0x19_92ea, 3); mov(memw[ds, 0x1f84], ax);                /* mov [0x1f84], ax */
            ii(0x19_92ed, 4); mov(memw[ds, 0x1f86], dx);                /* mov [0x1f86], dx */
            ii(0x19_92f1, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_92f3, 4); or(ax, memw[ds, 0x1f84]);                 /* or ax, [0x1f84] */
            ii(0x19_92f7, 2); if(jnz(0x19_92fc, 0x3)) goto l_0x19_92fc; /* jnz 0x92fc */
            ii(0x19_92f9, 3); jmp(0x19_93b9, 0xbd); goto l_0x19_93b9;   /* jmp 0x93b9 */
        l_0x19_92fc:
            ii(0x19_92fc, 4); mov(memb[ss, bp - 0x12], 0);              /* mov byte [bp-0x12], 0x0 */
            ii(0x19_9300, 5); mov(memw[ss, bp - 0x18], 0xffff);         /* mov word [bp-0x18], 0xffff */
            ii(0x19_9305, 4); mov(memb[ss, bp - 0x13], 0x9a);           /* mov byte [bp-0x13], 0x9a */
            ii(0x19_9309, 5); mov(memw[ss, bp - 0x2], 0);               /* mov word [bp-0x2], 0x0 */
        l_0x19_930e:
            ii(0x19_930e, 3); mov(ax, memw[ss, bp - 0x2]);              /* mov ax, [bp-0x2] */
            ii(0x19_9311, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x19_9313, 4); add(cx, memw[ds, 0x19ea]);                /* add cx, [0x19ea] */
            ii(0x19_9317, 4); adc(ax, memw[ds, 0x19ec]);                /* adc ax, [0x19ec] */
            ii(0x19_931b, 3); mov(memw[ss, bp - 0xa], cx);              /* mov [bp-0xa], cx */
            ii(0x19_931e, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x19_9321, 5); cmp(memb[ds, 0x19f4], 0);                 /* cmp byte [0x19f4], 0x0 */
            ii(0x19_9326, 2); if(jz(0x19_932e, 0x6)) goto l_0x19_932e;  /* jz 0x932e */
            ii(0x19_9328, 3); or(ah, 0xc0);                             /* or ah, 0xc0 */
            ii(0x19_932b, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
        l_0x19_932e:
            ii(0x19_932e, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x19_9330, 3); mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x19_9333, 3); mov(al, memb[ss, bp - 0x8]);              /* mov al, [bp-0x8] */
            ii(0x19_9336, 3); mov(memb[ss, bp - 0x14], al);             /* mov [bp-0x14], al */
            ii(0x19_9339, 3); mov(al, memb[ss, bp - 0x7]);              /* mov al, [bp-0x7] */
            ii(0x19_933c, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_933e, 3); mov(memb[ss, bp - 0x11], al);             /* mov [bp-0x11], al */
            ii(0x19_9341, 3); mov(bx, memw[ss, bp - 0x2]);              /* mov bx, [bp-0x2] */
            ii(0x19_9344, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x19_9347, 4); les(si, memw[ds, 0x1f84]);                /* les si, [0x1f84] */
            ii(0x19_934b, 1); push(ds);                                 /* push ds */
            ii(0x19_934c, 2); lea(di, memw[ds, bx + si]);               /* lea di, [bx+si] */
            ii(0x19_934e, 3); lea(si, memw[ss, bp - 0x18]);             /* lea si, [bp-0x18] */
            ii(0x19_9351, 1); push(ss);                                 /* push ss */
            ii(0x19_9352, 1); pop(ds);                                  /* pop ds */
            ii(0x19_9353, 1); movsw();                                  /* movsw */
            ii(0x19_9354, 1); movsw();                                  /* movsw */
            ii(0x19_9355, 1); movsw();                                  /* movsw */
            ii(0x19_9356, 1); movsw();                                  /* movsw */
            ii(0x19_9357, 1); pop(ds);                                  /* pop ds */
            ii(0x19_9358, 3); inc(memw[ss, bp - 0x2]);                  /* inc word [bp-0x2] */
            ii(0x19_935b, 5); cmp(memw[ss, bp - 0x2], 0x2000);          /* cmp word [bp-0x2], 0x2000 */
            ii(0x19_9360, 2); if(jb(0x19_930e, -0x54)) goto l_0x19_930e; /* jb 0x930e */
            ii(0x19_9362, 5); mov(memw[ss, bp - 0xe], 0);               /* mov word [bp-0xe], 0x0 */
            ii(0x19_9367, 5); mov(memw[ss, bp - 0xc], 0x8);             /* mov word [bp-0xc], 0x8 */
            ii(0x19_936c, 2); mov(ax, es);                              /* mov ax, es */
            ii(0x19_936e, 2); and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x19_9370, 3); mov(dx, 0x8);                             /* mov dx, 0x8 */
            ii(0x19_9373, 3); mov(memw[ss, bp - 0x6], ax);              /* mov [bp-0x6], ax */
            ii(0x19_9376, 3); mov(memw[ss, bp - 0x4], dx);              /* mov [bp-0x4], dx */
            ii(0x19_9379, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x19_937b, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x19_937d, 5); and(memb[es, bx + 0x5], -0x20 /* 0xe0 */); /* and byte [es:bx+0x5], 0xe0 */
            ii(0x19_9382, 3); les(bx, memw[ss, bp - 0x6]);              /* les bx, [bp-0x6] */
            ii(0x19_9385, 5); or(memb[es, bx + 0x5], 0x2);              /* or byte [es:bx+0x5], 0x2 */
            ii(0x19_938a, 3); les(bx, memw[ss, bp - 0xe]);              /* les bx, [bp-0xe] */
            ii(0x19_938d, 3); mov(ax, memw[ds, 0x1f86]);                /* mov ax, [0x1f86] */
            ii(0x19_9390, 2); and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x19_9392, 2); add(bx, ax);                              /* add bx, ax */
            ii(0x19_9394, 2); mov(ax, es);                              /* mov ax, es */
            ii(0x19_9396, 3); mov(si, memw[ss, bp - 0xe]);              /* mov si, [bp-0xe] */
            ii(0x19_9399, 1); push(ds);                                 /* push ds */
            ii(0x19_939a, 3); lea(di, memw[ds, si + 0x68]);             /* lea di, [si+0x68] */
            ii(0x19_939d, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x19_939f, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_93a1, 1); movsw();                                  /* movsw */
            ii(0x19_93a2, 1); movsw();                                  /* movsw */
            ii(0x19_93a3, 1); movsw();                                  /* movsw */
            ii(0x19_93a4, 1); movsw();                                  /* movsw */
            ii(0x19_93a5, 1); pop(ds);                                  /* pop ds */
            ii(0x19_93a6, 3); mov(ax, 0x68);                            /* mov ax, 0x68 */
            ii(0x19_93a9, 1); nop();                                    /* nop */
            ii(0x19_93aa, 1); push(cs);                                 /* push cs */
            ii(0x19_93ab, 3); call(0x19_e398, 0x4fea);                  /* call 0xe398 */
            ii(0x19_93ae, 1); push(ds);                                 /* push ds */
            ii(0x19_93af, 3); push(0x1b44);                             /* push 0x1b44 */
            ii(0x19_93b2, 3); call(0x1a_1066, 0x7cb1);                  /* call 0x1066 */
            ii(0x19_93b5, 1); pop(bx);                                  /* pop bx */
            ii(0x19_93b6, 1); pop(bx);                                  /* pop bx */
            ii(0x19_93b7, 2); jmp(0x19_93c6, 0xd); goto l_0x19_93c6;    /* jmp 0x93c6 */
        l_0x19_93b9:
            ii(0x19_93b9, 1); push(ds);                                 /* push ds */
            ii(0x19_93ba, 3); push(0x1b60);                             /* push 0x1b60 */
            ii(0x19_93bd, 3); push(0x900);                              /* push 0x900 */
            ii(0x19_93c0, 3); call(0x1a_104e, 0x7c8b);                  /* call 0x104e */
            ii(0x19_93c3, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x19_93c6:
            ii(0x19_93c6, 3); push(memw[ss, bp - 0x10]);                /* push word [bp-0x10] */
            ii(0x19_93c9, 5); call_far_abs(0x80, 0x51ba);               /* call word 0x80:0x51ba */
            ii(0x19_93ce, 1); pop(bx);                                  /* pop bx */
            ii(0x19_93cf, 3); jmp(0x19_92c9, -0x109); goto l_0x19_92c9; /* jmp 0x92c9 */
        l_0x19_93d2:
            ii(0x19_93d2, 1); pop(si);                                  /* pop si */
            ii(0x19_93d3, 1); pop(di);                                  /* pop di */
            ii(0x19_93d4, 1); leave();                                  /* leave */
            ii(0x19_93d5, 1); ret();                                    /* ret */
        }
    }
}
