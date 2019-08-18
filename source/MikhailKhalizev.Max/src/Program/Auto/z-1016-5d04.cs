using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a9073392-63c2-4a62-ac7f-096446b6d4c3")]
        public void Method_1016_5d04()
        {
            ii(0x1016_5d04, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_5d05, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_5d06, 1); pushd(edx);                             /* push edx */
            ii(0x1016_5d07, 1); pushd(esi);                             /* push esi */
            ii(0x1016_5d08, 1); pushd(edi);                             /* push edi */
            ii(0x1016_5d09, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_5d0a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_5d0c, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_5d12, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1016_5d16, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1016_5d19, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_5d1b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_5d1c, 1); popd(edi);                              /* pop edi */
            ii(0x1016_5d1d, 1); popd(esi);                              /* pop esi */
            ii(0x1016_5d1e, 1); popd(edx);                              /* pop edx */
            ii(0x1016_5d1f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_5d20, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_5d21, 1); retd(); return;                         /* ret */
        }
    }
}
