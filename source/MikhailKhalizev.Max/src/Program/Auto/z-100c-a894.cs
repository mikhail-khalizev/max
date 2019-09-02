using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a894-1cf10761")]
        public void Method_100c_a894()
        {
            ii(0x100c_a894, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_a899, 5); call(Definitions.sys_check_available_stack_size, 0x9_b4b4); /* call 0x10165d52 */
            ii(0x100c_a89e, 1); push(ebx);                              /* push ebx */
            ii(0x100c_a89f, 1); push(ecx);                              /* push ecx */
            ii(0x100c_a8a0, 1); push(esi);                              /* push esi */
            ii(0x100c_a8a1, 1); push(edi);                              /* push edi */
            ii(0x100c_a8a2, 1); push(ebp);                              /* push ebp */
            ii(0x100c_a8a3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a8a5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a8ab, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_a8ae, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_a8b1, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100c_a8b4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a8b7, 5); call(0x1013_ac7d, 0x7_03c1);            /* call 0x1013ac7d */
            ii(0x100c_a8bc, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100c_a8bf, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100c_a8c2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a8c4, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_a8c5, 1); pop(edi);                               /* pop edi */
            ii(0x100c_a8c6, 1); pop(esi);                               /* pop esi */
            ii(0x100c_a8c7, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_a8c8, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_a8c9, 1); ret();                                  /* ret */
        }
    }
}
