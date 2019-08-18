using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_ac50-44b9eb0e")]
        public void Method_1008_ac50()
        {
            ii(0x1008_ac50, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_ac51, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_ac52, 1); pushd(edx);                             /* push edx */
            ii(0x1008_ac53, 1); pushd(esi);                             /* push esi */
            ii(0x1008_ac54, 1); pushd(edi);                             /* push edi */
            ii(0x1008_ac55, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_ac56, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_ac58, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1008_ac5e, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x1008_ac62, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1008_ac65, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_ac67, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_ac68, 1); popd(edi);                              /* pop edi */
            ii(0x1008_ac69, 1); popd(esi);                              /* pop esi */
            ii(0x1008_ac6a, 1); popd(edx);                              /* pop edx */
            ii(0x1008_ac6b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_ac6c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_ac6d, 1); retd(); return;                         /* ret */
        }
    }
}
