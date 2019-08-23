using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a824-f8abc236")]
        public void Method_100c_a824()
        {
            ii(0x100c_a824, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_a829, 5); calld(Definitions.sys_check_available_stack_size, 0x9_b524); /* call 0x10165d52 */
            ii(0x100c_a82e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_a82f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_a830, 1); pushd(esi);                             /* push esi */
            ii(0x100c_a831, 1); pushd(edi);                             /* push edi */
            ii(0x100c_a832, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_a833, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a835, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a83b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a83e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_a841, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100c_a846, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a849, 5); calld(0x1013_b0a5, 0x7_0857);           /* call 0x1013b0a5 */
            ii(0x100c_a84e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a851, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a854, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_a857, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_a85a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a85c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_a85d, 1); popd(edi);                              /* pop edi */
            ii(0x100c_a85e, 1); popd(esi);                              /* pop esi */
            ii(0x100c_a85f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_a860, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_a861, 1); retd();                                 /* ret */
        }
    }
}
