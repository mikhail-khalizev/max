using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("049dc20d-1baa-468f-9109-12b84176101c")]
        public void /* sys */ Method_1018_2b48()
        {
            ii(0x1018_2b48, 1); pushd(edx);                             /* push edx */
            ii(0x1018_2b49, 6); mov(edx, memd_a32[ds, 0x101b_e834]);    /* mov edx, [0x101be834] */
            ii(0x1018_2b4f, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_2b51, 2); if(jzd(0x1018_2b5a, 0x7)) goto l_0x1018_2b5a; /* jz 0x10182b5a */
            ii(0x1018_2b53, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_2b55, 5); calld(Definitions.sys_fclose, -0x1_0af1); /* call 0x10172069 */
        l_0x1018_2b5a:
            ii(0x1018_2b5a, 1); popd(edx);                              /* pop edx */
            ii(0x1018_2b5b, 1); retd(); return;                         /* ret */
        }
    }
}
