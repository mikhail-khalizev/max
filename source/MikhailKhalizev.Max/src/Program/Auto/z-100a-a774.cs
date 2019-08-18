using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("441b4741-7740-4162-a7b7-55d94abf3245")]
        public void Method_100a_a774()
        {
            ii(0x100a_a774, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_a779, 5); calld(Definitions.sys_check_available_stack_size, 0xb_b5d4); /* call 0x10165d52 */
            ii(0x100a_a77e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_a77f, 1); pushd(esi);                             /* push esi */
            ii(0x100a_a780, 1); pushd(edi);                             /* push edi */
            ii(0x100a_a781, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_a782, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a784, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a78a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_a78d, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_a790, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100a_a793, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100a_a797, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_a79a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_a79d, 5); calld(0x100c_d990, 0x2_31ee);           /* call 0x100cd990 */
            ii(0x100a_a7a2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a7a4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_a7a5, 1); popd(edi);                              /* pop edi */
            ii(0x100a_a7a6, 1); popd(esi);                              /* pop esi */
            ii(0x100a_a7a7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_a7a8, 1); retd(); return;                         /* ret */
        }
    }
}
