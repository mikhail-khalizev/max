using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d361-87e9eeca")]
        public void /* sys */ Method_1018_d361()
        {
            ii(0x1018_d361, 5); mov(eax, memd_a32[ds, 0x1020_a1f8]);    /* mov eax, [0x1020a1f8] */
            ii(0x1018_d366, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1018_d368, 5); mov(memd_a32[ds, 0x1020_a1f8], eax);    /* mov [0x1020a1f8], eax */
            ii(0x1018_d36d, 1); retd();                                 /* ret */
        }
    }
}
