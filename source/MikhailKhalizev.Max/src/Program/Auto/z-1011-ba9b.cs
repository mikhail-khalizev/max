using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_ba9b-376296b4")]
        public void Method_1011_ba9b()
        {
            ii(0x1011_ba9b, 5); push(0x24);                             /* push 0x24 */
            ii(0x1011_baa0, 5); call(Definitions.sys_check_available_stack_size, 0x4_a2ad); /* call 0x10165d52 */
            ii(0x1011_baa5, 1); push(ebx);                              /* push ebx */
            ii(0x1011_baa6, 1); push(ecx);                              /* push ecx */
            ii(0x1011_baa7, 1); push(esi);                              /* push esi */
            ii(0x1011_baa8, 1); push(edi);                              /* push edi */
            ii(0x1011_baa9, 1); push(ebp);                              /* push ebp */
            ii(0x1011_baaa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_baac, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_bab2, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_bab5, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_bab8, 7); mov(memd[ss, ebp - 0xc], 0x7fff);       /* mov dword [ebp-0xc], 0x7fff */
            ii(0x1011_babf, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_bac2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_bac4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_bac5, 1); pop(edi);                               /* pop edi */
            ii(0x1011_bac6, 1); pop(esi);                               /* pop esi */
            ii(0x1011_bac7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_bac8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_bac9, 1); ret();                                  /* ret */
        }
    }
}
