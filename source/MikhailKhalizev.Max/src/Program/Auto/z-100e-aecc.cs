using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_aecc-c502b1ca")]
        public void Method_100e_aecc()
        {
            ii(0x100e_aecc, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_aecd, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_aece, 1); pushd(edx);                             /* push edx */
            ii(0x100e_aecf, 1); pushd(esi);                             /* push esi */
            ii(0x100e_aed0, 1); pushd(edi);                             /* push edi */
            ii(0x100e_aed1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_aed2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_aed4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_aeda, 7); mov(memd_a32[ss, ebp - 0x4], 0x5);      /* mov dword [ebp-0x4], 0x5 */
            ii(0x100e_aee1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_aee4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_aee6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_aee7, 1); popd(edi);                              /* pop edi */
            ii(0x100e_aee8, 1); popd(esi);                              /* pop esi */
            ii(0x100e_aee9, 1); popd(edx);                              /* pop edx */
            ii(0x100e_aeea, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_aeeb, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_aeec, 1); retd(); return;                         /* ret */
        }
    }
}
