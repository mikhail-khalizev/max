using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("450ded69-d9bc-4ff9-ada6-49331fd45c8b")]
        public void Method_1007_9840()
        {
            ii(0x1007_9840, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_9845, 5); calld(Definitions.sys_check_available_stack_size, 0xe_c508); /* call 0x10165d52 */
            ii(0x1007_984a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_984b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_984c, 1); pushd(esi);                             /* push esi */
            ii(0x1007_984d, 1); pushd(edi);                             /* push edi */
            ii(0x1007_984e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_984f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_9851, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_9857, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_985a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_985d, 5); mov(edx, StringDefinitions.MaintainAnAttackReserve); /* mov edx, 0x101a0120 */
            ii(0x1007_9862, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_9865, 5); calld(Definitions.sys_strcpy, 0xe_c665); /* call 0x10165ecf */
            ii(0x1007_986a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_986d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_9870, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_9873, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_9875, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_9876, 1); popd(edi);                              /* pop edi */
            ii(0x1007_9877, 1); popd(esi);                              /* pop esi */
            ii(0x1007_9878, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_9879, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_987a, 1); retd(); return;                         /* ret */
        }
    }
}
