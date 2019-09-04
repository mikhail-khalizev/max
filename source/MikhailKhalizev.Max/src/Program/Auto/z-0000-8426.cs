using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8426-a219881")]
        public void Method_0000_8426()
        {
            ii(0x8426, 4);  enter(0x3e, 0);                            /* enter 0x3e, 0x0 */
            ii(0x842a, 2);  push(0x30);                                /* push 0x30 */
            ii(0x842c, 3);  lea(ax, memw[ss, bp - 52]);                /* lea ax, [bp-0x34] */
            ii(0x842f, 1);  push(ax);                                  /* push ax */
            ii(0x8430, 3);  push(memw[ss, bp + 6]);                    /* push word [bp+0x6] */
            ii(0x8433, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0x8436, 3);  call(0x9cd1, 0x1898);                      /* call 0x9cd1 */
            ii(0x8439, 3);  add(sp, 8);                                /* add sp, 0x8 */
            ii(0x843c, 4);  mov(memb[ss, bp - 29], 0);                 /* mov byte [bp-0x1d], 0x0 */
            ii(0x8440, 5);  cmp(memb[ds, 0xcee], 4);                   /* cmp byte [0xcee], 0x4 */
            ii(0x8445, 2);  if(jge(0x8472, 0x2b)) goto l_0x8472;       /* jge 0x8472 */
            ii(0x8447, 3);  push(0xeee);                               /* push 0xeee */
            ii(0x844a, 3);  lea(ax, memw[ss, bp - 34]);                /* lea ax, [bp-0x22] */
            ii(0x844d, 1);  push(ax);                                  /* push ax */
            ii(0x844e, 3);  call(0x4f4d, -0x3504);                     /* call 0x4f4d */
            ii(0x8451, 1);  pop(bx);                                   /* pop bx */
            ii(0x8452, 1);  pop(bx);                                   /* pop bx */
            ii(0x8453, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x8455, 2);  if(jz(0x8472, 0x1b)) goto l_0x8472;        /* jz 0x8472 */
            ii(0x8457, 3);  mov(ax, memw[ss, bp - 8]);                 /* mov ax, [bp-0x8] */
            ii(0x845a, 3);  mov(dx, memw[ss, bp - 6]);                 /* mov dx, [bp-0x6] */
            ii(0x845d, 2);  and(al, 0xf0);                             /* and al, 0xf0 */
            ii(0x845f, 2);  sub(dh, dh);                               /* sub dh, dh */
            ii(0x8461, 2);  mov(cl, 4);                                /* mov cl, 0x4 */
            ii(0x8463, 3);  call(0x5da0, -0x26c6);                     /* call 0x5da0 */
            ii(0x8466, 3);  mov(memw[ds, 0x98], ax);                   /* mov [0x98], ax */
            ii(0x8469, 4);  mov(memw[ds, 0x9a], dx);                   /* mov [0x9a], dx */
            ii(0x846d, 3);  mov(ax, 1);                                /* mov ax, 0x1 */
            ii(0x8470, 1);  leave();                                   /* leave */
            ii(0x8471, 1);  ret(); return;                             /* ret */
        l_0x8472:
            ii(0x8472, 2);  push(0xa);                                 /* push 0xa */
            ii(0x8474, 3);  lea(ax, memw[ss, bp - 62]);                /* lea ax, [bp-0x3e] */
            ii(0x8477, 1);  push(ax);                                  /* push ax */
            ii(0x8478, 3);  push(0xc8);                                /* push 0xc8 */
            ii(0x847b, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0x847e, 3);  call(0x9cd1, 0x1850);                      /* call 0x9cd1 */
            ii(0x8481, 3);  add(sp, 8);                                /* add sp, 0x8 */
            ii(0x8484, 5);  cmp(memw[ss, bp - 62], 0xff2e);            /* cmp word [bp-0x3e], 0xff2e */
            ii(0x8489, 2);  if(jnz(0x84a0, 0x15)) goto l_0x84a0;       /* jnz 0x84a0 */
            ii(0x848b, 4);  cmp(memb[ss, bp - 57], 0x24);              /* cmp byte [bp-0x39], 0x24 */
            ii(0x848f, 2);  if(jnz(0x84a0, 0xf)) goto l_0x84a0;        /* jnz 0x84a0 */
            ii(0x8491, 3);  push(memw[ss, bp - 56]);                   /* push word [bp-0x38] */
            ii(0x8494, 3);  call(0x9d3c, 0x18a5);                      /* call 0x9d3c */
            ii(0x8497, 1);  pop(bx);                                   /* pop bx */
            ii(0x8498, 4);  add(memw[ds, 0x98], ax);                   /* add [0x98], ax */
            ii(0x849c, 4);  adc(memw[ds, 0x9a], dx);                   /* adc [0x9a], dx */
        l_0x84a0:
            ii(0x84a0, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x84a2, 1);  leave();                                   /* leave */
            ii(0x84a3, 1);  ret();                                     /* ret */
        }
    }
}
