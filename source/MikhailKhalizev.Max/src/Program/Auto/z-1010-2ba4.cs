using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_2ba4-b70b8a0f")]
        public void Method_1010_2ba4()
        {
            ii(0x1010_2ba4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_2ba5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_2ba6, 1); pushd(edx);                             /* push edx */
            ii(0x1010_2ba7, 1); pushd(esi);                             /* push esi */
            ii(0x1010_2ba8, 1); pushd(edi);                             /* push edi */
            ii(0x1010_2ba9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_2baa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2bac, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_2bb2, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1010_2bb6, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1010_2bb9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_2bbb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_2bbc, 1); popd(edi);                              /* pop edi */
            ii(0x1010_2bbd, 1); popd(esi);                              /* pop esi */
            ii(0x1010_2bbe, 1); popd(edx);                              /* pop edx */
            ii(0x1010_2bbf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_2bc0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_2bc1, 1); retd(); return;                         /* ret */
        }
    }
}
