using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a7ac-3312495c")]
        public void Method_100a_a7ac()
        {
            ii(0x100a_a7ac, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_a7b1, 5); call(Definitions.sys_check_available_stack_size, 0xb_b59c); /* call 0x10165d52 */
            ii(0x100a_a7b6, 1); push(ebx);                              /* push ebx */
            ii(0x100a_a7b7, 1); push(ecx);                              /* push ecx */
            ii(0x100a_a7b8, 1); push(esi);                              /* push esi */
            ii(0x100a_a7b9, 1); push(edi);                              /* push edi */
            ii(0x100a_a7ba, 1); push(ebp);                              /* push ebp */
            ii(0x100a_a7bb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a7bd, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_a7c3, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a7c6, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_a7c9, 5); mov(ebx, 8);                            /* mov ebx, 0x8 */
            ii(0x100a_a7ce, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100a_a7d2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a7d5, 5); call(0x100c_d7e8, 0x2_300e);            /* call 0x100cd7e8 */
            ii(0x100a_a7da, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a7dd, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x100a_a7e0, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_a7e3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a7e6, 7); mov(memd[ds, eax + 12], 0x101b_4fc4);   /* mov dword [eax+0xc], 0x101b4fc4 */
            ii(0x100a_a7ed, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a7f0, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100a_a7f3, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_a7f6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a7f8, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_a7f9, 1); pop(edi);                               /* pop edi */
            ii(0x100a_a7fa, 1); pop(esi);                               /* pop esi */
            ii(0x100a_a7fb, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_a7fc, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_a7fd, 1); ret();                                  /* ret */
        }
    }
}
