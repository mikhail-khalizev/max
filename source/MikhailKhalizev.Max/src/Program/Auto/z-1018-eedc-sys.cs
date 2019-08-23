using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_eedc-a2c7f875")]
        public void /* sys */ Method_1018_eedc()
        {
            ii(0x1018_eedc, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1018_eede, 1); popd(esi);                              /* pop esi */
            ii(0x1018_eedf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_eee0, 3); add(esi, 0x10);                         /* add esi, 0x10 */
            ii(0x1018_eee3, 3); sub(edi, 0x4);                          /* sub edi, 0x4 */
            ii(0x1018_eee6, 3); sub(edi, memd_a32[ss, ebp - 0x10]);     /* sub edi, [ebp-0x10] */
            ii(0x1018_eee9, 1); retd();                                 /* ret */
        }
    }
}
