using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_b399-d1c016e6")]
        public void Method_1013_b399()
        {
            ii(0x1013_b399, 5); push(0x28);                             /* push 0x28 */
            ii(0x1013_b39e, 5); call(Definitions.sys_check_available_stack_size, 0x2_a9af); /* call 0x10165d52 */
            ii(0x1013_b3a3, 1); push(ebx);                              /* push ebx */
            ii(0x1013_b3a4, 1); push(ecx);                              /* push ecx */
            ii(0x1013_b3a5, 1); push(esi);                              /* push esi */
            ii(0x1013_b3a6, 1); push(edi);                              /* push edi */
            ii(0x1013_b3a7, 1); push(ebp);                              /* push ebp */
            ii(0x1013_b3a8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b3aa, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_b3b0, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_b3b3, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_b3b6, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_b3ba, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_b3bd, 5); call(0x1013_b052, -0x370);              /* call 0x1013b052 */
            ii(0x1013_b3c2, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_b3c5, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1013_b3c8, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_b3cb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_b3ce, 7); mov(memd[ds, eax + 0xa], 0x101b_6efc);  /* mov dword [eax+0xa], 0x101b6efc */
            ii(0x1013_b3d5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_b3d8, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_b3db, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_b3de, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b3e0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_b3e1, 1); pop(edi);                               /* pop edi */
            ii(0x1013_b3e2, 1); pop(esi);                               /* pop esi */
            ii(0x1013_b3e3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_b3e4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_b3e5, 1); ret();                                  /* ret */
        }
    }
}
