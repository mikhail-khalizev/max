using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xa346-9206a211")]
        public void Method_0000_a346()
        {
            ii(0xa346, 3);  call(0xa2f8, -0x51);                       /* call 0xa2f8 */
            ii(0xa349, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0xa34b, 2);  if(jnz(0xa350, 3)) goto l_0xa350;          /* jnz 0xa350 */
            ii(0xa34d, 3);  call(0x9420, -0xf30);                      /* call 0x9420 */
        l_0xa350:
            ii(0xa350, 3);  mov(dx, 0x12cc);                           /* mov dx, 0x12cc */
            ii(0xa353, 2);  mov(ah, 0x25);                             /* mov ah, 0x25 */
            ii(0xa355, 3);  mov(al, memb[ds, 0x34]);                   /* mov al, [0x34] */
            ii(0xa358, 1);  push(cs);                                  /* push cs */
            ii(0xa359, 1);  pop(ds);                                   /* pop ds */
            ii(0xa35a, 4);  mov(memw[ds, 0x12ca], cs);                 /* mov [0x12ca], cs */
            ii(0xa35e, 2);  @int(0x21);                                /* int 0x21 */
            ii(0xa360, 1);  push(ss);                                  /* push ss */
            ii(0xa361, 1);  pop(ds);                                   /* pop ds */
            ii(0xa362, 1);  ret();                                     /* ret */
        }
    }
}
