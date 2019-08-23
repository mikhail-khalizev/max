using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0648-c502b1ca")]
        public void Method_1012_0648()
        {
            ii(0x1012_0648, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_0649, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_064a, 1); pushd(edx);                             /* push edx */
            ii(0x1012_064b, 1); pushd(esi);                             /* push esi */
            ii(0x1012_064c, 1); pushd(edi);                             /* push edi */
            ii(0x1012_064d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_064e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0650, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_0656, 7); mov(memd_a32[ss, ebp - 0x4], 0x5);      /* mov dword [ebp-0x4], 0x5 */
            ii(0x1012_065d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_0660, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0662, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_0663, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0664, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0665, 1); popd(edx);                              /* pop edx */
            ii(0x1012_0666, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0667, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0668, 1); retd();                                 /* ret */
        }
    }
}
