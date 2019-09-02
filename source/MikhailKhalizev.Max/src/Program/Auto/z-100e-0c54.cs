using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0c54-6dd027b2")]
        public void Method_100e_0c54()
        {
            ii(0x100e_0c54, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_0c59, 5); call(Definitions.sys_check_available_stack_size, 0x8_50f4); /* call 0x10165d52 */
            ii(0x100e_0c5e, 1); push(ebx);                              /* push ebx */
            ii(0x100e_0c5f, 1); push(ecx);                              /* push ecx */
            ii(0x100e_0c60, 1); push(esi);                              /* push esi */
            ii(0x100e_0c61, 1); push(edi);                              /* push edi */
            ii(0x100e_0c62, 1); push(ebp);                              /* push ebp */
            ii(0x100e_0c63, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0c65, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_0c6b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_0c6e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_0c71, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100e_0c74, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_0c77, 5); call(0x1013_a66b, 0x5_99ef);            /* call 0x1013a66b */
            ii(0x100e_0c7c, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x100e_0c7f, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100e_0c82, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0c84, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_0c85, 1); pop(edi);                               /* pop edi */
            ii(0x100e_0c86, 1); pop(esi);                               /* pop esi */
            ii(0x100e_0c87, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_0c88, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_0c89, 1); ret();                                  /* ret */
        }
    }
}
