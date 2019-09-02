using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_030c-36876193")]
        public void Method_1012_030c()
        {
            ii(0x1012_030c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1012_0311, 5); call(Definitions.sys_check_available_stack_size, 0x4_5a3c); /* call 0x10165d52 */
            ii(0x1012_0316, 1); push(ebx);                              /* push ebx */
            ii(0x1012_0317, 1); push(ecx);                              /* push ecx */
            ii(0x1012_0318, 1); push(esi);                              /* push esi */
            ii(0x1012_0319, 1); push(edi);                              /* push edi */
            ii(0x1012_031a, 1); push(ebp);                              /* push ebp */
            ii(0x1012_031b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_031d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_0323, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_0326, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1012_0329, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_032e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_0331, 5); call(Definitions.my_dtor_0x101b_6edc, 0x1_a90f); /* call 0x1013ac45 */
            ii(0x1012_0336, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_0339, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_033c, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1012_033f, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_0342, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0344, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_0345, 1); pop(edi);                               /* pop edi */
            ii(0x1012_0346, 1); pop(esi);                               /* pop esi */
            ii(0x1012_0347, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_0348, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_0349, 1); ret();                                  /* ret */
        }
    }
}
