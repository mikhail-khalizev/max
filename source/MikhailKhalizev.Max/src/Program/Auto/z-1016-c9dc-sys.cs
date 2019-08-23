using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_c9dc-89efee65")]
        public void /* sys */ Method_1016_c9dc()
        {
            ii(0x1016_c9dc, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_c9de, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_c9e0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_c9e2, 3); xchg(memd_a32[ss, ebp + 0x28], ecx);    /* xchg [ebp+0x28], ecx */
            ii(0x1016_c9e5, 3); xchg(memd_a32[ss, ebp + 0x2c], eax);    /* xchg [ebp+0x2c], eax */
            ii(0x1016_c9e8, 2); popd(gs);                               /* pop gs */
            ii(0x1016_c9ea, 2); popd(fs);                               /* pop fs */
            ii(0x1016_c9ec, 1); popd(es);                               /* pop es */
            ii(0x1016_c9ed, 1); popd(ds);                               /* pop ds */
            ii(0x1016_c9ee, 1); popd(edi);                              /* pop edi */
            ii(0x1016_c9ef, 1); popd(esi);                              /* pop esi */
            ii(0x1016_c9f0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_c9f1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_c9f2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_c9f3, 1); popd(edx);                              /* pop edx */
            ii(0x1016_c9f4, 1); retfd();                                /* retf */
        }
    }
}
