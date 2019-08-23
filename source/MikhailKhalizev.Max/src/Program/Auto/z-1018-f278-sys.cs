using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f278-d443d7a5")]
        public void /* sys */ Method_1018_f278()
        {
            ii(0x1018_f278, 3); mov(memd[ds, edi + 0x4], eax);          /* mov [edi+0x4], eax */
            ii(0x1018_f27b, 1); pop(esi);                               /* pop esi */
            ii(0x1018_f27c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1018_f27d, 3); add(esi, 0xc);                          /* add esi, 0xc */
            ii(0x1018_f280, 3); sub(edi, memd[ss, ebp - 0x10]);         /* sub edi, [ebp-0x10] */
            ii(0x1018_f283, 1); ret();                                  /* ret */
        }
    }
}
