using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("108b66c0-fd0c-4c09-93ca-12c408dafbad")]
        public void Method_100c_f824()
        {
            ii(0x100c_f824, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_f829, 5); calld(Definitions.sys_check_available_stack_size, 0x9_6524); /* call 0x10165d52 */
            ii(0x100c_f82e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_f82f, 1); pushd(esi);                             /* push esi */
            ii(0x100c_f830, 1); pushd(edi);                             /* push edi */
            ii(0x100c_f831, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_f832, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_f834, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_f83a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_f83d, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_f840, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100c_f843, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f846, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_f849, 3); mov(memd_a32[ds, edx + 0x2d], eax);     /* mov [edx+0x2d], eax */
            ii(0x100c_f84c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_f84f, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_f852, 3); mov(memd_a32[ds, edx + 0x20], eax);     /* mov [edx+0x20], eax */
            ii(0x100c_f855, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_f857, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_f858, 1); popd(edi);                              /* pop edi */
            ii(0x100c_f859, 1); popd(esi);                              /* pop esi */
            ii(0x100c_f85a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_f85b, 1); retd(); return;                         /* ret */
        }
    }
}
