using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a4a61439-f39b-48fa-94f0-db47a8f273ab")]
        public void /* sys */ Method_1018_668c()
        {
            ii(0x1018_668c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_668d, 7); cmp(memd_a32[ds, 0x101b_e854], 0);      /* cmp dword [0x101be854], 0x0 */
            ii(0x1018_6694, 2); if(jzd(0x1018_66a5, 0xf)) goto l_0x1018_66a5; /* jz 0x101866a5 */
            ii(0x1018_6696, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_6698, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1018_669d, 6); mov(memd_a32[ds, 0x101b_e858], ebx);    /* mov [0x101be858], ebx */
            ii(0x1018_66a3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_66a4, 1); retd(); return;                         /* ret */
        l_0x1018_66a5:
            ii(0x1018_66a5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_66a7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_66a8, 1); retd(); return;                         /* ret */
        }
    }
}
