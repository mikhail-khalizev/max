using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_e39c-9f6258d5")]
        public void Method_0019_e39c()
        {
            ii(0x19_e39c, 4);  enter(0, 0);                            /* enter 0x0, 0x0 */
            ii(0x19_e3a0, 1);  push(di);                               /* push di */
            ii(0x19_e3a1, 1);  push(si);                               /* push si */
        l_0x19_e3a2:
            ii(0x19_e3a2, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_e3a5, 3);  les(bx, memw[es, bx]);                  /* les bx, [es:bx] */
            ii(0x19_e3a8, 3);  mov(al, memb[es, bx]);                  /* mov al, [es:bx] */
            ii(0x19_e3ab, 1);  cbw();                                  /* cbw */
            ii(0x19_e3ac, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_e3ae, 5);  test(memb[ds, bx + 0x3e4d], 8);         /* test byte [bx+0x3e4d], 0x8 */
            ii(0x19_e3b3, 2);  if(jnz(0x19_e3b8, 3)) goto l_0x19_e3b8; /* jnz 0xe3b8 */
            ii(0x19_e3b5, 3);  jmp(0x19_e3cd, 0x15); goto l_0x19_e3cd; /* jmp 0xe3cd */
        l_0x19_e3b8:
            ii(0x19_e3b8, 4);  cmp(memw[ss, bp + 10], 0);              /* cmp word [bp+0xa], 0x0 */
            ii(0x19_e3bc, 2);  if(jg(0x19_e3c1, 3)) goto l_0x19_e3c1;  /* jg 0xe3c1 */
            ii(0x19_e3be, 3);  jmp(0x19_e3cd, 0xc); goto l_0x19_e3cd;  /* jmp 0xe3cd */
        l_0x19_e3c1:
            ii(0x19_e3c1, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_e3c4, 3);  inc(memw[es, bx]);                      /* inc word [es:bx] */
            ii(0x19_e3c7, 3);  dec(memw[ss, bp + 10]);                 /* dec word [bp+0xa] */
            ii(0x19_e3ca, 3);  jmp(0x19_e3a2, -0x2b); goto l_0x19_e3a2;/* jmp 0xe3a2 */
        l_0x19_e3cd:
            ii(0x19_e3cd, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_e3d0, 3);  les(bx, memw[es, bx]);                  /* les bx, [es:bx] */
            ii(0x19_e3d3, 3);  mov(al, memb[es, bx]);                  /* mov al, [es:bx] */
            ii(0x19_e3d6, 1);  cbw();                                  /* cbw */
            ii(0x19_e3d7, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_e3d9, 5);  test(memb[ds, bx + 0x3e4d], 8);         /* test byte [bx+0x3e4d], 0x8 */
            ii(0x19_e3de, 2);  if(jz(0x19_e3e3, 3)) goto l_0x19_e3e3;  /* jz 0xe3e3 */
            ii(0x19_e3e0, 3);  jmp(0x19_e3f8, 0x15); goto l_0x19_e3f8; /* jmp 0xe3f8 */
        l_0x19_e3e3:
            ii(0x19_e3e3, 4);  cmp(memw[ss, bp + 10], 0);              /* cmp word [bp+0xa], 0x0 */
            ii(0x19_e3e7, 2);  if(jg(0x19_e3ec, 3)) goto l_0x19_e3ec;  /* jg 0xe3ec */
            ii(0x19_e3e9, 3);  jmp(0x19_e3f8, 0xc); goto l_0x19_e3f8;  /* jmp 0xe3f8 */
        l_0x19_e3ec:
            ii(0x19_e3ec, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_e3ef, 3);  inc(memw[es, bx]);                      /* inc word [es:bx] */
            ii(0x19_e3f2, 3);  dec(memw[ss, bp + 10]);                 /* dec word [bp+0xa] */
            ii(0x19_e3f5, 3);  jmp(0x19_e3cd, -0x2b); goto l_0x19_e3cd;/* jmp 0xe3cd */
        l_0x19_e3f8:
            ii(0x19_e3f8, 3);  mov(ax, memw[ss, bp + 10]);             /* mov ax, [bp+0xa] */
            ii(0x19_e3fb, 3);  jmp(0x19_e3fe, 0); goto l_0x19_e3fe;    /* jmp 0xe3fe */
        l_0x19_e3fe:
            ii(0x19_e3fe, 1);  pop(si);                                /* pop si */
            ii(0x19_e3ff, 1);  pop(di);                                /* pop di */
            ii(0x19_e400, 1);  leave();                                /* leave */
            ii(0x19_e401, 1);  retf();                                 /* retf */
        }
    }
}
