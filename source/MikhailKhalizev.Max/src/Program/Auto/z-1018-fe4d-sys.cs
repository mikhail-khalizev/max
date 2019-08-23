using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_fe4d-e29589fe")]
        public void /* sys */ Method_1018_fe4d()
        {
            ii(0x1018_fe4d, 2); mov(memd[ds, edi], eax);                /* mov [edi], eax */
            ii(0x1018_fe4f, 3); add(esi, 0x18);                         /* add esi, 0x18 */
            ii(0x1018_fe52, 3); sub(edi, 0x4);                          /* sub edi, 0x4 */
            ii(0x1018_fe55, 3); sub(edi, memd[ss, ebp - 0x10]);         /* sub edi, [ebp-0x10] */
            ii(0x1018_fe58, 1); ret();                                  /* ret */
        }
    }
}
