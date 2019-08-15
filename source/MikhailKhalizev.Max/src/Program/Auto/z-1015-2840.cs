using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0fd2f8ea-da5c-459f-a3b6-f61b04a38dcf")]
        public void Method_1015_2840()
        {
            ii(0x1015_2840, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1015_2845, 5); calld(Definitions.sys_check_available_stack_size, 0x1_3508); /* call 0x10165d52 */
            ii(0x1015_284a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_284b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_284c, 1); pushd(esi);                             /* push esi */
            ii(0x1015_284d, 1); pushd(edi);                             /* push edi */
            ii(0x1015_284e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_284f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_2851, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_2857, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_285a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_285d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_2860, 5); calld(0x1015_287d, 0x18);               /* call 0x1015287d */
            ii(0x1015_2865, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_2868, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_286b, 5); add(eax, 0x8a);                         /* add eax, 0x8a */
            ii(0x1015_2870, 5); calld(0x1015_51d4, 0x295f);             /* call 0x101551d4 */
            ii(0x1015_2875, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_2877, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_2878, 1); popd(edi);                              /* pop edi */
            ii(0x1015_2879, 1); popd(esi);                              /* pop esi */
            ii(0x1015_287a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_287b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_287c, 1); retd(); return;                         /* ret */
        }
    }
}
