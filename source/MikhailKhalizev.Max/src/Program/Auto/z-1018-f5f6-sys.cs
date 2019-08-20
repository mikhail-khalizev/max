using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f5f6-b0fee08")]
        public void /* sys */ Method_1018_f5f6()
        {
            ii(0x1018_f5f6, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1018_f5f9, 4); mov(memd_a32[ds, edx + edi + 0x4], eax); /* mov [edx+edi+0x4], eax */
            ii(0x1018_f5fd, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_f5ff, 3); add(esi, 0x8);                          /* add esi, 0x8 */
            ii(0x1018_f602, 3); sub(edi, memd_a32[ss, ebp - 0x10]);     /* sub edi, [ebp-0x10] */
            ii(0x1018_f605, 1); retd(); return;                         /* ret */
        }
    }
}
