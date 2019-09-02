using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_6bb8-8c8fa96")]
        public void Method_100d_6bb8()
        {
            ii(0x100d_6bb8, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_6bbd, 5); call(Definitions.sys_check_available_stack_size, 0x8_f190); /* call 0x10165d52 */
            ii(0x100d_6bc2, 1); push(ebx);                              /* push ebx */
            ii(0x100d_6bc3, 1); push(ecx);                              /* push ecx */
            ii(0x100d_6bc4, 1); push(esi);                              /* push esi */
            ii(0x100d_6bc5, 1); push(edi);                              /* push edi */
            ii(0x100d_6bc6, 1); push(ebp);                              /* push ebp */
            ii(0x100d_6bc7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_6bc9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_6bcf, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_6bd2, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_6bd5, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100d_6bd9, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100d_6bdc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_6bde, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_6bdf, 1); pop(edi);                               /* pop edi */
            ii(0x100d_6be0, 1); pop(esi);                               /* pop esi */
            ii(0x100d_6be1, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_6be2, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_6be3, 1); ret();                                  /* ret */
        }
    }
}
