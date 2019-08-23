using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0ab0-44b9eb0e")]
        public void Method_1012_0ab0()
        {
            ii(0x1012_0ab0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_0ab1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0ab2, 1); pushd(edx);                             /* push edx */
            ii(0x1012_0ab3, 1); pushd(esi);                             /* push esi */
            ii(0x1012_0ab4, 1); pushd(edi);                             /* push edi */
            ii(0x1012_0ab5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_0ab6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0ab8, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_0abe, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x1012_0ac2, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1012_0ac5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0ac7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_0ac8, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0ac9, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0aca, 1); popd(edx);                              /* pop edx */
            ii(0x1012_0acb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0acc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0acd, 1); retd();                                 /* ret */
        }
    }
}
