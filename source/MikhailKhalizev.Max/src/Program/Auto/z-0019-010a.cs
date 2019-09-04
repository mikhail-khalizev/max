using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_010a-6c09f970")]
        public void Method_0019_010a()
        {
            ii(0x19_010a, 4);  movzx(eax, ax);                         /* movzx eax, ax */
            ii(0x19_010e, 2);  xchg(bx, bx);                           /* xchg bx, bx */
            ii(0x19_0110, 1);  push(ds);                               /* push ds */
            ii(0x19_0111, 1);  pop(ss);                                /* pop ss */
            ii(0x19_0112, 3);  lea(sp, memw[ss, bp - 6]);              /* lea sp, [bp-0x6] */
            ii(0x19_0115, 3);  test(eax, eax);                         /* test eax, eax */
            ii(0x19_0118, 2);  if(jz_func(0x19_0120, 6)) return;       /* jz 0x120 */
            ii(0x19_011a, 3);  mov(edi, eax);                          /* mov edi, eax */
            ii(0x19_011d, 3);  if(jmp_func(0x19_0088, -0x98)) return;  /* jmp 0x88 */
        }
    }
}
