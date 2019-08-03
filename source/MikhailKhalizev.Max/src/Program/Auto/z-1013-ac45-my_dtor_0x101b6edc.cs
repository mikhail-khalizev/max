using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1c616342-9a75-4e29-96ff-86b625e6e256")]
        public void my_dtor_0x101b6edc()
        {
            ii(0x1013_ac45, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_ac4a, 5); calld(Definitions.sys_check_available_stack_size, 0x2b103); /* call 0x10165d52 */
            ii(0x1013_ac4f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_ac50, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_ac51, 1); pushd(esi);                             /* push esi */
            ii(0x1013_ac52, 1); pushd(edi);                             /* push edi */
            ii(0x1013_ac53, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_ac54, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_ac56, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_ac5c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_ac5f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_ac62, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_ac65, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_ac67, 5); calld(0x1013_add4, 0x168);              /* call 0x1013add4 */
            ii(0x1013_ac6c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_ac6f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_ac72, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_ac75, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_ac77, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_ac78, 1); popd(edi);                              /* pop edi */
            ii(0x1013_ac79, 1); popd(esi);                              /* pop esi */
            ii(0x1013_ac7a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_ac7b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_ac7c, 1); retd(); return;                         /* ret */
        }
    }
}