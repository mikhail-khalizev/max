using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_13a6-b7a361c")]
        public void Method_001a_13a6()
        {
            ii(0x1a_13a6, 4);  enter(0xb2, 0);                         /* enter 0xb2, 0x0 */
            ii(0x1a_13aa, 6);  mov(memw[ss, bp - 178], 0);             /* mov word [bp-0xb2], 0x0 */
        l_0x1a_13b0:
            ii(0x1a_13b0, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x1a_13b3, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x1a_13b6, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x1a_13b9, 2);  push(0);                                /* push 0x0 */
            ii(0x1a_13bb, 3);  call(0x19_fed2, -0x14ec);               /* call 0xfed2 */
            ii(0x1a_13be, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x1a_13c1, 4);  lea(ax, memw[ss, bp - 176]);            /* lea ax, [bp-0xb0] */
            ii(0x1a_13c5, 1);  push(ss);                               /* push ss */
            ii(0x1a_13c6, 1);  push(ax);                               /* push ax */
            ii(0x1a_13c7, 3);  push(0xb0);                             /* push 0xb0 */
            ii(0x1a_13ca, 3);  call(0x19_fef1, -0x14dc);               /* call 0xfef1 */
            ii(0x1a_13cd, 3);  cmp(ax, 0xb0);                          /* cmp ax, 0xb0 */
            ii(0x1a_13d0, 2);  if(jnz(0x1a_1436, 0x64)) goto l_0x1a_1436;/* jnz 0x1436 */
            ii(0x1a_13d2, 5);  cmp(memb[ss, bp - 176], 0x4d);          /* cmp byte [bp-0xb0], 0x4d */
            ii(0x1a_13d7, 2);  if(jnz(0x1a_13f0, 0x17)) goto l_0x1a_13f0;/* jnz 0x13f0 */
            ii(0x1a_13d9, 5);  cmp(memb[ss, bp - 175], 0x46);          /* cmp byte [bp-0xaf], 0x46 */
            ii(0x1a_13de, 2);  if(jnz(0x1a_13f0, 0x10)) goto l_0x1a_13f0;/* jnz 0x13f0 */
            ii(0x1a_13e0, 4);  mov(ax, memw[ss, bp - 174]);            /* mov ax, [bp-0xae] */
            ii(0x1a_13e4, 4);  mov(dx, memw[ss, bp - 172]);            /* mov dx, [bp-0xac] */
        l_0x1a_13e8:
            ii(0x1a_13e8, 3);  add(memw[ss, bp + 8], ax);              /* add [bp+0x8], ax */
            ii(0x1a_13eb, 3);  adc(memw[ss, bp + 10], dx);             /* adc [bp+0xa], dx */
            ii(0x1a_13ee, 2);  jmp(0x1a_13b0, -0x40); goto l_0x1a_13b0;/* jmp 0x13b0 */
        l_0x1a_13f0:
            ii(0x1a_13f0, 5);  cmp(memb[ss, bp - 176], 0x4d);          /* cmp byte [bp-0xb0], 0x4d */
            ii(0x1a_13f5, 2);  if(jnz(0x1a_140c, 0x15)) goto l_0x1a_140c;/* jnz 0x140c */
            ii(0x1a_13f7, 5);  cmp(memb[ss, bp - 175], 0x5a);          /* cmp byte [bp-0xaf], 0x5a */
            ii(0x1a_13fc, 2);  if(jnz(0x1a_140c, 0xe)) goto l_0x1a_140c;/* jnz 0x140c */
            ii(0x1a_13fe, 4);  lea(ax, memw[ss, bp - 176]);            /* lea ax, [bp-0xb0] */
            ii(0x1a_1402, 1);  push(ss);                               /* push ss */
            ii(0x1a_1403, 1);  push(ax);                               /* push ax */
            ii(0x1a_1404, 1);  push(cs);                               /* push cs */
            ii(0x1a_1405, 3);  call(0x1a_143c, 0x34);                  /* call 0x143c */
            ii(0x1a_1408, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_1409, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_140a, 2);  jmp(0x1a_13e8, -0x24); goto l_0x1a_13e8;/* jmp 0x13e8 */
        l_0x1a_140c:
            ii(0x1a_140c, 5);  cmp(memb[ss, bp - 176], 0x42);          /* cmp byte [bp-0xb0], 0x42 */
            ii(0x1a_1411, 2);  if(jz(0x1a_141a, 7)) goto l_0x1a_141a;  /* jz 0x141a */
            ii(0x1a_1413, 5);  cmp(memb[ss, bp - 175], 0x57);          /* cmp byte [bp-0xaf], 0x57 */
            ii(0x1a_1418, 2);  if(jnz(0x1a_1436, 0x1c)) goto l_0x1a_1436;/* jnz 0x1436 */
        l_0x1a_141a:
            ii(0x1a_141a, 4);  test(memb[ss, bp - 124], 1);            /* test byte [bp-0x7c], 0x1 */
            ii(0x1a_141e, 2);  if(jz(0x1a_1436, 0x16)) goto l_0x1a_1436;/* jz 0x1436 */
            ii(0x1a_1420, 6);  mov(memw[ss, bp - 178], 1);             /* mov word [bp-0xb2], 0x1 */
            ii(0x1a_1426, 3);  mov(ax, memw[ss, bp + 8]);              /* mov ax, [bp+0x8] */
            ii(0x1a_1429, 3);  mov(dx, memw[ss, bp + 10]);             /* mov dx, [bp+0xa] */
            ii(0x1a_142c, 3);  les(bx, memw[ss, bp + 12]);             /* les bx, [bp+0xc] */
            ii(0x1a_142f, 3);  mov(memw[es, bx], ax);                  /* mov [es:bx], ax */
            ii(0x1a_1432, 4);  mov(memw[es, bx + 2], dx);              /* mov [es:bx+0x2], dx */
        l_0x1a_1436:
            ii(0x1a_1436, 4);  mov(ax, memw[ss, bp - 178]);            /* mov ax, [bp-0xb2] */
            ii(0x1a_143a, 1);  leave();                                /* leave */
            ii(0x1a_143b, 1);  retf();                                 /* retf */
        }
    }
}
