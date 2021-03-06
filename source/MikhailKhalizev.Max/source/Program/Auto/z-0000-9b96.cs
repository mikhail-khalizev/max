using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9b96-9206a211")]
        public void Method_0000_9b96()
        {
            ii(0x9b96, 3);  call(0x9b48, -0x51);                       /* call 0x9b48 */
            ii(0x9b99, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x9b9b, 2);  if(jnz(0x9ba0, 3)) goto l_0x9ba0;          /* jnz 0x9ba0 */
            ii(0x9b9d, 3);  call(0x8c70, -0xf30);                      /* call 0x8c70 */
        l_0x9ba0:
            ii(0x9ba0, 3);  mov(dx, 0x12cc);                           /* mov dx, 0x12cc */
            ii(0x9ba3, 2);  mov(ah, 0x25);                             /* mov ah, 0x25 */
            ii(0x9ba5, 3);  mov(al, memb[ds, 0x34]);                   /* mov al, [0x34] */
            ii(0x9ba8, 1);  push(cs);                                  /* push cs */
            ii(0x9ba9, 1);  pop(ds);                                   /* pop ds */
            ii(0x9baa, 4);  mov(memw[ds, 0x12ca], cs);                 /* mov [0x12ca], cs */
            ii(0x9bae, 2);  @int(0x21);                                /* int 0x21 */
            ii(0x9bb0, 1);  push(ss);                                  /* push ss */
            ii(0x9bb1, 1);  pop(ds);                                   /* pop ds */
            ii(0x9bb2, 1);  ret();                                     /* ret */
        }
    }
}
