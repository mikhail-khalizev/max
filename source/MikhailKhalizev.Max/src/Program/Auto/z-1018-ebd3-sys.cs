using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_ebd3-d4ae06a3")]
        public void /* sys */ Method_1018_ebd3()
        {
            ii(0x1018_ebd3, 3); mov(memd[ds, edi + 4], eax);            /* mov [edi+0x4], eax */
            ii(0x1018_ebd6, 1); pop(esi);                               /* pop esi */
            ii(0x1018_ebd7, 1); pop(ebp);                               /* pop ebp */
            ii(0x1018_ebd8, 3); add(esi, 0xa);                          /* add esi, 0xa */
            ii(0x1018_ebdb, 3); sub(edi, memd[ss, ebp - 0x10]);         /* sub edi, [ebp-0x10] */
            ii(0x1018_ebde, 1); ret();                                  /* ret */
        }
    }
}
