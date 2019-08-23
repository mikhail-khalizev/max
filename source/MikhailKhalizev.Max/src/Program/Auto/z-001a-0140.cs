using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_0140-a0d8a54")]
        public void Method_001a_0140()
        {
            ii(0x1a_0140, 4); enter(0xc, 0);                            /* enter 0xc, 0x0 */
            ii(0x1a_0144, 1); push(ds);                                 /* push ds */
            ii(0x1a_0145, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x1a_0148, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x1a_014a, 5); mov(memw[ss, bp - 0xa], 0);               /* mov word [bp-0xa], 0x0 */
            ii(0x1a_014f, 4); cmp(memw[ss, bp + 0xe], 0);               /* cmp word [bp+0xe], 0x0 */
            ii(0x1a_0153, 2); if(jz(0x1a_019d, 0x48)) goto l_0x1a_019d; /* jz 0x19d */
            ii(0x1a_0155, 3); mov(ax, memw[ss, bp + 0xc]);              /* mov ax, [bp+0xc] */
            ii(0x1a_0158, 3); mov(dx, memw[ss, bp + 0xe]);              /* mov dx, [bp+0xe] */
            ii(0x1a_015b, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x1a_015e, 3); mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x1a_0161, 5); mov(memw[ss, bp - 0xc], 0);               /* mov word [bp-0xc], 0x0 */
            ii(0x1a_0166, 2); jmp(0x1a_017e, 0x16); goto l_0x1a_017e;   /* jmp 0x17e */
        l_0x1a_0168:
            ii(0x1a_0168, 4); cmp(memw[ss, bp - 0xc], 0x3f);            /* cmp word [bp-0xc], 0x3f */
            ii(0x1a_016c, 2); if(jge(0x1a_0187, 0x19)) goto l_0x1a_0187; /* jge 0x187 */
            ii(0x1a_016e, 3); mov(al, memb[es, bx]);                    /* mov al, [es:bx] */
            ii(0x1a_0171, 3); mov(bx, memw[ss, bp - 0xc]);              /* mov bx, [bp-0xc] */
            ii(0x1a_0174, 4); mov(memb[ds, bx + 0x490e], al);           /* mov [bx+0x490e], al */
            ii(0x1a_0178, 3); inc(memw[ss, bp - 0x4]);                  /* inc word [bp-0x4] */
            ii(0x1a_017b, 3); inc(memw[ss, bp - 0xc]);                  /* inc word [bp-0xc] */
        l_0x1a_017e:
            ii(0x1a_017e, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x1a_0181, 4); cmp(memb[es, bx], 0);                     /* cmp byte [es:bx], 0x0 */
            ii(0x1a_0185, 2); if(jnz(0x1a_0168, -0x1f)) goto l_0x1a_0168; /* jnz 0x168 */
        l_0x1a_0187:
            ii(0x1a_0187, 3); mov(bx, memw[ss, bp - 0xc]);              /* mov bx, [bp-0xc] */
            ii(0x1a_018a, 5); mov(memb[ds, bx + 0x490e], 0);            /* mov byte [bx+0x490e], 0x0 */
            ii(0x1a_018f, 1); push(ds);                                 /* push ds */
            ii(0x1a_0190, 3); push(0x490e);                             /* push 0x490e */
            ii(0x1a_0193, 3); push(0x8000);                             /* push 0x8000 */
            ii(0x1a_0196, 1); nop();                                    /* nop */
            ii(0x1a_0197, 1); push(cs);                                 /* push cs */
            ii(0x1a_0198, 3); call(0x1a_106e, 0xed3);                   /* call 0x106e */
            ii(0x1a_019b, 2); jmp(0x1a_01a0, 0x3); goto l_0x1a_01a0;    /* jmp 0x1a0 */
        l_0x1a_019d:
            ii(0x1a_019d, 3); mov(ax, memw[ss, bp + 0xc]);              /* mov ax, [bp+0xc] */
        l_0x1a_01a0:
            ii(0x1a_01a0, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x1a_01a3, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x1a_01a5, 2); if(jl(0x1a_01e5, 0x3e)) goto l_0x1a_01e5; /* jl 0x1e5 */
            ii(0x1a_01a7, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x1a_01aa, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x1a_01ad, 1); push(ax);                                 /* push ax */
            ii(0x1a_01ae, 1); nop();                                    /* nop */
            ii(0x1a_01af, 1); push(cs);                                 /* push cs */
            ii(0x1a_01b0, 3); call(0x1a_15b9, 0x1406);                  /* call 0x15b9 */
            ii(0x1a_01b3, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x1a_01b6, 3); cmp(ax, memw[ss, bp + 0x6]);              /* cmp ax, [bp+0x6] */
            ii(0x1a_01b9, 2); if(jnz(0x1a_01c0, 0x5)) goto l_0x1a_01c0; /* jnz 0x1c0 */
            ii(0x1a_01bb, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x1a_01be, 2); jmp(0x1a_01c2, 0x2); goto l_0x1a_01c2;    /* jmp 0x1c2 */
        l_0x1a_01c0:
            ii(0x1a_01c0, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x1a_01c2:
            ii(0x1a_01c2, 3); mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x1a_01c5, 4); cmp(memw[ss, bp + 0xe], 0);               /* cmp word [bp+0xe], 0x0 */
            ii(0x1a_01c9, 2); if(jz(0x1a_01d5, 0xa)) goto l_0x1a_01d5;  /* jz 0x1d5 */
            ii(0x1a_01cb, 3); push(memw[ss, bp - 0x8]);                 /* push word [bp-0x8] */
            ii(0x1a_01ce, 1); nop();                                    /* nop */
            ii(0x1a_01cf, 1); push(cs);                                 /* push cs */
            ii(0x1a_01d0, 3); call(0x1a_10f7, 0xf24);                   /* call 0x10f7 */
            ii(0x1a_01d3, 2); jmp(0x1a_01e5, 0x10); goto l_0x1a_01e5;   /* jmp 0x1e5 */
        l_0x1a_01d5:
            ii(0x1a_01d5, 3); push(memw[ss, bp - 0x8]);                 /* push word [bp-0x8] */
            ii(0x1a_01d8, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x1a_01db, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x1a_01de, 2); push(0);                                  /* push 0x0 */
            ii(0x1a_01e0, 1); nop();                                    /* nop */
            ii(0x1a_01e1, 1); push(cs);                                 /* push cs */
            ii(0x1a_01e2, 3); call(0x1a_1135, 0xf50);                   /* call 0x1135 */
        l_0x1a_01e5:
            ii(0x1a_01e5, 3); mov(ax, memw[ss, bp - 0xa]);              /* mov ax, [bp-0xa] */
            ii(0x1a_01e8, 1); pop(ds);                                  /* pop ds */
            ii(0x1a_01e9, 1); leave();                                  /* leave */
            ii(0x1a_01ea, 3); retf(0xa);                                /* retf 0xa */
        }
    }
}
