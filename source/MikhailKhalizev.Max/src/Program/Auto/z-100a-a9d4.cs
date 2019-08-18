using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a9d4-c502b1ca")]
        public void Method_100a_a9d4()
        {
            ii(0x100a_a9d4, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_a9d5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_a9d6, 1); pushd(edx);                             /* push edx */
            ii(0x100a_a9d7, 1); pushd(esi);                             /* push esi */
            ii(0x100a_a9d8, 1); pushd(edi);                             /* push edi */
            ii(0x100a_a9d9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_a9da, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a9dc, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_a9e2, 7); mov(memd_a32[ss, ebp - 0x4], 0x5);      /* mov dword [ebp-0x4], 0x5 */
            ii(0x100a_a9e9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_a9ec, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a9ee, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_a9ef, 1); popd(edi);                              /* pop edi */
            ii(0x100a_a9f0, 1); popd(esi);                              /* pop esi */
            ii(0x100a_a9f1, 1); popd(edx);                              /* pop edx */
            ii(0x100a_a9f2, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_a9f3, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_a9f4, 1); retd(); return;                         /* ret */
        }
    }
}
