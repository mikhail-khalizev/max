using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6fc6633b-4366-44af-96fe-cf0653d525ba")]
        public void Method_1012_0a90()
        {
            ii(0x1012_0a90, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_0a91, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0a92, 1); pushd(edx);                             /* push edx */
            ii(0x1012_0a93, 1); pushd(esi);                             /* push esi */
            ii(0x1012_0a94, 1); pushd(edi);                             /* push edi */
            ii(0x1012_0a95, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_0a96, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0a98, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_0a9e, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x1012_0aa2, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1012_0aa5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0aa7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_0aa8, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0aa9, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0aaa, 1); popd(edx);                              /* pop edx */
            ii(0x1012_0aab, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0aac, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0aad, 1); retd(); return;                         /* ret */
        }
    }
}
