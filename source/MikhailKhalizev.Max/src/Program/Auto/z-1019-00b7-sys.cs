using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_00b7-4fd0dc52")]
        public void /* sys */ Method_1019_00b7()
        {
            ii(0x1019_00b7, 3); mov(memd[ds, edi + 0x4], eax);          /* mov [edi+0x4], eax */
            ii(0x1019_00ba, 3); add(esi, 0x18);                         /* add esi, 0x18 */
            ii(0x1019_00bd, 3); sub(edi, memd[ss, ebp - 0x10]);         /* sub edi, [ebp-0x10] */
            ii(0x1019_00c0, 1); ret();                                  /* ret */
        }
    }
}
