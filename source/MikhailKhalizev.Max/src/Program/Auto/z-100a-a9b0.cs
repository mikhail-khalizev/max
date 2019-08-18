using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8110093b-0487-4dfc-84da-dc76dae68bee")]
        public void Method_100a_a9b0()
        {
            ii(0x100a_a9b0, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_a9b1, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_a9b2, 1); pushd(edx);                             /* push edx */
            ii(0x100a_a9b3, 1); pushd(esi);                             /* push esi */
            ii(0x100a_a9b4, 1); pushd(edi);                             /* push edi */
            ii(0x100a_a9b5, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_a9b6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a9b8, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_a9be, 7); mov(memd_a32[ss, ebp - 0x4], 0x7fff);   /* mov dword [ebp-0x4], 0x7fff */
            ii(0x100a_a9c5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_a9c8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a9ca, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_a9cb, 1); popd(edi);                              /* pop edi */
            ii(0x100a_a9cc, 1); popd(esi);                              /* pop esi */
            ii(0x100a_a9cd, 1); popd(edx);                              /* pop edx */
            ii(0x100a_a9ce, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_a9cf, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_a9d0, 1); retd(); return;                         /* ret */
        }
    }
}
