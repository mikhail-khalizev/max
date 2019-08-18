using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_5110-af1c494d")]
        public void Method_1015_5110()
        {
            ii(0x1015_5110, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1015_5115, 5); calld(Definitions.sys_check_available_stack_size, 0x1_0c38); /* call 0x10165d52 */
            ii(0x1015_511a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_511b, 1); pushd(esi);                             /* push esi */
            ii(0x1015_511c, 1); pushd(edi);                             /* push edi */
            ii(0x1015_511d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_511e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_5120, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_5126, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_5129, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1015_512c, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1015_512f, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1015_5132, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1015_5135, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_5138, 5); calld(0x1013_a427, -0x1_ad16);          /* call 0x1013a427 */
            ii(0x1015_513d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_513f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_5140, 1); popd(edi);                              /* pop edi */
            ii(0x1015_5141, 1); popd(esi);                              /* pop esi */
            ii(0x1015_5142, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_5143, 1); retd(); return;                         /* ret */
        }
    }
}
