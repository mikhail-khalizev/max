using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f926-ac7cf0c")]
        public void /* sys */ Method_1018_f926()
        {
            ii(0x1018_f926, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1018_f929, 4); mov(memd_a32[ds, edx + edi + 0x4], eax); /* mov [edx+edi+0x4], eax */
            ii(0x1018_f92d, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_f92f, 3); add(esi, 0xc);                          /* add esi, 0xc */
            ii(0x1018_f932, 3); sub(edi, memd_a32[ss, ebp - 0x10]);     /* sub edi, [ebp-0x10] */
            ii(0x1018_f935, 1); retd(); return;                         /* ret */
        }
    }
}
