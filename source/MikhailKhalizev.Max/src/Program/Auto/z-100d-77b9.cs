using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6d504782-9e5d-4029-924f-dc9d663a410f")]
        public void Method_100d_77b9()
        {
            ii(0x100d_77b9, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_77be, 5); calld(Definitions.sys_check_available_stack_size, 0x8_e58f); /* call 0x10165d52 */
            ii(0x100d_77c3, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_77c4, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_77c5, 1); pushd(esi);                             /* push esi */
            ii(0x100d_77c6, 1); pushd(edi);                             /* push edi */
            ii(0x100d_77c7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_77c8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_77ca, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_77d0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_77d3, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_77d6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_77d9, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_77dc, 4); mov(memw_a32[ds, edx + 0x2d], ax);      /* mov [edx+0x2d], ax */
            ii(0x100d_77e0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_77e2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_77e3, 1); popd(edi);                              /* pop edi */
            ii(0x100d_77e4, 1); popd(esi);                              /* pop esi */
            ii(0x100d_77e5, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_77e6, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_77e7, 1); retd(); return;                         /* ret */
        }
    }
}
