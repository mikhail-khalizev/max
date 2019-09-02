using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_af44-b27d19de")]
        public void Method_100a_af44()
        {
            ii(0x100a_af44, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_af49, 5); call(Definitions.sys_check_available_stack_size, 0xb_ae04); /* call 0x10165d52 */
            ii(0x100a_af4e, 1); push(ebx);                              /* push ebx */
            ii(0x100a_af4f, 1); push(ecx);                              /* push ecx */
            ii(0x100a_af50, 1); push(esi);                              /* push esi */
            ii(0x100a_af51, 1); push(edi);                              /* push edi */
            ii(0x100a_af52, 1); push(ebp);                              /* push ebp */
            ii(0x100a_af53, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_af55, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_af5b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_af5e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_af61, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_af64, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_af67, 5); call(0x1007_6c98, -0x3_42d4);           /* call 0x10076c98 */
            ii(0x100a_af6c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_af6f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_af72, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_af74, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_af75, 1); pop(edi);                               /* pop edi */
            ii(0x100a_af76, 1); pop(esi);                               /* pop esi */
            ii(0x100a_af77, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_af78, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_af79, 1); ret();                                  /* ret */
        }
    }
}
