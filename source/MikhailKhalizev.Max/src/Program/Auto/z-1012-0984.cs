using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0984-a59ca9b0")]
        public void Method_1012_0984()
        {
            ii(0x1012_0984, 5); push(0x28);                             /* push 0x28 */
            ii(0x1012_0989, 5); call(Definitions.sys_check_available_stack_size, 0x4_53c4); /* call 0x10165d52 */
            ii(0x1012_098e, 1); push(ebx);                              /* push ebx */
            ii(0x1012_098f, 1); push(ecx);                              /* push ecx */
            ii(0x1012_0990, 1); push(esi);                              /* push esi */
            ii(0x1012_0991, 1); push(edi);                              /* push edi */
            ii(0x1012_0992, 1); push(ebp);                              /* push ebp */
            ii(0x1012_0993, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0995, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_099b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_099e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1012_09a1, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_09a4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_09a7, 5); call(0x1013_abc3, 0x1_a217);            /* call 0x1013abc3 */
            ii(0x1012_09ac, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_09af, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_09b2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1012_09b5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_09b8, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_09bb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_09be, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_09c0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_09c1, 1); pop(edi);                               /* pop edi */
            ii(0x1012_09c2, 1); pop(esi);                               /* pop esi */
            ii(0x1012_09c3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_09c4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_09c5, 1); ret();                                  /* ret */
        }
    }
}
