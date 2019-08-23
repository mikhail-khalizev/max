using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_abb8-8c1775ae")]
        public void Method_100a_abb8()
        {
            ii(0x100a_abb8, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_abbd, 5); call(Definitions.sys_check_available_stack_size, 0xb_b190); /* call 0x10165d52 */
            ii(0x100a_abc2, 1); push(ebx);                              /* push ebx */
            ii(0x100a_abc3, 1); push(ecx);                              /* push ecx */
            ii(0x100a_abc4, 1); push(esi);                              /* push esi */
            ii(0x100a_abc5, 1); push(edi);                              /* push edi */
            ii(0x100a_abc6, 1); push(ebp);                              /* push ebp */
            ii(0x100a_abc7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_abc9, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_abcf, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_abd2, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_abd5, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_abd8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_abdb, 5); call(0x1007_6cd0, -0x3_3f10);           /* call 0x10076cd0 */
            ii(0x100a_abe0, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_abe3, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_abe6, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_abe9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_abec, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_abef, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_abf2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_abf4, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_abf5, 1); pop(edi);                               /* pop edi */
            ii(0x100a_abf6, 1); pop(esi);                               /* pop esi */
            ii(0x100a_abf7, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_abf8, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_abf9, 1); ret();                                  /* ret */
        }
    }
}
