using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x970c-10c27501")]
        public void Method_0000_970c()
        {
            ii(0x970c, 4);  enter(0x18, 0);                            /* enter 0x18, 0x0 */
            ii(0x9710, 4);  mov(memb[ss, bp - 13], 0x48);              /* mov byte [bp-0xd], 0x48 */
            ii(0x9714, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0x9717, 3);  mov(memw[ss, bp - 12], ax);                /* mov [bp-0xc], ax */
            ii(0x971a, 3);  lea(ax, memw[ss, bp - 14]);                /* lea ax, [bp-0xe] */
            ii(0x971d, 1);  push(ax);                                  /* push ax */
            ii(0x971e, 1);  push(ax);                                  /* push ax */
            ii(0x971f, 3);  call(0x8480, -0x12a2);                     /* call 0x8480 */
            ii(0x9722, 1);  pop(bx);                                   /* pop bx */
            ii(0x9723, 1);  pop(bx);                                   /* pop bx */
            ii(0x9724, 4);  test(memb[ss, bp - 2], 1);                 /* test byte [bp-0x2], 0x1 */
            ii(0x9728, 2);  if(jz(0x972f, 5)) goto l_0x972f;           /* jz 0x972f */
            ii(0x972a, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0x972c, 1);  cwd();                                     /* cwd */
            ii(0x972d, 1);  leave();                                   /* leave */
            ii(0x972e, 1);  ret(); return;                             /* ret */
        l_0x972f:
            ii(0x972f, 3);  mov(ax, memw[ss, bp - 14]);                /* mov ax, [bp-0xe] */
            ii(0x9732, 2);  sub(dx, dx);                               /* sub dx, dx */
            ii(0x9734, 1);  leave();                                   /* leave */
            ii(0x9735, 1);  ret();                                     /* ret */
        }
    }
}
