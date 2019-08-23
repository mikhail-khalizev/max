using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_82da-137dc585")]
        public void Method_1013_82da()
        {
            ii(0x1013_82da, 5); push(0x20);                             /* push 0x20 */
            ii(0x1013_82df, 5); call(Definitions.sys_check_available_stack_size, 0x2_da6e); /* call 0x10165d52 */
            ii(0x1013_82e4, 1); push(ebx);                              /* push ebx */
            ii(0x1013_82e5, 1); push(ecx);                              /* push ecx */
            ii(0x1013_82e6, 1); push(edx);                              /* push edx */
            ii(0x1013_82e7, 1); push(esi);                              /* push esi */
            ii(0x1013_82e8, 1); push(edi);                              /* push edi */
            ii(0x1013_82e9, 1); push(ebp);                              /* push ebp */
            ii(0x1013_82ea, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_82ec, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1013_82f2, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_82f5, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_82f9, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1013_82fe, 5); call(0x1013_dc59, 0x5956);              /* call 0x1013dc59 */
            ii(0x1013_8303, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_8305, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_8306, 1); pop(edi);                               /* pop edi */
            ii(0x1013_8307, 1); pop(esi);                               /* pop esi */
            ii(0x1013_8308, 1); pop(edx);                               /* pop edx */
            ii(0x1013_8309, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_830a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_830b, 1); ret();                                  /* ret */
        }
    }
}
