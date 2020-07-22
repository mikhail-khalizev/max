using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_e596-99815729")]
        public void Method_0019_e596()
        {
            ii(0x19_e596, 4);  enter(2, 0);                            /* enter 0x2, 0x0 */
            ii(0x19_e59a, 1);  push(di);                               /* push di */
            ii(0x19_e59b, 1);  push(si);                               /* push si */
            ii(0x19_e59c, 1);  push(ds);                               /* push ds */
            ii(0x19_e59d, 3);  push(0x48b6);                           /* push 0x48b6 */
            ii(0x19_e5a0, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_e5a3, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_e5a6, 3);  call(0x19_fff7, 0x1a4e);                /* call 0xfff7 */
            ii(0x19_e5a9, 1);  push(ds);                               /* push ds */
            ii(0x19_e5aa, 3);  push(0x48b6);                           /* push 0x48b6 */
            ii(0x19_e5ad, 3);  call(0x19_ff2f, 0x197f);                /* call 0xff2f */
            ii(0x19_e5b0, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
            ii(0x19_e5b3, 3);  mov(ax, memw[ss, bp - 2]);              /* mov ax, [bp-0x2] */
            ii(0x19_e5b6, 3);  mov(memw[ds, 0x48f6], ax);              /* mov [0x48f6], ax */
        l_0x19_e5b9:
            ii(0x19_e5b9, 3);  dec(memw[ss, bp - 2]);                  /* dec word [bp-0x2] */
            ii(0x19_e5bc, 4);  cmp(memw[ss, bp - 2], 0);               /* cmp word [bp-0x2], 0x0 */
            ii(0x19_e5c0, 2);  if(jge(0x19_e5c5, 3)) goto l_0x19_e5c5; /* jge 0xe5c5 */
            ii(0x19_e5c2, 3);  jmp(0x19_e5e8, 0x23); goto l_0x19_e5e8; /* jmp 0xe5e8 */
        l_0x19_e5c5:
            ii(0x19_e5c5, 3);  mov(bx, memw[ss, bp - 2]);              /* mov bx, [bp-0x2] */
            ii(0x19_e5c8, 5);  cmp(memb[ds, bx + 0x48b6], 0x5c);       /* cmp byte [bx+0x48b6], 0x5c */
            ii(0x19_e5cd, 2);  if(jnz(0x19_e5d2, 3)) goto l_0x19_e5d2; /* jnz 0xe5d2 */
            ii(0x19_e5cf, 3);  jmp(0x19_e5e8, 0x16); goto l_0x19_e5e8; /* jmp 0xe5e8 */
        l_0x19_e5d2:
            ii(0x19_e5d2, 3);  mov(bx, memw[ss, bp - 2]);              /* mov bx, [bp-0x2] */
            ii(0x19_e5d5, 5);  cmp(memb[ds, bx + 0x48b6], 0x2e);       /* cmp byte [bx+0x48b6], 0x2e */
            ii(0x19_e5da, 2);  if(jz(0x19_e5df, 3)) goto l_0x19_e5df;  /* jz 0xe5df */
            ii(0x19_e5dc, 3);  jmp(0x19_e5e5, 6); goto l_0x19_e5e5;    /* jmp 0xe5e5 */
        l_0x19_e5df:
            ii(0x19_e5df, 3);  mov(ax, memw[ss, bp - 2]);              /* mov ax, [bp-0x2] */
            ii(0x19_e5e2, 3);  mov(memw[ds, 0x48f6], ax);              /* mov [0x48f6], ax */
        l_0x19_e5e5:
            ii(0x19_e5e5, 3);  jmp(0x19_e5b9, -0x2f); goto l_0x19_e5b9;/* jmp 0xe5b9 */
        l_0x19_e5e8:
            ii(0x19_e5e8, 1);  pop(si);                                /* pop si */
            ii(0x19_e5e9, 1);  pop(di);                                /* pop di */
            ii(0x19_e5ea, 1);  leave();                                /* leave */
            ii(0x19_e5eb, 1);  retf();                                 /* retf */
        }
    }
}
