using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3a975a59-5b41-4ffa-81af-59f654d0fb7c")]
        public void Method_1010_2aac()
        {
            ii(0x1010_2aac, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_2aad, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_2aae, 1); pushd(edx);                             /* push edx */
            ii(0x1010_2aaf, 1); pushd(esi);                             /* push esi */
            ii(0x1010_2ab0, 1); pushd(edi);                             /* push edi */
            ii(0x1010_2ab1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_2ab2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2ab4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_2aba, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1010_2abe, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1010_2ac1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_2ac3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_2ac4, 1); popd(edi);                              /* pop edi */
            ii(0x1010_2ac5, 1); popd(esi);                              /* pop esi */
            ii(0x1010_2ac6, 1); popd(edx);                              /* pop edx */
            ii(0x1010_2ac7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_2ac8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_2ac9, 1); retd(); return;                         /* ret */
        }
    }
}
