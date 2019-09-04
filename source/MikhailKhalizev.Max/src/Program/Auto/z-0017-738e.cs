using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_738e-93b5513d")]
        public void Method_0017_738e()
        {
            ii(0x17_738e, 4);  enter(4, 0);                            /* enter 0x4, 0x0 */
            ii(0x17_7392, 1);  push(ds);                               /* push ds */
            ii(0x17_7393, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_7396, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_7398, 5);  mov(memw[ss, bp - 4], 0);               /* mov word [bp-0x4], 0x0 */
        l_0x17_739d:
            ii(0x17_739d, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x17_73a0, 3);  mov(al, memb[es, bx]);                  /* mov al, [es:bx] */
            ii(0x17_73a3, 3);  mov(memb[ss, bp - 2], al);              /* mov [bp-0x2], al */
            ii(0x17_73a6, 2);  cmp(al, 0x2c);                          /* cmp al, 0x2c */
            ii(0x17_73a8, 2);  if(jz(0x17_73d8, 0x2e)) goto l_0x17_73d8;/* jz 0x73d8 */
            ii(0x17_73aa, 2);  or(al, al);                             /* or al, al */
            ii(0x17_73ac, 2);  if(jz(0x17_73d8, 0x2a)) goto l_0x17_73d8;/* jz 0x73d8 */
            ii(0x17_73ae, 2);  cmp(al, 0x20);                          /* cmp al, 0x20 */
            ii(0x17_73b0, 2);  if(jz(0x17_73d8, 0x26)) goto l_0x17_73d8;/* jz 0x73d8 */
            ii(0x17_73b2, 2);  cmp(al, 0x23);                          /* cmp al, 0x23 */
            ii(0x17_73b4, 2);  if(jz(0x17_73d8, 0x22)) goto l_0x17_73d8;/* jz 0x73d8 */
            ii(0x17_73b6, 1);  cbw();                                  /* cbw */
            ii(0x17_73b7, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x17_73b9, 5);  test(memb[ds, bx + 0x1ca1], 2);         /* test byte [bx+0x1ca1], 0x2 */
            ii(0x17_73be, 2);  if(jz(0x17_73c4, 4)) goto l_0x17_73c4;  /* jz 0x73c4 */
            ii(0x17_73c0, 2);  sub(al, 0x20);                          /* sub al, 0x20 */
            ii(0x17_73c2, 2);  jmp(0x17_73c7, 3); goto l_0x17_73c7;    /* jmp 0x73c7 */
        l_0x17_73c4:
            ii(0x17_73c4, 3);  mov(al, memb[ss, bp - 2]);              /* mov al, [bp-0x2] */
        l_0x17_73c7:
            ii(0x17_73c7, 3);  les(bx, memw[ss, bp + 10]);             /* les bx, [bp+0xa] */
            ii(0x17_73ca, 3);  inc(memw[ss, bp + 10]);                 /* inc word [bp+0xa] */
            ii(0x17_73cd, 3);  mov(memb[es, bx], al);                  /* mov [es:bx], al */
            ii(0x17_73d0, 3);  inc(memw[ss, bp + 6]);                  /* inc word [bp+0x6] */
            ii(0x17_73d3, 3);  inc(memw[ss, bp - 4]);                  /* inc word [bp-0x4] */
            ii(0x17_73d6, 2);  jmp(0x17_739d, -0x3b); goto l_0x17_739d;/* jmp 0x739d */
        l_0x17_73d8:
            ii(0x17_73d8, 4);  cmp(memb[es, bx], 0x2c);                /* cmp byte [es:bx], 0x2c */
            ii(0x17_73dc, 2);  if(jz(0x17_73ea, 0xc)) goto l_0x17_73ea;/* jz 0x73ea */
            ii(0x17_73de, 4);  cmp(memb[es, bx], 0x20);                /* cmp byte [es:bx], 0x20 */
            ii(0x17_73e2, 2);  if(jz(0x17_73ea, 6)) goto l_0x17_73ea;  /* jz 0x73ea */
            ii(0x17_73e4, 4);  cmp(memb[es, bx], 0x23);                /* cmp byte [es:bx], 0x23 */
            ii(0x17_73e8, 2);  if(jnz(0x17_73f4, 0xa)) goto l_0x17_73f4;/* jnz 0x73f4 */
        l_0x17_73ea:
            ii(0x17_73ea, 3);  les(bx, memw[ss, bp + 10]);             /* les bx, [bp+0xa] */
            ii(0x17_73ed, 4);  mov(memb[es, bx], 0);                   /* mov byte [es:bx], 0x0 */
            ii(0x17_73f1, 3);  inc(memw[ss, bp - 4]);                  /* inc word [bp-0x4] */
        l_0x17_73f4:
            ii(0x17_73f4, 3);  les(bx, memw[ss, bp + 10]);             /* les bx, [bp+0xa] */
            ii(0x17_73f7, 3);  inc(memw[ss, bp + 10]);                 /* inc word [bp+0xa] */
            ii(0x17_73fa, 4);  mov(memb[es, bx], 0);                   /* mov byte [es:bx], 0x0 */
            ii(0x17_73fe, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x17_7401, 1);  pop(ds);                                /* pop ds */
            ii(0x17_7402, 1);  leave();                                /* leave */
            ii(0x17_7403, 1);  retf();                                 /* retf */
        }
    }
}
