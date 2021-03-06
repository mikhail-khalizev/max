using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_f896-470b9480")]
        public void Method_0019_f896()
        {
            ii(0x19_f896, 4);  enter(4, 0);                            /* enter 0x4, 0x0 */
            ii(0x19_f89a, 1);  push(di);                               /* push di */
            ii(0x19_f89b, 1);  push(si);                               /* push si */
            ii(0x19_f89c, 4);  mov(es, memw[ds, 0x3fdc]);              /* mov es, [0x3fdc] */
            ii(0x19_f8a0, 4);  mov(ax, memw[es, 0x3b78]);              /* mov ax, [es:0x3b78] */
            ii(0x19_f8a4, 5);  mov(memw[ss, bp - 4], 0);               /* mov word [bp-0x4], 0x0 */
            ii(0x19_f8a9, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
            ii(0x19_f8ac, 2);  push(0);                                /* push 0x0 */
            ii(0x19_f8ae, 2);  push(0x23);                             /* push 0x23 */
            ii(0x19_f8b0, 1);  nop();                                  /* nop */
            ii(0x19_f8b1, 1);  push(cs);                               /* push cs */
            ii(0x19_f8b2, 3);  call(0x1a_606f, 0x67ba);                /* call 0x606f */
            ii(0x19_f8b5, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x19_f8b8, 4);  cmp(memw[ss, bp + 6], 0);               /* cmp word [bp+0x6], 0x0 */
            ii(0x19_f8bc, 2);  if(jnz(0x19_f8c1, 3)) goto l_0x19_f8c1; /* jnz 0xf8c1 */
            ii(0x19_f8be, 3);  jmp(0x19_f8c1, 0); goto l_0x19_f8c1;    /* jmp 0xf8c1 */
        l_0x19_f8c1:
            ii(0x19_f8c1, 3);  les(bx, memw[ss, bp - 4]);              /* les bx, [bp-0x4] */
            ii(0x19_f8c4, 5);  test(memb[es, bx + 71], 1);             /* test byte [es:bx+0x47], 0x1 */
            ii(0x19_f8c9, 2);  if(jnz(0x19_f8ce, 3)) goto l_0x19_f8ce; /* jnz 0xf8ce */
            ii(0x19_f8cb, 3);  jmp(0x19_f8e3, 0x15); goto l_0x19_f8e3; /* jmp 0xf8e3 */
        l_0x19_f8ce:
            ii(0x19_f8ce, 2);  push(0);                                /* push 0x0 */
            ii(0x19_f8d0, 2);  push(0x1b);                             /* push 0x1b */
            ii(0x19_f8d2, 1);  nop();                                  /* nop */
            ii(0x19_f8d3, 1);  push(cs);                               /* push cs */
            ii(0x19_f8d4, 3);  call(0x1a_606f, 0x6798);                /* call 0x606f */
            ii(0x19_f8d7, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x19_f8da, 4);  cmp(memw[ss, bp + 6], 0);               /* cmp word [bp+0x6], 0x0 */
            ii(0x19_f8de, 2);  if(jnz(0x19_f8e3, 3)) goto l_0x19_f8e3; /* jnz 0xf8e3 */
            ii(0x19_f8e0, 3);  jmp(0x19_f8e3, 0); goto l_0x19_f8e3;    /* jmp 0xf8e3 */
        l_0x19_f8e3:
            ii(0x19_f8e3, 5);  mov(memb[ds, 0x308a], 0);               /* mov byte [0x308a], 0x0 */
            ii(0x19_f8e8, 1);  pop(si);                                /* pop si */
            ii(0x19_f8e9, 1);  pop(di);                                /* pop di */
            ii(0x19_f8ea, 1);  leave();                                /* leave */
            ii(0x19_f8eb, 1);  retf();                                 /* retf */
        }
    }
}
