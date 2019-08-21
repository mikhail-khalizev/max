using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_465d-d87c90f6")]
        public void Method_1009_465d()
        {
            ii(0x1009_465d, 5); mov(ecx, 0x1800);                       /* mov ecx, 0x1800 */
            ii(0x1009_4662, 5); mov(ebx, 0x18);                         /* mov ebx, 0x18 */
            ii(0x1009_4667, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_466b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_466d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_4670, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1009_4672, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1009_4674, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_4677, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_467a, 5); calld(0x1009_4165, -0x51a);             /* call 0x10094165 */
            ii(0x1009_467f, 2); test(al, al);                           /* test al, al */
            ii(0x1009_4681, 2); if(jnzd(0x1009_46a9, 0x26)) goto l_0x1009_46a9; /* jnz 0x100946a9 */
            ii(0x1009_4683, 5); mov(ecx, 0x1800);                       /* mov ecx, 0x1800 */
            ii(0x1009_4688, 5); mov(ebx, 0x19);                         /* mov ebx, 0x19 */
            ii(0x1009_468d, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_4691, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_4693, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1009_4696, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1009_4698, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1009_469a, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_469d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_46a0, 5); calld(0x1009_4165, -0x540);             /* call 0x10094165 */
            ii(0x1009_46a5, 2); test(al, al);                           /* test al, al */
            ii(0x1009_46a7, 2); if(jzd(0x1009_46b2, 0x9)) goto l_0x1009_46b2; /* jz 0x100946b2 */
        l_0x1009_46a9:
            ii(0x1009_46a9, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_46ad, 5); if(jmpd_func(0x1009_48ff, 0x24d)) return; /* jmp 0x100948ff */
        l_0x1009_46b2:
            ii(0x1009_46b2, 5); if(jmpd_func(0x1009_4781, 0xca)) return; /* jmp 0x10094781 */
        }
    }
}
