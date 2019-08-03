using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e4233831-3112-4ccc-82ac-b42acd7323b3")]
        public void Method_1015_5164()
        {
            ii(0x1015_5164, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_5169, 5); calld(Definitions.sys_check_available_stack_size, 0x10be4); /* call 0x10165d52 */
            ii(0x1015_516e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_516f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_5170, 1); pushd(esi);                             /* push esi */
            ii(0x1015_5171, 1); pushd(edi);                             /* push edi */
            ii(0x1015_5172, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_5173, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_5175, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_517b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_517e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_5181, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1015_5185, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_5188, 5); calld(0x1013_a854, -0x1a939);           /* call 0x1013a854 */
            ii(0x1015_518d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_5190, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_5193, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_5195, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_5196, 1); popd(edi);                              /* pop edi */
            ii(0x1015_5197, 1); popd(esi);                              /* pop esi */
            ii(0x1015_5198, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_5199, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_519a, 1); retd(); return;                         /* ret */
        }
    }
}
