using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_1d7c-b9bab47c")]
        public void Method_0019_1d7c()
        {
            ii(0x19_1d7c, 2);  jmp(0x19_1d8a, 0xc); goto l_0x19_1d8a;  /* jmp 0x1d8a */
        l_0x19_1d7e:
            ii(0x19_1d7e, 4);  les(bx, memw[ds, 0x3ad8]);              /* les bx, [0x3ad8] */
            ii(0x19_1d82, 4);  inc(memw[ds, 0x3ad8]);                  /* inc word [0x3ad8] */
            ii(0x19_1d86, 4);  mov(memb[es, bx], 0x20);                /* mov byte [es:bx], 0x20 */
        l_0x19_1d8a:
            ii(0x19_1d8a, 4);  dec(memw[ds, 0x3af0]);                  /* dec word [0x3af0] */
            ii(0x19_1d8e, 2);  if(jns(0x19_1d7e, -0x12)) goto l_0x19_1d7e;/* jns 0x1d7e */
            ii(0x19_1d90, 1);  ret();                                  /* ret */
        }
    }
}
