using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_a026-af623c7f")]
        public void Method_1009_a026()
        {
            ii(0x1009_a026, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_a02b, 5); call(Definitions.sys_check_available_stack_size, 0xc_bd22); /* call 0x10165d52 */
            ii(0x1009_a030, 1); push(ebx);                              /* push ebx */
            ii(0x1009_a031, 1); push(ecx);                              /* push ecx */
            ii(0x1009_a032, 1); push(edx);                              /* push edx */
            ii(0x1009_a033, 1); push(esi);                              /* push esi */
            ii(0x1009_a034, 1); push(edi);                              /* push edi */
            ii(0x1009_a035, 1); push(ebp);                              /* push ebp */
            ii(0x1009_a036, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_a038, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1009_a03e, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_a041, 4); mov(memb[ss, ebp - 8], 0x1b);           /* mov byte [ebp-0x8], 0x1b */
            ii(0x1009_a045, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1009_a048, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_a04a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_a04b, 1); pop(edi);                               /* pop edi */
            ii(0x1009_a04c, 1); pop(esi);                               /* pop esi */
            ii(0x1009_a04d, 1); pop(edx);                               /* pop edx */
            ii(0x1009_a04e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_a04f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_a050, 1); ret();                                  /* ret */
        }
    }
}
