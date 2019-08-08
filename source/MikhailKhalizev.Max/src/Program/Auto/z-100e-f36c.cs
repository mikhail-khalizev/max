using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b3e1c729-1155-474f-ade4-169470242f65")]
        public void Method_100e_f36c()
        {
            ii(0x100e_f36c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_f371, 5); calld(Definitions.sys_check_available_stack_size, 0x7_69dc); /* call 0x10165d52 */
            ii(0x100e_f376, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_f377, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_f378, 1); pushd(edx);                             /* push edx */
            ii(0x100e_f379, 1); pushd(esi);                             /* push esi */
            ii(0x100e_f37a, 1); pushd(edi);                             /* push edi */
            ii(0x100e_f37b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_f37c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_f37e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_f384, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_f387, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_f38a, 4); mov(ax, memw_a32[ds, eax + 0x21]);      /* mov ax, [eax+0x21] */
            ii(0x100e_f38e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_f391, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_f394, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_f396, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_f397, 1); popd(edi);                              /* pop edi */
            ii(0x100e_f398, 1); popd(esi);                              /* pop esi */
            ii(0x100e_f399, 1); popd(edx);                              /* pop edx */
            ii(0x100e_f39a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_f39b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_f39c, 1); retd(); return;                         /* ret */
        }
    }
}
