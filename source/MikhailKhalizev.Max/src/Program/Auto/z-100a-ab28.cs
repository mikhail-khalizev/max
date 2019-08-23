using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_ab28-c502b1ca")]
        public void Method_100a_ab28()
        {
            ii(0x100a_ab28, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_ab29, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_ab2a, 1); pushd(edx);                             /* push edx */
            ii(0x100a_ab2b, 1); pushd(esi);                             /* push esi */
            ii(0x100a_ab2c, 1); pushd(edi);                             /* push edi */
            ii(0x100a_ab2d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_ab2e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ab30, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_ab36, 7); mov(memd_a32[ss, ebp - 0x4], 0x5);      /* mov dword [ebp-0x4], 0x5 */
            ii(0x100a_ab3d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ab40, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ab42, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_ab43, 1); popd(edi);                              /* pop edi */
            ii(0x100a_ab44, 1); popd(esi);                              /* pop esi */
            ii(0x100a_ab45, 1); popd(edx);                              /* pop edx */
            ii(0x100a_ab46, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_ab47, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_ab48, 1); retd();                                 /* ret */
        }
    }
}
