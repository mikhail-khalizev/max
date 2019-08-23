using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_b44c-95d9909f")]
        public void /* sys */ Method_1016_b44c()
        {
            ii(0x1016_b44c, 1); push(edx);                              /* push edx */
            ii(0x1016_b44d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_b44f, 6); mov(memd[ds, 0x101c_fb7c], edx);        /* mov [0x101cfb7c], edx */
            ii(0x1016_b455, 1); pop(edx);                               /* pop edx */
            ii(0x1016_b456, 1); ret();                                  /* ret */
        }
    }
}
