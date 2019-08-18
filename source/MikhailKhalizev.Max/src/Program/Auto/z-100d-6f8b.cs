using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_6f8b-2cfbcfd2")]
        public void Method_100d_6f8b()
        {
            ii(0x100d_6f8b, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_6f90, 5); calld(Definitions.sys_check_available_stack_size, 0x8_edbd); /* call 0x10165d52 */
            ii(0x100d_6f95, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_6f96, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_6f97, 1); pushd(esi);                             /* push esi */
            ii(0x100d_6f98, 1); pushd(edi);                             /* push edi */
            ii(0x100d_6f99, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_6f9a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_6f9c, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_6fa2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_6fa5, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_6fa8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_6fab, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_6fae, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x100d_6fb1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_6fb3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_6fb4, 1); popd(edi);                              /* pop edi */
            ii(0x100d_6fb5, 1); popd(esi);                              /* pop esi */
            ii(0x100d_6fb6, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_6fb7, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_6fb8, 1); retd(); return;                         /* ret */
        }
    }
}
