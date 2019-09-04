using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f4eb-5010ff5e")]
        public void /* sys */ Method_1018_f4eb()
        {
            ii(0x1018_f4eb, 3);  mov(memd[ds, edi + 4], eax);          /* mov [edi+0x4], eax */
            ii(0x1018_f4ee, 3);  add(esi, 0x14);                       /* add esi, 0x14 */
            ii(0x1018_f4f1, 3);  sub(edi, memd[ss, ebp - 16]);         /* sub edi, [ebp-0x10] */
            ii(0x1018_f4f4, 1);  ret();                                /* ret */
        }
    }
}
