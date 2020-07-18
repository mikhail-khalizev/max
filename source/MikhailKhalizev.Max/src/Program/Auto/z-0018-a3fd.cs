using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a3fd-fdeebfd2")]
        public void Method_0018_a3fd()
        {
            ii(0x18_a3fd, 2);  cmp(al, 5);                             /* cmp al, 0x5 */
            ii(0x18_a3ff, 2);  if(jbe(0x18_a406, 5)) goto l_0x18_a406; /* jbe 0xa406 */
            ii(0x18_a401, 3);  mov(ax, 0xffff);                        /* mov ax, 0xffff */
            ii(0x18_a404, 2);  if(jmp_func(0x18_a3f7, -0xf)) return;   /* jmp 0xa3f7 */
        l_0x18_a406:
            ii(0x18_a406, 4);  xchg(memb[ds, 0x980], al);              /* xchg [0x980], al */
            ii(0x18_a40a, 1);  ret();                                  /* ret */
        }
    }
}
