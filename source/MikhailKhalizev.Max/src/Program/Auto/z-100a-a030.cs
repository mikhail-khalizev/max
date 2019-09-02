using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a030-a6180e94")]
        public void Method_100a_a030()
        {
            ii(0x100a_a030, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_a035, 5); call(Definitions.sys_check_available_stack_size, 0xb_bd18); /* call 0x10165d52 */
            ii(0x100a_a03a, 1); push(ebx);                              /* push ebx */
            ii(0x100a_a03b, 1); push(ecx);                              /* push ecx */
            ii(0x100a_a03c, 1); push(esi);                              /* push esi */
            ii(0x100a_a03d, 1); push(edi);                              /* push edi */
            ii(0x100a_a03e, 1); push(ebp);                              /* push ebp */
            ii(0x100a_a03f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a041, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a047, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a04a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_a04d, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100a_a052, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a055, 5); call(0x1013_a1be, 0x9_0164);            /* call 0x1013a1be */
            ii(0x100a_a05a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a05d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a060, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_a063, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_a066, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a068, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_a069, 1); pop(edi);                               /* pop edi */
            ii(0x100a_a06a, 1); pop(esi);                               /* pop esi */
            ii(0x100a_a06b, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_a06c, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_a06d, 1); ret();                                  /* ret */
        }
    }
}
