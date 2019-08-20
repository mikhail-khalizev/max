using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f0ba-3b1201e9")]
        public void /* sys */ Method_1018_f0ba()
        {
            ii(0x1018_f0ba, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1018_f0bc, 1); popd(esi);                              /* pop esi */
            ii(0x1018_f0bd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_f0be, 3); add(esi, 0xc);                          /* add esi, 0xc */
            ii(0x1018_f0c1, 3); sub(edi, 0x4);                          /* sub edi, 0x4 */
            ii(0x1018_f0c4, 3); sub(edi, memd_a32[ss, ebp - 0x10]);     /* sub edi, [ebp-0x10] */
            ii(0x1018_f0c7, 1); retd(); return;                         /* ret */
        }
    }
}
